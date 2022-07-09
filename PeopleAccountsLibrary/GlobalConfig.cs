using MySql.Data.MySqlClient;
using PeopleAccountsLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccountsLibrary
{
    public class GlobalConfig
    {
        public static IDataConnector DataConnection { get; private set; }
        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static string ServerName = "127.0.01";
        public static string DbName = "peopleaccounts";
        public static string DbUser = "pat";
        public static string DbPass = "123";
        public MySqlConnection MySqlConnector { get; set; }

        private static GlobalConfig _instance = null;
        public static GlobalConfig Instance()
        {
            _instance = new GlobalConfig();

            return _instance;
        }
        public bool IsConnect()
        {
            if (MySqlConnector == null)
            {
                if (string.IsNullOrEmpty(DatabaseName))
                {
                    return false;
                }
                string cnnString = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                MySqlConnector = new MySqlConnection(cnnString);
                MySqlConnector.Open();
            }
            return true;
        }

        public void CloseConnector()
        {
            MySqlConnector.Close();
        }
        public static void InitializeDataConnection()
        {
            SqlConnector sql = new SqlConnector();

            DataConnection = sql;
        }
    }
}
