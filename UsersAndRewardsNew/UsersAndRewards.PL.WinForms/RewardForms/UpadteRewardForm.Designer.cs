﻿namespace UsersAndRewards.PL.WinForms.RewardForms
{
    partial class UpdateRewardForm
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
            this.rewardsToChangeList = new System.Windows.Forms.ListBox();
            this.lblChangeUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rewardsToChangeList
            // 
            this.rewardsToChangeList.FormattingEnabled = true;
            this.rewardsToChangeList.Location = new System.Drawing.Point(12, 36);
            this.rewardsToChangeList.Name = "rewardsToChangeList";
            this.rewardsToChangeList.Size = new System.Drawing.Size(282, 147);
            this.rewardsToChangeList.TabIndex = 8;
            this.rewardsToChangeList.Validated += new System.EventHandler(UsersList_Validated);
            // 
            // lblChangeUser
            // 
            this.lblChangeUser.AutoSize = true;
            this.lblChangeUser.Location = new System.Drawing.Point(77, 11);
            this.lblChangeUser.Name = "lblChangeUser";
            this.lblChangeUser.Size = new System.Drawing.Size(132, 13);
            this.lblChangeUser.TabIndex = 7;
            this.lblChangeUser.Text = "Choose reward to change:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(219, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(123, 195);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // UpadteRewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 229);
            this.Controls.Add(this.rewardsToChangeList);
            this.Controls.Add(this.lblChangeUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "UpadteRewardForm";
            this.Text = "UpadteRewardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rewardsToChangeList;
        private System.Windows.Forms.Label lblChangeUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}