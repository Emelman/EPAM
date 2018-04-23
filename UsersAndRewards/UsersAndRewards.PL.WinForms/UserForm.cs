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

namespace UsersAndRewards.PL.WinForms
{
    public partial class UserForm : Form
    {
        private ILogic logic;
        public UserForm(ILogic _logic)
        {
            InitializeComponent();
            logic = _logic;
        }
        private void AddUser()
        {
            //var userForm = new UserForm();
            //if (userForm.ShowDialog() == DialogResult.OK)
            //{
            //    var name = userForm.FirstName;
            //    var last = userForm.LastName;
            //    var user = new User();
            //    user.FirstName = name;
            //    user.LastName = last;
            //    user.Rewards = logic.GetRewards();
            //    // initialization
            //    logic.AddUser(user);
            //    UpdateUsersGrid();
            //}
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void regisrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new ArgumentException("Name cannot be empty or null!");
            //AddUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
