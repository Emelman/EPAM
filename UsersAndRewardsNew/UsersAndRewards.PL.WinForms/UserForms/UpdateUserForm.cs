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
    public partial class UpdateUserForm : Form
    {
        public User usersToUpdate;
        private List<User> users;
        public UpdateUserForm(List<User> _users)
        {
            users = _users;
            InitializeComponent();
            CreateCheckBoxList();
        }

        private void CreateCheckBoxList()
        {
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                usersToChangeList.Items.Add(user.FirstName + " " + user.LastName);
            }
        }

        private void UsersList_Validated(object sender, EventArgs e)
        {
            usersToUpdate = users[usersToChangeList.SelectedIndex];
        }
    }
}
