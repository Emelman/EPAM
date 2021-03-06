﻿using System;
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
                var row = ctlUsers.SelectedCells[0].RowIndex;
                var userId = ctlUsers["id", row];
                var id = Convert.ToInt32(userId.EditedFormattedValue);
                if (WarningMessage("Are you sure?", "Warning") == DialogResult.Yes)
                {
                    logic.DeleteUser(id);
                    UpdateUsersGrid();
                }
            }
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
                var row = ctlRewards.SelectedCells[0].RowIndex;
                var rewardId = ctlRewards["RewardID", row];
                var id = Convert.ToInt32(rewardId.EditedFormattedValue);
                if (WarningMessage("Are you sure?", "Warning") == DialogResult.Yes)
                {
                    logic.DeleteReward(id);
                    UpdateRewardGrid();
                    UpdateUsersGrid();
                }
            }
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
                var row = ctlUsers.SelectedCells[0].RowIndex;
                var userId = ctlUsers["id", row];
                var id = Convert.ToInt32(userId.EditedFormattedValue);
                var userForm = new UserForm(logic.GetRewards(), logic.GetUserById(id));
                if (userForm.ShowDialog() == DialogResult.OK)
                {
                    var user = logic.GetUserById(id);
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
        private void ChangeRewardMenuItem_Click(object sender, EventArgs e)
        {
            var length = logic.GetRewards().Count;
            if (length <= 0)
            {
                WarningMessage("There are no any rewards to change!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var row = ctlRewards.SelectedCells[0].RowIndex;
                var rewardId = ctlRewards["RewardID", row];
                var id = Convert.ToInt32(rewardId.EditedFormattedValue);
                var rewardForm = new RewardForm(logic.GetRewardById(id));
                if (rewardForm.ShowDialog() == DialogResult.OK)
                {
                    var rwrd = new Reward();
                    rwrd.Title = rewardForm.RewardTitle;
                    rwrd.Description = rewardForm.RewardDescription;
                    rwrd.RewardId = id;
                    logic.UpdateReward(rwrd);
                    UpdateRewardGrid();
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
    }
}
