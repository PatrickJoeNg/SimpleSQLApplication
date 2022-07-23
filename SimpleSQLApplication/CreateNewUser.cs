using PeopleAccountsLibrary;
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
    public partial class CreateNewUser : Form
    {
        List<CompanyModel> companies = GlobalConfig.Connection.GetAllCompanies();
        public CreateNewUser()
        {
            InitializeComponent();
            WireUpCompanyDropDown();
        }

        private void WireUpCompanyDropDown()
        {
            companyNameDropDown.DataSource = companies;
            companyNameDropDown.DisplayMember = "CompanyName";
            companyNameDropDown.SelectedItem = null;
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.PhoneNumber = phoneValue.Text;

                CompanyModel c = (CompanyModel)companyNameDropDown.SelectedItem;
                if (c == null)
                {
                    p.CompanyId = null;
                }
                else
                {
                    
                    p.CompanyId = c.Id;
                }
                
                GlobalConfig.Connection.CreatePerson(p);

                p.FirstName = "";
                p.LastName = "";
                p.EmailAddress = "";
                p.PhoneNumber = "";

                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid form, please check and try again.");
            }
        }
        
        private bool ValidateForm()
        {
            bool output = true;
            if (firstNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (emailValue.Text.Length == 0)
            {
                output = false;
            }
            if (phoneValue.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }
    }
}
