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
    public partial class DeleteRewardForm : Form
    {
        public List<Reward> rewardToDell = new List<Reward>();
        private List<Reward> rewards;

        public DeleteRewardForm(List<Reward> list)
        {
            rewards = list;
            InitializeComponent();
            InitCheckedBoxList();
        }

        private void InitCheckedBoxList()
        {
            for (int i = 0; i < rewards.Count; i++)
            {
                Reward rwrd = rewards[i];
                rewardList.Items.Add(rwrd.Title, CheckState.Unchecked);
            }
        }

        private void RewardList_Validated(object sender, EventArgs e)
        {
            foreach (int indexChecked in rewardList.CheckedIndices)
            {
                rewardToDell.Add(rewards[indexChecked]);
            }
        }
    }
}
