using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public class Reward
    {
        private int id;
        public string RewardName;
        public string Description { get; set; }
        public int Id { get => id; set => id = value; }
    }
}
