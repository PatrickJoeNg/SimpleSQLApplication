using PeopleAccountsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSQLApplication
{
    public partial class ViewUserForm : Form
    {
        private PersonModel person;

        public ViewUserForm(PersonModel personModel)
        {
            InitializeComponent();
            person = personModel;

            LoadFormData();
        }

        private void LoadFormData()
        {
            userNameLabel.Text = person.FullName;
            firstNameLabel.Text = person.FirstName;
            lastNameLabel.Text = person.LastName;
            emailLabel.Text = person.EmailAddress;
            phoneLabel.Text = person.PhoneNumber;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TODO - Create function for form to display data after accessing.

    }
}
