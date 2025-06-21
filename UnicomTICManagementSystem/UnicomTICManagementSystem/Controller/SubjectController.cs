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
    internal class SubjectController
    {
        public void AddSubject(Subject subject)
        {
            try 
            {
                using (var connection = DatabaseManager.GetConnection()) 
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO Subjects (SubjectName,CourseID) VALUES (@subjectname,@courseID)",connection);
                    command.Parameters.AddWithValue("@subjectname",subject.SubjectName);
                    command.Parameters.AddWithValue("@courseID",subject.CourseID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Subject> GetsubjectData()
        {
            List<Subject> subjectList = new List<Subject>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select su.SubjectID,su.SubjectName,cou.CourseID,cou.CourseName from Subjects su Left Join Courses cou on cou.CourseID=su.CourseID ", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjectList.Add(new Subject
                    {
                        SubjectID = reader.GetInt32(0),
                        SubjectName = reader.GetString(1),
                        CourseID = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                        CourseName = reader.IsDBNull(3) ? null : reader.GetString(3)
                    });
                }
            }

            return subjectList;
        }
    }
}
