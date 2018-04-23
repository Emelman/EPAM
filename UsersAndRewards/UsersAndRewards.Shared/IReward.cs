using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.Shared
{
    public interface IReward
    {
        List<Reward> GetRewards();

        Reward GetRewardById(int rewardId);

        void AddReward(Reward reward);

        void UpdateReward(Reward reward);

        void DeleteReward(int rewardId);
    }
}
