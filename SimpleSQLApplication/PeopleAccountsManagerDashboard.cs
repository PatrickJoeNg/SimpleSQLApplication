using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleAccountsLibrary;
using PeopleAccountsLibrary.Models;

namespace SimpleSQLApplication
{
    public partial class PeopleAccountsManagerDashboard : Form
    {
        List<PersonModel> availableUsers = GlobalConfig.DataConnection.GetAllUsers();
        public PeopleAccountsManagerDashboard()
        {
            InitializeComponent();
            WireUpDropDown();
        }

        private void WireUpDropDown()
        {
            userNameDropDown.DataSource = availableUsers;
            userNameDropDown.DisplayMember = "FullName";
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            // Opens a new form for creating a user
            CreateNewUser frm = new CreateNewUser();
            frm.Show();
        }

        private void viewUserButton_Click(object sender, EventArgs e)
        {
            ViewUserForm frm = new ViewUserForm();
            frm.Show();
        }
    }
}
