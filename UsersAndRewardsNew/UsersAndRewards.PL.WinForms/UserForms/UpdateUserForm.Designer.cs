namespace UsersAndRewards.PL.WinForms.UserForms
{
    partial class UpdateUserForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblChangeUser = new System.Windows.Forms.Label();
            this.usersToChangeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(123, 206);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(219, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblChangeUser
            // 
            this.lblChangeUser.AutoSize = true;
            this.lblChangeUser.Location = new System.Drawing.Point(89, 19);
            this.lblChangeUser.Name = "lblChangeUser";
            this.lblChangeUser.Size = new System.Drawing.Size(120, 13);
            this.lblChangeUser.TabIndex = 3;
            this.lblChangeUser.Text = "Choose user to change:";
            // 
            // usersToChangeList
            // 
            this.usersToChangeList.FormattingEnabled = true;
            this.usersToChangeList.Location = new System.Drawing.Point(12, 45);
            this.usersToChangeList.Name = "usersToChangeList";
            this.usersToChangeList.Size = new System.Drawing.Size(282, 147);
            this.usersToChangeList.TabIndex = 4;
            this.usersToChangeList.Validated += new System.EventHandler(UsersList_Validated);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 240);
            this.Controls.Add(this.usersToChangeList);
            this.Controls.Add(this.lblChangeUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblChangeUser;
        private System.Windows.Forms.ListBox usersToChangeList;
    }
}