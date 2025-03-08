using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Database
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;

        public Database()
        {
            string connString = "server=localhost;database=GestionAbsences;user=root;password=;";
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
        }

        public MySql.Data.MySqlClient.MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}
