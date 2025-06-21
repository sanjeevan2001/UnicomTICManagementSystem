using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal class DatabaseManager
    {
        private static string stringConnection = "Data Source=unicomtic.db;Version=3";
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(stringConnection);
            conn.Open();
            return conn;
        }
    }
}
