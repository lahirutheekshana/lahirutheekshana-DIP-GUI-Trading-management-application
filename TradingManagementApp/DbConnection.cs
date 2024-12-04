
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TradingManagementApp
{
    internal class DbConnection
    {
        public static MySqlConnection connectDB()
        {
            String connection_string = "server=localhost;uid=root;database=trading_db";
            MySqlConnection conn = new MySqlConnection(connection_string);
             
            return conn;
        }
    }
}



