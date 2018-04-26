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

        public string FirstName { get; private set; }
        public string LastName1 { get; private set; }

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
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
            //throw new ArgumentException("Name cannot be empty or null!");
            //AddUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Validate(Control ctl, string ctrlValue, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlValue))
            {
                ctrlErrorProvider.SetError(ctl, errorMessage);
                e.Cancel = true;
            }
            else
            {
                ctrlErrorProvider.SetError(txtFirstName, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtFirstName, txtFirstName.Text.Trim(), "Name cannot be empty", e);
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim();
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName1 = txtLastName.Text.Trim();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtLastName, txtLastName.Text.Trim(), "Name cannot be empty", e);
        }

        private void txtLastName_Changed(object sender, EventArgs e)
        {
            
        }

        private void pikerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
