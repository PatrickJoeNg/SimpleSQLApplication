using MySql.Data.MySqlClient;
using PeopleAccountsLibrary.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccountsLibrary.Data
{
    public class SqlConnector : IDataConnector
    {
        public void CreatePerson(PersonModel model)
        {
           MySqlConnection dbConnection = new MySqlConnection(GlobalConfig.connectionString);
            dbConnection.Open();

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "INSERT INTO PEOPLE(FirstName,LastName,EmailAddress,PhoneNumber,CompanyId) VALUES(@firstName, @lastName, @emailAddress, @phoneNumber, @companyId)";

            command.Parameters.AddWithValue("@firstName", model.FirstName);
            command.Parameters.AddWithValue("@lastName", model.LastName);
            command.Parameters.AddWithValue("@emailAddress", model.EmailAddress);
            command.Parameters.AddWithValue("@phoneNumber", model.PhoneNumber);
            command.Parameters.AddWithValue("@companyId", model.CompanyId);
            command.Connection = dbConnection;

            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        public List<PersonModel> GetAllUsers()
        {
            // new list
            List<PersonModel> models = new List<PersonModel>();

            // connect to the sql server
            MySqlConnection dbConnection = new MySqlConnection(GlobalConfig.connectionString);
            dbConnection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM PEOPLE", dbConnection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.IsDBNull(5))
                    {
                        PersonModel p = new PersonModel
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            EmailAddress = reader.GetString(3),
                            PhoneNumber = reader.GetString(4)
                        };
                        models.Add(p);
                    }
                    else if (!reader.IsDBNull(5))
                    {
                        PersonModel p = new PersonModel
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            EmailAddress = reader.GetString(3),
                            PhoneNumber = reader.GetString(4),
                            CompanyId = reader.GetInt32(5)
                        };
                        models.Add(p);
                    } 
                }
            }
            dbConnection.Close();
            return models;
        }

        public List<CompanyModel> GetAllCompanies()
        {
            // new list
            List<CompanyModel> models = new List<CompanyModel>();

            // Connect to the sql server
            MySqlConnection dbConnection = new MySqlConnection(GlobalConfig.connectionString);
            dbConnection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM COMPANIES", dbConnection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CompanyModel c = new CompanyModel
                    {
                        Id=reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        StreetAddress = reader.GetString(2),
                        City = reader.GetString(3),
                        PostalCode = reader.GetString(4),
                        PhoneNumber = reader.GetString(5)
                    };
                    models.Add(c);
                }
            }
            dbConnection.Close();
            return models;
        }
    }
}
