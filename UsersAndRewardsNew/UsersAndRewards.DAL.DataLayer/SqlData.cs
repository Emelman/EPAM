using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
    public class SqlData : IData
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private SqlCommand DefaultConnectionCommand(string procedureName, CommandType storedProcedure)
        {
            var command = new SqlCommand();
            command.CommandText = procedureName;
            command.CommandType = storedProcedure;
            return command;
        }

        public void AddReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("AddReward", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@Title", reward.Title);
                command.Parameters.AddWithValue("@DescriptRwrd", reward.Description);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }

        public void AddUser(User user) 
        {
            using (var connection = new SqlConnection(connectionString))
            {
                DataTable tvp = new DataTable();
                tvp.Columns.Add("Id", typeof(Int32));
                foreach (var reward in user.Rewards)
                {
                    tvp.Rows.Add(reward.RewardId);
                }
                var command = DefaultConnectionCommand("AddUsers",CommandType.StoredProcedure);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthdate);
                SqlParameter tvparam = command.Parameters.AddWithValue("@rewardIds", tvp);
                tvparam.SqlDbType = SqlDbType.Structured;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteReward(int rewardId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("DeleteReward", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@RewardId", rewardId);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("DeleteUser", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }

        public Reward GetRewardById(int rewardId)
        {
            var reward = new Reward();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("GetRewardById", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@RewardId", rewardId);
                connection.Open();
                
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    reward.RewardId = reader.GetInt32(0);
                    reward.Title = reader.GetString(1);
                    reward.Description = reader.GetString(2);
                }
            }
            return reward;
        }

        public List<Reward> GetRewards()
        {
            List<Reward> rewards = new List<Reward>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("GetRewards", CommandType.StoredProcedure);
                command.Connection = connection;
                connection.Open();
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rwrd = new Reward();
                        rwrd.RewardId = reader.GetInt32(0);
                        rwrd.Title = reader.GetString(1);
                        rwrd.Description = reader.GetString(2);
                        rewards.Add(rwrd);
                    }
                }
            }
            return rewards;
        }

        public User GetUserById(int userId)
        {
            User user = new User();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("GetUserById", CommandType.StoredProcedure);
                command.Connection = connection;
                connection.Open();
                command.Parameters.AddWithValue("@id", userId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User(reader.GetString(1), reader.GetString(2), true, reader.GetDateTime(3));
                        user.UserId = reader.GetInt32(0);
                        user.Rewards = new List<Reward>();
                    }
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            var reward = new Reward();
                            reward.RewardId = reader.GetInt32(1);
                            reward.Title = reader.GetString(2);
                            reward.Description = reader.GetString(3);
                            user.Rewards.Add(reward);
                        }
                    }
                }
            }
            return user;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("GetAllUsers", CommandType.StoredProcedure);
                command.Connection = connection;
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userId = reader.GetInt32(0);
                        var firstName = (string)reader["FirstName"];
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        var user = new User(firstName, lastName, true, birthdate);
                        user.UserId = userId;
                        user.Rewards = new List<Reward>();
                        users.Add(user);
                    }
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            var reward = new Reward();
                            reward.RewardId = reader.GetInt32(1);
                            reward.Title = reader.GetString(2);
                            reward.Description = reader.GetString(3);
                            var usya = users.Find(item => item.UserId == reader.GetInt32(0));
                            usya.Rewards.Add(reward);
                        }
                    }
                }
            }
            return users;
        }

        public List<User> GetUsersAlter()
        {
            List<User> users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("GetAllUsers", CommandType.StoredProcedure);
                command.Connection = connection;
                connection.Open();

                using(var adapter = new SqlDataAdapter(command))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable tableA = ds.Tables[0];
                    DataTable tableB = ds.Tables[1];

                    var allRows = tableA.Rows;
                    for (var i = 0; i < allRows.Count; i++)
                    {
                        var element = allRows[i];
                        var user = new User(element.ItemArray[1].ToString(),
                            element.ItemArray[2].ToString(), true,
                            Convert.ToDateTime(element.ItemArray[3]));
                        user.UserId = Convert.ToInt32(element.ItemArray[0]);
                        user.Rewards = new List<Reward>();
                        users.Add(user);
                    }
                    allRows = tableB.Rows;
                    for (var i = 0; i < allRows.Count; i++)
                    {
                        var element = allRows[i];
                        var reward = new Reward();
                        reward.RewardId = Convert.ToInt32(element.ItemArray[1]);
                        reward.Title = element.ItemArray[2].ToString();
                        reward.Description = element.ItemArray[3].ToString();
                        users.Find(item => item.UserId == Convert.ToInt32(element.ItemArray[0])).Rewards.Add(reward);
                    }
                }
            }
            return users;
        }

        public void UpdateReward(Reward reward)  
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("UpdateReward", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@RewardId", reward.RewardId);
                command.Parameters.AddWithValue("@Title", reward.Title);
                command.Parameters.AddWithValue("@DescriptRwrd", reward.Description);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }

        public void UpdateUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("UpdateUser", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthdate);
                connection.Open();
                var result = command.ExecuteScalar();
            }
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefaultConnectionCommand("RemoveUsersRewards", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserId", user.UserId);
                connection.Open();
                var result = command.ExecuteScalar();
            }
            foreach (var mc in user.Rewards)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = DefaultConnectionCommand("AddRewardToUser", CommandType.StoredProcedure);
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@UserId", user.UserId);
                    command.Parameters.AddWithValue("@RewardID", mc.RewardId);
                    connection.Open();
                    command.ExecuteScalar();
                }
            }
        }
    }
}
