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
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO Students (Name,CourseID,Address,PhoneNumber,NIC) VALUES (@name,@courseID,@address,@phonenumber,@nic)",connection);
                    command.Parameters.AddWithValue("@name",student.Name);
                    command.Parameters.AddWithValue("@courseID", student.CourseID);
                    command.Parameters.AddWithValue("@address", student.Address);
                    command.Parameters.AddWithValue("@phonenumber", student.PhoneNumber);
                    command.Parameters.AddWithValue("@nic", student.NIC);
                    command.ExecuteNonQuery();
                    MessageBox.Show("");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error" + ex.Message); }
            
        }

        public List<Student> GetStudentData()
        {
            List<Student> studentList = new List<Student>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select st.StudentID,st.Name,st.Address,st.PhoneNumber,st.NIC,cou.CourseID,cou.CourseName from Students st Left Join Courses cou on cou.CourseID=st.StudentID ", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { studentList.Add(new Student { StudentId = reader.GetInt32(0), Name = reader.GetString(1),Address=reader.GetString(2),PhoneNumber=reader.GetString(3),NIC=reader.GetString(4),
                    CourseID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                    CourseName = reader.IsDBNull(6) ? null : reader.GetString(6)
                }); }
            }

            return studentList;
        }
    }
}
