using System;
using MySql.Data.MySqlClient;
using ToDoListApp;

namespace WorldDataApp.Models
{
    public class DB
    {
        public static MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            return conn;
        }
    }
}
