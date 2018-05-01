namespace UsersAndRewards.PL.WinForms.RewardForms
{
    partial class RewardForm
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
            this.txtRewardDescrip = new System.Windows.Forms.TextBox();
            this.txtRewardTitle = new System.Windows.Forms.TextBox();
            this.lblRwrdDescrip = new System.Windows.Forms.Label();
            this.lblRwrdTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlErrorProviderRwrd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlErrorProviderRwrd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRewardDescrip
            // 
            this.txtRewardDescrip.Location = new System.Drawing.Point(110, 44);
            this.txtRewardDescrip.Multiline = true;
            this.txtRewardDescrip.Name = "txtRewardDescrip";
            this.txtRewardDescrip.Size = new System.Drawing.Size(200, 75);
            this.txtRewardDescrip.TabIndex = 10;
            this.txtRewardDescrip.Validating += new System.ComponentModel.CancelEventHandler(this.txtRwrdDiescripValidating);
            this.txtRewardDescrip.Validated += new System.EventHandler(this.txtRwrdDiescripValidated);
            // 
            // txtRewardTitle
            // 
            this.txtRewardTitle.Location = new System.Drawing.Point(110, 12);
            this.txtRewardTitle.Name = "txtRewardTitle";
            this.txtRewardTitle.Size = new System.Drawing.Size(200, 20);
            this.txtRewardTitle.TabIndex = 9;
            this.txtRewardTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtRwrdTitleValidating);
            this.txtRewardTitle.Validated += new System.EventHandler(this.txtRwrdTitleValidated);
            // 
            // lblRwrdDescrip
            // 
            this.lblRwrdDescrip.AutoSize = true;
            this.lblRwrdDescrip.Location = new System.Drawing.Point(4, 44);
            this.lblRwrdDescrip.Name = "lblRwrdDescrip";
            this.lblRwrdDescrip.Size = new System.Drawing.Size(100, 13);
            this.lblRwrdDescrip.TabIndex = 8;
            this.lblRwrdDescrip.Text = "Reward Description";
            // 
            // lblRwrdTitle
            // 
            this.lblRwrdTitle.AutoSize = true;
            this.lblRwrdTitle.Location = new System.Drawing.Point(4, 15);
            this.lblRwrdTitle.Name = "lblRwrdTitle";
            this.lblRwrdTitle.Size = new System.Drawing.Size(67, 13);
            this.lblRwrdTitle.TabIndex = 7;
            this.lblRwrdTitle.Text = "Reward Title";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(154, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctrlErrorProviderRwrd
            // 
            this.ctrlErrorProviderRwrd.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctrlErrorProviderRwrd.ContainerControl = this;
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(337, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRewardDescrip);
            this.Controls.Add(this.txtRewardTitle);
            this.Controls.Add(this.lblRwrdDescrip);
            this.Controls.Add(this.lblRwrdTitle);
            this.Name = "RewardForm";
            this.Text = "RewardForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlErrorProviderRwrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRewardDescrip;
        private System.Windows.Forms.TextBox txtRewardTitle;
        private System.Windows.Forms.Label lblRwrdDescrip;
        private System.Windows.Forms.Label lblRwrdTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider ctrlErrorProviderRwrd;
    }
}