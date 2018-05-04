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
                var user = new User(userForm.FirstName, userForm.LastName, true, userForm.date);
                user.Rewards = userForm.rewardToAdd;
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
            // remove user
            var length = logic.GetUsers().Count;
            if (length <= 0)
            {
                WarningMessage("There are not any users to delete.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var deleteForm = new DeleteUserForm(logic.GetUsers());
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    if (WarningMessage("Are you sure?", "Warning") == DialogResult.Yes)
                    {
                        for (var i = 0; i < deleteForm.usersToDell.Count; i++)
                        {
                            logic.DeleteUser(deleteForm.usersToDell[i].UserId);
                        }
                        UpdateUsersGrid();
                    }
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
            // remove reward
            var length = logic.GetRewards().Count;
            if (length <= 0)
            {
                WarningMessage("There are not any rewards to delete.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var deleteForm = new DeleteRewardForm(logic.GetRewards());
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    if (WarningMessage("Are you sure?", "Warning") == DialogResult.Yes)
                    {
                        for (var i = 0; i < deleteForm.rewardToDell.Count; i++)
                        {
                            logic.DeleteReward(deleteForm.rewardToDell[i].RewardId);
                        }
                        UpdateRewardGrid();
                        UpdateUsersGrid();
                    }
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

        private void ChangeUserMenuItem_Click(object sender, EventArgs e)
        {
            var length = logic.GetUsers().Count;
            if (length <= 0)
            {
                WarningMessage("There are no any users to change!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var changeUser = new UpdateUserForm(logic.GetUsers());
                if (changeUser.ShowDialog() == DialogResult.OK)
                {
                    var userForm = new UserForm(logic.GetRewards(), changeUser.usersToUpdate);
                    if (userForm.ShowDialog() == DialogResult.OK)
                    {
                        var user = changeUser.usersToUpdate;
                        user.FirstName = userForm.FirstName;
                        user.LastName = userForm.LastName;
                        user.Birthdate = userForm.date;
                        user.Rewards = userForm.rewardToAdd;
                        logic.UpdateUser(user);
                        // initialization
                        UpdateUsersGrid();
                    }
                }
            }
        }
        private void ChangeRewardMenuItem_Click(object sender, EventArgs e)
        {
            var length = logic.GetRewards().Count;
            if (length <= 0)
            {
                WarningMessage("There are no any rewards to change!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var changeReward = new UpdateRewardForm(logic.GetRewards());
                if (changeReward.ShowDialog() == DialogResult.OK)
                {
                    var rewardForm = new RewardForm(changeReward.rewardToUpdate);
                    if (rewardForm.ShowDialog() == DialogResult.OK)
                    {
                        var rwrd = changeReward.rewardToUpdate;
                        rwrd.Title = rewardForm.RewardTitle;
                        rwrd.Description = rewardForm.RewardDescription;
                        logic.UpdateReward(rwrd);
                        UpdateRewardGrid();
                        UpdateUsersGrid();
                    }
                }
            }
        }
    }
}
