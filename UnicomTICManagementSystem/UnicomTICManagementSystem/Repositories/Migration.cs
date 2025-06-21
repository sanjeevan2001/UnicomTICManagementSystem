using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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
                CourseName TEXT NOT NULL);
            CREATE TABLE IF NOT EXISTS Subjects(SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                SubjectName TEXT NOT NULL, CourseID INTEGER, FOREIGN KEY (CourseID) REFERENCES Courses(CourseID));
            CREATE TABLE IF NOT EXISTS Students(StudentID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL,
                CourseID INTEGER NOT NULL, FOREIGN KEY (CourseID) REFERENCES Courses(CourseID));
            CREATE TABLE IF NOT EXISTS Exams(ExamID INTEGER PRIMARY KEY AUTOINCREMENT,ExamName TEXT NOT NULL,
                SubjectID INTEGER NOT NULL, FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID));
            CREATE TABLE IF NOT EXISTS Marks(MarkID INTEGER PRIMARY KEY AUTOINCREMENT,StudentID INTEGER NOT NULL,ExamID INTEGER NOT NULL,Score INTEGER NOT NULL,
                FOREIGN KEY (StudentID) REFERENCES Students(StudentID), FOREIGN KEY (ExamID) REFERENCES Exams(ExamID));
            CREATE TABLE IF NOT EXISTS Rooms(RoomID INTEGER PRIMARY KEY AUTOINCREMENT,RoomName TEXT NOT NULL,
                RoomType TEXT NOT NULL);
            CREATE TABLE IF NOT EXISTS Timetables(TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,SubjectID INTEGER NOT NULL,
                TimeSlot TEXT NOT NULL,RoomID INTEGER NOT NULL,FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID));
            ";


            using (var conn = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(tablesQuery, conn);
                cmd.ExecuteNonQuery();

                // Insert a default admin user if none exists
                var checkAdminCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Role = 'Admin';", conn);
                long adminCount = (long)checkAdminCmd.ExecuteScalar();
                if (adminCount == 0)
                {
                    var insertAdminCmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES ('admin', 'admin123', 'Admin');", conn);
                    insertAdminCmd.ExecuteNonQuery();
                }
            }

        }
    }
}
