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
    internal class StudentController
    {
        public void AddStudent(Student student)
        {
            try {

                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO Students (Name,CourseID) VALUES (@name,@courseID)",connection);
                    command.Parameters.AddWithValue("@name",student.Name);
                    command.Parameters.AddWithValue("@courseID", student.CourseID);
                    command.ExecuteNonQuery();
                   // MessageBox.Show("");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error" + ex.Message); }
            
        }

        public List<Student> GetStudentData()
        {
            List<Student> studentList = new List<Student>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select st.StudentID,st.Name,cou.CourseID,cou.CourseName from Students st Left Join Courses cou on cou.CourseID=st.StudentID ", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { studentList.Add(new Student { StudentId = reader.GetInt32(0), Name = reader.GetString(1),
                    CourseID = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                    CourseName = reader.IsDBNull(3) ? null : reader.GetString(3)
                }); }
            }

            return studentList;
        }
    }
}
