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
    public partial class ChangeUserForm : Form
    {
        public List<User> usersToDell = new List<User>();
        private List<User> users;

        public ChangeUserForm(List<User> _users)
        {
            users = _users;
            InitializeComponent();
            CreateCheckBoxList(users);
        }

        private void CreateCheckBoxList(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                listBoxUsers.Items.Add(user.FirstName + " " + user.LastName, CheckState.Unchecked);
            }
        }

        private void UsersList_Validated(object sender, EventArgs e)
        {
            usersToDell = new List<User>();
            foreach (int indexChecked in listBoxUsers.CheckedIndices)
            {
                usersToDell.Add(users[indexChecked]);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (int indexChecked in listBoxUsers.CheckedIndices)
            //{
            //    usersToDell.Add(users[indexChecked]);
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
