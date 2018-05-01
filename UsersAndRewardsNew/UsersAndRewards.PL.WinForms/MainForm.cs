using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UsersAndRewards.PL.WinForms.RewardForms;
using UsersAndRewards.PL.WinForms.UserForms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms
{
	public partial class MainForm : Form
	{
		private ILogic logic;

		public MainForm(ILogic logic)
		{
			InitializeComponent();
			this.logic = logic;
            UpdateUsersGrid();
            UpdateRewardGrid();
		}

		private void BtnAddUser_Click(object sender, EventArgs e)
		{
			AddUser();
		}

		private void BtnAddReward_Click(object sender, EventArgs e)
		{
            AddReward();
		}

		private void AddUser()
		{
			var userForm = new UserForm(logic.GetRewards(), logic.GetUsers());
			if (userForm.ShowDialog() == DialogResult.OK)
			{
				var user = new User(userForm.FirstName, userForm.LastName,true,userForm.date);
                //user.Rewards = logic.GetRewards();
                //userForm.
                user.Rewards = userForm.rewardToAdd;
                //foreach (var mc in logic.GetRewards())
                //{
                //    user.Rewards.Add(mc);
                //}

                //user.Rewards.Add(logic.GetRewardById(0));
				// initialization
				logic.AddUser(user);
				UpdateUsersGrid();
			}
		}

        private void AddReward()
        {
            var rewardForm = new RewardForm();
            if (rewardForm.ShowDialog() == DialogResult.OK)
            {
                var name = rewardForm.RewardTitle;
                var descrip = rewardForm.RewardDescription;
                var reward = new Reward();
                reward.Title = name;
                reward.Description = descrip;
                // initialization
                logic.AddReward(reward);
                UpdateRewardGrid();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
		{
            if (WarningMessage("Are you sure?", "Warning") == DialogResult.Yes)
            {
                // remove user
                var length = logic.GetUsers().Count;
                if (length <= 0)
                {
                    WarningMessage("There are no any users to delete.", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    logic.DeleteUser(DateUtils.RandomNumber(0, length));
                    UpdateUsersGrid();
                }
            }
        }

		private void UpdateUsersGrid()
		{
			var users = logic.GetUsersViewModel();
			ctlUsers.DataSource = users;
			ctlUsers.Refresh();
		}

        private void UpdateRewardGrid()
        {
            var rewards = logic.GetRewardViewModels();
            ctlRewards.DataSource = rewards;
            ctlRewardsPage.Refresh();
        }

        private void DeleteRewardStripeItem_Click(object sender, EventArgs e)
        {
            if (WarningMessage("Are you sure?", "Warning") == DialogResult.Yes)
            {
                // remove reward
                var length = logic.GetRewards().Count;
                if (length <= 0)
                {
                    WarningMessage("There are no any rewards to delete.", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    logic.DeleteReward(DateUtils.RandomNumber(0, length));
                    UpdateRewardGrid();
                    UpdateUsersGrid();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private DialogResult WarningMessage(string sentence1, string sentence2, MessageBoxButtons specificBox = MessageBoxButtons.YesNo)
        {
            var res = MessageBox.Show(
                sentence1,
                sentence2,
                specificBox,
                MessageBoxIcon.Warning);
            return res;
        }

        private void rewardUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rewardUser = new RewardToUserForm(logic.GetRewards(), logic.GetUsers());
            if (rewardUser.ShowDialog() == DialogResult.OK)
            {
                

                //var user = new User(userForm.FirstName, userForm.LastName, true, userForm.date);
                ////user.Rewards = logic.GetRewards();
                //user.Rewards = new List<Reward>();
                //user.Rewards.Add(logic.GetRewardById(0));
                //// initialization
                //logic.AddUser(user);
                //UpdateUsersGrid();
            }
        }

        private void ctlUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
