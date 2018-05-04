using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public class RewardViewModel
    {
        public int RewardId { get; set; }
        public string RewardTitle { get; set; }
        public string RewardDescription { get; set; }

        public static RewardViewModel ToModel(Reward reward)
        {
            var model = new RewardViewModel();
            model.RewardId = reward.RewardId;
            model.RewardTitle = reward.Title;
            model.RewardDescription = reward.Description;
            return model;
        }
    }
}
