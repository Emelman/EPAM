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
    public partial class RewardToUserForm : Form
    {
        public RewardToUserForm(List<Shared.Reward> rewards, List<User> users)
        {
            InitializeComponent();
            CreateCheckBoxList(rewards);
        }

        private void CreateCheckBoxList(List<Reward> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Reward rwrd = list[i];
                listBoxRewards.Items.Add(rwrd.Title,CheckState.Unchecked);
            }
        }

    }
}
