namespace UsersAndRewards.PL.WinForms.UserForms
{
    partial class RewardToUserForm
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
            this.lblChooseUser = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.listBoxRewards = new System.Windows.Forms.CheckedListBox();
            this.lblChooseReward = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseUser
            // 
            this.lblChooseUser.AutoSize = true;
            this.lblChooseUser.Location = new System.Drawing.Point(51, 18);
            this.lblChooseUser.Name = "lblChooseUser";
            this.lblChooseUser.Size = new System.Drawing.Size(68, 13);
            this.lblChooseUser.TabIndex = 3;
            this.lblChooseUser.Text = "Choose User";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Items.AddRange(new object[] {
            "money ",
            "funny"});
            this.listBoxUsers.Location = new System.Drawing.Point(12, 43);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(170, 154);
            this.listBoxUsers.TabIndex = 5;
            // 
            // listBoxRewards
            // 
            this.listBoxRewards.FormattingEnabled = true;
            this.listBoxRewards.Location = new System.Drawing.Point(204, 43);
            this.listBoxRewards.Name = "listBoxRewards";
            this.listBoxRewards.Size = new System.Drawing.Size(170, 154);
            this.listBoxRewards.TabIndex = 6;
            // 
            // lblChooseReward
            // 
            this.lblChooseReward.AutoSize = true;
            this.lblChooseReward.Location = new System.Drawing.Point(247, 18);
            this.lblChooseReward.Name = "lblChooseReward";
            this.lblChooseReward.Size = new System.Drawing.Size(83, 13);
            this.lblChooseReward.TabIndex = 7;
            this.lblChooseReward.Text = "Choose Reward";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(299, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(218, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // RewardToUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(386, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblChooseReward);
            this.Controls.Add(this.listBoxRewards);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.lblChooseUser);
            this.Name = "RewardToUserForm";
            this.Text = "RewardToUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseUser;
        private System.Windows.Forms.CheckedListBox listBoxUsers;
        private System.Windows.Forms.CheckedListBox listBoxRewards;
        private System.Windows.Forms.Label lblChooseReward;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}