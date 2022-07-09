using MySql.Data.MySqlClient;
using PeopleAccountsLibrary.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PeopleAccountsLibrary.Data
{
    public class SqlConnector : IDataConnector
    {

        // Method to insert a person into database
        public void CreatePerson(PersonModel model)
        {
            var dbCon = GlobalConfig.Instance();
            dbCon.Server = GlobalConfig.ServerName;
            dbCon.DatabaseName = GlobalConfig.DbName;
            dbCon.UserName = GlobalConfig.DbUser;
            dbCon.Password = GlobalConfig.DbPass;

            // string query = @"INSERT INTO `people`(`FirstName`, `LastName`, `EmailAddress`, `PhoneNumber`) VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber)";

            if (dbCon.IsConnect())
            {
                using (IDbConnection connection = new MySqlConnection())
                {
                    var p = new DynamicParameters();
                    p.Add("@FirstName", model.FirstName);
                    p.Add("@LastName", model.LastName);
                    p.Add("@EmailAddress", model.EmailAddress);
                    p.Add("@PhoneNumber", model.PhoneNumber);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("sp_PersonInsert", p, commandType: CommandType.StoredProcedure);

                    model.Id = p.Get<int>("@id");
                }
                dbCon.CloseConnector();
            }

        }

        public List<PersonModel> GetAllUsers()
        {
            List<PersonModel> output;

            var dbCon = GlobalConfig.Instance();
            dbCon.Server = GlobalConfig.ServerName;
            dbCon.DatabaseName = GlobalConfig.DbName;
            dbCon.UserName = GlobalConfig.DbUser;
            dbCon.Password = GlobalConfig.DbPass;
            if (dbCon.IsConnect())
            {
                using (IDbConnection connection = new MySqlConnection(dbCon.MySqlConnector.ToString()))
                {
                    output = connection.Query<PersonModel>("sp_GetAllPeople").ToList();
                }
                return output;
            }
            return new List<PersonModel>();
        }
    }
}
