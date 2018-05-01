using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms.UserForms
{
	public partial class UserForm : Form
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
        public DateTime date { get; private set; }
        public List<Reward> rewardToAdd = new List<Reward>();
        private List<Reward> rewards;
        private List<User> users;

		public UserForm(List<Reward> _rewards, List<User> _users)
		{
            rewards = _rewards;
            users = _users;
			InitializeComponent();
            InitCheckedBoxList();
		}

        private void InitCheckedBoxList()
        {
            for (int i = 0; i < rewards.Count; i++)
            {
                Reward rwrd = rewards[i];
                rewardList.Items.Add(rwrd.Title, CheckState.Unchecked);
            }
        }

        //private void rewardList_Validating(object sender, CancelEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void RewardList_Validated(object sender, EventArgs e)
        {
            foreach (int indexChecked in rewardList.CheckedIndices)
            {
                // The indexChecked variable contains the index of the item.
                //MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                //            rewardList.GetItemCheckState(indexChecked).ToString() + ".");

                rewardToAdd.Add(rewards[indexChecked]);
            }

            
        }

        private void BtnOK_Click(object sender, EventArgs e)
		{
			if (!ValidateChildren())
			{
				DialogResult = DialogResult.None;
			}
		}

		private void Validate(Control ctl, string ctrlValue, string errorMessage, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(ctrlValue))
			{
				ctlErrorProvider.SetError(ctl, errorMessage);
				e.Cancel = true;
			}
			else
			{
				ctlErrorProvider.SetError(txtFirstName, string.Empty);
				e.Cancel = false;
			}
		}

		private void TxtFirstName_Validating(object sender, CancelEventArgs e)
		{
			Validate(txtFirstName, txtFirstName.Text.Trim(), "Name cannot be empty", e);
		}

		private void TxtFirstName_Validated(object sender, EventArgs e)
		{
			FirstName = txtFirstName.Text.Trim();
		}

		private void TxtLastName_Validating(object sender, CancelEventArgs e)
		{
			Validate(txtLastName, txtLastName.Text.Trim(), "Last Name cannot be empty", e);
		}

		private void TxtLastName_Validated(object sender, EventArgs e)
		{
			LastName = txtLastName.Text.Trim();
		}

        private void CtlBirthdate_ValueChanged(object sender, EventArgs e)
        {
            date = ctlBirthdate.Value;
        }

        private void CtlBirthdate_Validating(object sender, EventArgs e)
        {
            if(date.Year == 1)
            {
                ctlBirthdate.Value = DateTime.Now;
                date = ctlBirthdate.Value;
            }
        }
    }
}
