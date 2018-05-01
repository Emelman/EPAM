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
            HardCodeRewards();
        }

        private void HardCodeRewards()
        {
            var rwrd = new Reward();
            rwrd.Description = "get some money";
            rwrd.Title = "Money";
            AddReward(rwrd);
            rwrd = new Reward();
            rwrd.Description = "did something";
            rwrd.Title = "WOrker";
            AddReward(rwrd);
            rwrd = new Reward();
            rwrd.Title = "Big Man";
            rwrd.Description = "Become high anough";
            AddReward(rwrd);
        }

        public void AddReward(Reward reward)
		{
            var maxId = 0;
            var ids = rewards.Select(u => u.RewardId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }
            reward.RewardId = maxId + 1;
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
            if (rewards.Count <= rewardId)
            {
                throw new IndexOutOfRangeException("There is no reward with such ID!");
            }
            
            foreach(var user in users)
            {
                var usya = user.Rewards.Find(item => item.RewardId == rewards[rewardId].RewardId);
                user.Rewards.Remove(usya);
            }
            rewards.RemoveAt(rewardId);
        }

		public void DeleteUser(int userId)
		{
			if(users.Count <= userId)
            {
                throw new IndexOutOfRangeException("There is no user with such ID!");
            }
            users.RemoveAt(userId);
		}

		public Reward GetRewardById(int rewardId)
		{
            if(rewards.Count <= rewardId)
            {
                throw new IndexOutOfRangeException("Out of Range!");
            }
            return rewards.ElementAt(rewardId);
        }

		public List<Reward> GetRewards()
		{
			return rewards;
		}

		public User GetUserById(int userId)
		{
            if (users.Count <= userId)
            {
                throw new IndexOutOfRangeException("Out of Range!");
            }
            return users.ElementAt(userId);
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
