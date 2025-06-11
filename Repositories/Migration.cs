using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal class Migration
    {
        public static void CreateTables() 
        {
            string tablesQuery = @"
            CREATE TABLE IF NOT EXISTS Users(UserID INTEGER PRIMARY KEY AUTOINCREMENT,
Username TEXT NOT NULL, Password TEXT NOT NULL, Role TEXT NOT NULL);
            CREATE TABLE IF NOT EXISTS Courses(CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
CourseName TEXT NOT NULL)/*;*/
            /*create table IF NOT EXISTS Subject();*/



            ";


            using (var conn = DatabaseManager.GetConnection()) 
            {
                SQLiteCommand cmd = new SQLiteCommand(tablesQuery,conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
