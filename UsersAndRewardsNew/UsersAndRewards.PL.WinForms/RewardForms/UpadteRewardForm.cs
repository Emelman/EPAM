using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms.RewardForms
{
    public partial class UpdateRewardForm : Form
    {
        public Reward rewardToUpdate;
        private List<Reward> rewards;
        public UpdateRewardForm(List<Reward> _reward)
        {
            rewards = _reward;
            InitializeComponent();
            CreateCheckBoxList();
        }

        private void CreateCheckBoxList()
        {
            for (int i = 0; i < rewards.Count; i++)
            {
                Reward reward = rewards[i];
                rewardsToChangeList.Items.Add(reward.Title);
            }
        }

        private void UsersList_Validated(object sender, EventArgs e)
        {
            rewardToUpdate = rewards[rewardsToChangeList.SelectedIndex];
        }
    }
}
