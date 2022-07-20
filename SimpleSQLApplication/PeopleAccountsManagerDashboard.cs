﻿using System;
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
        
        BindingSource peopleBindingSource = new BindingSource();

        public PeopleAccountsManagerDashboard()
        {
            InitializeComponent();
            WireUpDropDown();
        }
        private void CreateSampleData()
        {
            //PersonModel p = new PersonModel
            //{
            //    Id = 1,
            //    FirstName = "Patrick",
            //    LastName = "Ng",
            //    EmailAddress = "png@gmail.com",
            //    PhoneNumber = "333-444-1234"
            //};
            //PersonModel p2 = new PersonModel
            //{
            //    Id = 1,
            //    FirstName = "John",
            //    LastName = "Smith",
            //    EmailAddress = "johnSmith@gmail.com",
            //    PhoneNumber = "444-232-1209"
            //};
            //people.Add(p);
            //people.Add(p2);

            
            //userNameDropDown.DisplayMember = "FullName";
        }
        private void WireUpDropDown()
        {
            List<PersonModel> people = GlobalConfig.Connection.GetAllUsers();

            peopleBindingSource.DataSource = people;
            userNameDropDown.DataSource = peopleBindingSource;
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
            PersonModel pm = (PersonModel)userNameDropDown.SelectedItem;

            ViewUserForm frm = new ViewUserForm(pm);
            frm.Show();
        }
    }
}
