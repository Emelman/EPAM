namespace UsersAndRewards.PL.WinForms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.ctlUsersPage = new System.Windows.Forms.TabPage();
            this.ctlUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rewards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddUserContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelUserContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRewardsPage = new System.Windows.Forms.TabPage();
            this.ctlRewards = new System.Windows.Forms.DataGridView();
            this.RewardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlRewardMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStripeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RewardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlMainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab.SuspendLayout();
            this.ctlUsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).BeginInit();
            this.ctlContextMenu.SuspendLayout();
            this.ctlRewardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewards)).BeginInit();
            this.ctrlRewardMenu.SuspendLayout();
            this.ctlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.ctlUsersPage);
            this.ctlTab.Controls.Add(this.ctlRewardsPage);
            this.ctlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTab.Location = new System.Drawing.Point(0, 36);
            this.ctlTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(558, 259);
            this.ctlTab.TabIndex = 0;
            // 
            // ctlUsersPage
            // 
            this.ctlUsersPage.Controls.Add(this.ctlUsers);
            this.ctlUsersPage.Location = new System.Drawing.Point(4, 25);
            this.ctlUsersPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlUsersPage.Name = "ctlUsersPage";
            this.ctlUsersPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlUsersPage.Size = new System.Drawing.Size(550, 230);
            this.ctlUsersPage.TabIndex = 0;
            this.ctlUsersPage.Text = "Users";
            this.ctlUsersPage.UseVisualStyleBackColor = true;
            // 
            // ctlUsers
            // 
            this.ctlUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Birthdate,
            this.Age,
            this.Rewards});
            this.ctlUsers.ContextMenuStrip = this.ctlContextMenu;
            this.ctlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsers.Location = new System.Drawing.Point(4, 4);
            this.ctlUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlUsers.MultiSelect = false;
            this.ctlUsers.Name = "ctlUsers";
            this.ctlUsers.RowHeadersVisible = false;
            this.ctlUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlUsers.Size = new System.Drawing.Size(542, 222);
            this.ctlUsers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "UserId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Rewards
            // 
            this.Rewards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rewards.DataPropertyName = "Rewards";
            this.Rewards.HeaderText = "Rewards";
            this.Rewards.Name = "Rewards";
            // 
            // ctlContextMenu
            // 
            this.ctlContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUserContextMenu,
            this.btnDelUserContextMenu,
            this.rewardUserToolStripMenuItem});
            this.ctlContextMenu.Name = "ctlContextMenu";
            this.ctlContextMenu.Size = new System.Drawing.Size(195, 100);
            // 
            // btnAddUserContextMenu
            // 
            this.btnAddUserContextMenu.Name = "btnAddUserContextMenu";
            this.btnAddUserContextMenu.Size = new System.Drawing.Size(194, 32);
            this.btnAddUserContextMenu.Text = "Add User...";
            this.btnAddUserContextMenu.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnDelUserContextMenu
            // 
            this.btnDelUserContextMenu.Name = "btnDelUserContextMenu";
            this.btnDelUserContextMenu.Size = new System.Drawing.Size(194, 32);
            this.btnDelUserContextMenu.Text = "Delete User";
            this.btnDelUserContextMenu.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // rewardUserToolStripMenuItem
            // 
            this.rewardUserToolStripMenuItem.Name = "rewardUserToolStripMenuItem";
            this.rewardUserToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.rewardUserToolStripMenuItem.Text = "Change User";
            this.rewardUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserMenuItem_Click);
            // 
            // ctlRewardsPage
            // 
            this.ctlRewardsPage.Controls.Add(this.ctlRewards);
            this.ctlRewardsPage.Location = new System.Drawing.Point(4, 25);
            this.ctlRewardsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlRewardsPage.Name = "ctlRewardsPage";
            this.ctlRewardsPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlRewardsPage.Size = new System.Drawing.Size(940, 495);
            this.ctlRewardsPage.TabIndex = 1;
            this.ctlRewardsPage.Text = "Rewards";
            this.ctlRewardsPage.UseVisualStyleBackColor = true;
            // 
            // ctlRewards
            // 
            this.ctlRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RewardID,
            this.RewardName,
            this.RewardDescription});
            this.ctlRewards.ContextMenuStrip = this.ctrlRewardMenu;
            this.ctlRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRewards.Location = new System.Drawing.Point(4, 4);
            this.ctlRewards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlRewards.MultiSelect = false;
            this.ctlRewards.Name = "ctlRewards";
            this.ctlRewards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctlRewards.RowHeadersVisible = false;
            this.ctlRewards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlRewards.Size = new System.Drawing.Size(932, 487);
            this.ctlRewards.TabIndex = 0;
            // 
            // RewardID
            // 
            this.RewardID.ContextMenuStrip = this.ctrlRewardMenu;
            this.RewardID.DataPropertyName = "RewardId";
            this.RewardID.HeaderText = "Id";
            this.RewardID.Name = "RewardID";
            this.RewardID.Visible = false;
            // 
            // ctrlRewardMenu
            // 
            this.ctrlRewardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctrlRewardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripeItem,
            this.deleteStripeItem,
            this.changeRewardToolStripMenuItem});
            this.ctrlRewardMenu.Name = "ctrlCntRewardMenu";
            this.ctrlRewardMenu.Size = new System.Drawing.Size(233, 100);
            // 
            // addStripeItem
            // 
            this.addStripeItem.Name = "addStripeItem";
            this.addStripeItem.Size = new System.Drawing.Size(232, 32);
            this.addStripeItem.Text = "Add Reward...";
            this.addStripeItem.Click += new System.EventHandler(this.BtnAddReward_Click);
            // 
            // deleteStripeItem
            // 
            this.deleteStripeItem.Name = "deleteStripeItem";
            this.deleteStripeItem.Size = new System.Drawing.Size(232, 32);
            this.deleteStripeItem.Text = "Delete Reward...";
            this.deleteStripeItem.Click += new System.EventHandler(this.DeleteRewardStripeItem_Click);
            // 
            // changeRewardToolStripMenuItem
            // 
            this.changeRewardToolStripMenuItem.Name = "changeRewardToolStripMenuItem";
            this.changeRewardToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.changeRewardToolStripMenuItem.Text = "Change Reward...";
            this.changeRewardToolStripMenuItem.Click += new System.EventHandler(this.ChangeRewardMenuItem_Click);
            // 
            // RewardName
            // 
            this.RewardName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RewardName.ContextMenuStrip = this.ctrlRewardMenu;
            this.RewardName.DataPropertyName = "RewardTitle";
            this.RewardName.HeaderText = "Title";
            this.RewardName.Name = "RewardName";
            this.RewardName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RewardDescription
            // 
            this.RewardDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RewardDescription.ContextMenuStrip = this.ctrlRewardMenu;
            this.RewardDescription.DataPropertyName = "RewardDescription";
            this.RewardDescription.HeaderText = "Description";
            this.RewardDescription.Name = "RewardDescription";
            // 
            // ctlMainMenu
            // 
            this.ctlMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileMenu,
            this.ctlEditMenu});
            this.ctlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ctlMainMenu.Name = "ctlMainMenu";
            this.ctlMainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.ctlMainMenu.Size = new System.Drawing.Size(558, 36);
            this.ctlMainMenu.TabIndex = 1;
            this.ctlMainMenu.Text = "menuStrip1";
            // 
            // ctlFileMenu
            // 
            this.ctlFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1});
            this.ctlFileMenu.Name = "ctlFileMenu";
            this.ctlFileMenu.Size = new System.Drawing.Size(54, 32);
            this.ctlFileMenu.Text = "&File";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(193, 32);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // ctlEditMenu
            // 
            this.ctlEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUser,
            this.btnAddReward});
            this.ctlEditMenu.Name = "ctlEditMenu";
            this.ctlEditMenu.Size = new System.Drawing.Size(58, 32);
            this.ctlEditMenu.Text = "Edit";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(209, 32);
            this.btnAddUser.Text = "Add User...";
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnAddReward
            // 
            this.btnAddReward.Name = "btnAddReward";
            this.btnAddReward.Size = new System.Drawing.Size(209, 32);
            this.btnAddReward.Text = "Add Reward...";
            this.btnAddReward.Click += new System.EventHandler(this.BtnAddReward_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 295);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.ctlMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Users And Rewards";
            this.ctlTab.ResumeLayout(false);
            this.ctlUsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).EndInit();
            this.ctlContextMenu.ResumeLayout(false);
            this.ctlRewardsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewards)).EndInit();
            this.ctrlRewardMenu.ResumeLayout(false);
            this.ctlMainMenu.ResumeLayout(false);
            this.ctlMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl ctlTab;
		private System.Windows.Forms.TabPage ctlUsersPage;
		private System.Windows.Forms.TabPage ctlRewardsPage;
		private System.Windows.Forms.MenuStrip ctlMainMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlFileMenu;
		private System.Windows.Forms.ToolStripMenuItem btnExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ctlEditMenu;
		private System.Windows.Forms.ToolStripMenuItem btnAddUser;
		private System.Windows.Forms.ToolStripMenuItem btnAddReward;
		private System.Windows.Forms.DataGridView ctlUsers;
		private System.Windows.Forms.ContextMenuStrip ctlContextMenu;
		private System.Windows.Forms.ToolStripMenuItem btnAddUserContextMenu;
		private System.Windows.Forms.ToolStripMenuItem btnDelUserContextMenu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rewards;
        private System.Windows.Forms.DataGridView ctlRewards;
        private System.Windows.Forms.ContextMenuStrip ctrlRewardMenu;
        private System.Windows.Forms.ToolStripMenuItem addStripeItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStripeItem;
        private System.Windows.Forms.ToolStripMenuItem rewardUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRewardToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardDescription;
    }
}

