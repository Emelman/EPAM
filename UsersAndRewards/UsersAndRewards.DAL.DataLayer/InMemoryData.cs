using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
    public class InMemoryData : IData
    {
        private List<User> users;

        private List<Reward> rewards;

        public InMemoryData()
        {
            users = new List<User>();
            rewards = new List<Reward>();
        }
        public void AddReward(Reward reward)
        {
            rewards.Add(reward);
        }

        public void AddUser(User user)
        {
            var maxId = 0;
            var ids = users.Select(u => u.UserId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            user.UserId = maxId + 1;
            users.Add(user);
        }

        public void DeleteReward(int rewardId)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Reward GetRewardById(int rewardId)
        {
            throw new NotImplementedException();
        }

        public List<Reward> GetRewards()
        {
            return rewards;
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void UpdateReward(Reward reward)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
