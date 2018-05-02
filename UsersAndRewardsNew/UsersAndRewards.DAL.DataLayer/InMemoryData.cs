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
            foreach(var user in users)
            {
                var usya = user.Rewards.Find(item => item.RewardId == rewardId);
                user.Rewards.Remove(usya);
            }
            var toDell = rewards.Find(item => item.RewardId == rewardId);
            rewards.Remove(toDell);
        }

		public void DeleteUser(int userId)
		{
            var usya = users.Find(item => item.UserId == userId);
            users.Remove(usya);
		}

		public Reward GetRewardById(int rewardId)
		{
            var rwrd = rewards.Find(item => item.RewardId == rewardId);
            return rwrd;
        }

		public List<Reward> GetRewards()
		{
			return rewards;
		}

		public User GetUserById(int userId)
		{
            var usya = users.Find(item => item.UserId == userId);
            return usya;
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
            var usya = users.Find(item => item.UserId == user.UserId);
            usya = user;
        }
	}
}
