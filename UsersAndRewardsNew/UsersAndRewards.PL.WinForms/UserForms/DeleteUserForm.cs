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
    public partial class DeleteUserForm : Form
    {
        public List<User> usersToDell = new List<User>();
        private List<User> users;

        public DeleteUserForm(List<User> list)
        {
            users = list;
            InitializeComponent();
            InitCheckedBoxList();
        }

        private void InitCheckedBoxList()
        {
            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                usersList.Items.Add(user.FirstName + " " + user.LastName, CheckState.Unchecked);
            }
        }

        private void UsersList_Validated(object sender, EventArgs e)
        {
            foreach (int indexChecked in usersList.CheckedIndices)
            {
                usersToDell.Add(users[indexChecked]);
            }
        }
    }
}
