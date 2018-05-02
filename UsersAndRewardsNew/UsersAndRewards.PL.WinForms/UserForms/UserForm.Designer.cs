using System;

namespace UsersAndRewards.PL.WinForms.UserForms
{
	partial class UserForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.ctlBirthdate = new System.Windows.Forms.DateTimePicker();
            this.ctlErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rewardList = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(136, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(217, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(29, 98);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 4;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.TxtFirstName_Validated);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(92, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.TxtLastName_Validated);
            // 
            // ctlBirthdate
            // 
            this.ctlBirthdate.Location = new System.Drawing.Point(92, 92);
            this.ctlBirthdate.Name = "ctlBirthdate";
            this.ctlBirthdate.Size = new System.Drawing.Size(200, 20);
            this.ctlBirthdate.TabIndex = 7;
            this.ctlBirthdate.ValueChanged += new System.EventHandler(this.CtlBirthdate_ValueChanged);
            this.ctlBirthdate.Validating += new System.ComponentModel.CancelEventHandler(this.CtlBirthdate_Validating);
            // 
            // ctlErrorProvider
            // 
            this.ctlErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlErrorProvider.ContainerControl = this;
            // 
            // rewardList
            // 
            this.rewardList.FormattingEnabled = true;
            this.rewardList.Location = new System.Drawing.Point(32, 130);
            this.rewardList.Name = "rewardList";
            this.rewardList.Size = new System.Drawing.Size(260, 124);
            this.rewardList.TabIndex = 8;
            this.rewardList.Validated += new System.EventHandler(this.RewardList_Validated);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(328, 305);
            this.Controls.Add(this.rewardList);
            this.Controls.Add(this.ctlBirthdate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.ctlErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblBirthdate;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.DateTimePicker ctlBirthdate;
		private System.Windows.Forms.ErrorProvider ctlErrorProvider;
        private System.Windows.Forms.CheckedListBox rewardList;
    }
}