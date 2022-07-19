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
           throw new NotImplementedException();
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
            }
            dbConnection.Close();
            return models;
        }
    }
}
