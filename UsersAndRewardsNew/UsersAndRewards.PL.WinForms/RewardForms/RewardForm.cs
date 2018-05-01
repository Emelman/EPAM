using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewards.PL.WinForms.RewardForms
{
    public partial class RewardForm : Form
    {
        public string RewardTitle { get; private set; }
        public string RewardDescription { get; private set; }


        public RewardForm()
        {
            InitializeComponent();
        }

        private void Validate(Control ctl, string ctrlValue, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlValue))
            {
                ctrlErrorProviderRwrd.SetError(ctl, errorMessage);
                e.Cancel = true;
            }
            else
            {
                ctrlErrorProviderRwrd.SetError(txtRewardTitle, string.Empty);
                e.Cancel = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }

        private void txtRwrdTitleValidated(object sender, EventArgs e)
        {
            RewardTitle = txtRewardTitle.Text.Trim();
        }

        private void txtRwrdTitleValidating(object sender, CancelEventArgs e)
        {
            Validate(txtRewardTitle, txtRewardTitle.Text.Trim(), "Title can not be empty!", e);
        }

        private void txtRwrdDiescripValidated(object sender, EventArgs e)
        {
            RewardDescription = txtRewardDescrip.Text.Trim();
        }

        private void txtRwrdDiescripValidating(object sender, CancelEventArgs e)
        {
            Validate(txtRewardDescrip, txtRewardDescrip.Text.Trim(), "Description can not be empty!", e);
        }
    }
}
