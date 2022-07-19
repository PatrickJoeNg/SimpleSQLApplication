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
        public static IDataConnector Connection { get; private set; }

        public static string connectionString = "datasource=localhost;port=3306;username=pat;password=123;database=peopleaccounts";
        
        public static void InitConnections()
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }
    }
}
