using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controller
{
    internal class CourseController
    {
     
        public void addCourse(Course course)
        {
            try
            {
                if (course == null || string.IsNullOrWhiteSpace(course.CourseName))
                {
                    MessageBox.Show("Invalid course data.");
                }
                using (var conn = DatabaseManager.GetConnection())
                {
                    string query = "INSERT INTO Courses (CourseName) VALUES (@course)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@course", course.CourseName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show( "Course added successfully!"); 
                }
            }
            catch (Exception ex){MessageBox.Show("Error: " + ex.Message);  }
        }

        public List<Course> getCourseList() 
        {
            List<Course> list = new List<Course>();
            using (var connection = DatabaseManager.GetConnection()) 
            {
                var cmd = new SQLiteCommand("select * from Courses", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    list.Add(new Course { CourseID = reader.GetInt32(0),CourseName=reader.GetString(1) });
                }
            }
            return list;
        }

        internal void DeleteCourseData(Course course)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand("Delete from Courses WHERE CourseID = @courseID", connection);
                    cmd.Parameters.AddWithValue("@roomID", course.CourseID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successfully");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        internal void EditCourseData(Course course)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE Rooms SET RoomName = @coursename WHERE RoomID = @courseID", connection);
                    cmd.Parameters.AddWithValue("@coursename", course.CourseName);
                    cmd.Parameters.AddWithValue("@courseID", course.CourseID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edit successfully");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        internal object GetCourseData()
        {
            List<Course> courseList = new List<Course>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Courses", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { courseList.Add(new Course { CourseID = reader.GetInt32(0), CourseName = reader.GetString(1) }); }
            }
            return courseList;
        }

        public List<Lecturer> getlecturerList()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand("select LecturerID,LecturerName from Lecturers", connection);
                    var reader = cmd.ExecuteReader();
                    lecturers.Add(new Lecturer { LecturerID = reader.GetInt32(0), LecturerName = reader.GetString(1) }); MessageBox.Show("...");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            return lecturers;
        }
    }
}
