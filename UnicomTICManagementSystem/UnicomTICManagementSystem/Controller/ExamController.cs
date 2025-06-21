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
    internal class ExamController
    {
        public List<Subject> GetSubjectList()
        {
            List<Subject> subjectList = new List<Subject>();
            using (var connection = DatabaseManager.GetConnection())
            {
                var cmd = new SQLiteCommand("select * from Subjects", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjectList.Add(new Subject { SubjectID = reader.GetInt32(0), SubjectName = reader.GetString(1) });
                }
            }
            return subjectList;
        }
        public void Addexam(Exam exam)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO Exams (ExamName,SubjectID) VALUES (@examname,@subjectID)", connection);
                    command.Parameters.AddWithValue("@examname", exam.ExamName);
                    command.Parameters.AddWithValue("@subjectID", exam.SubjectID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("successfully.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Student> GetStudentList()
        {
            List<Student> studentList = new List<Student>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Students", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentList.Add(new Student { Name = reader.GetString(1), StudentId = reader.GetInt32(0) });
                }
            }
            return studentList;
        }
        //==============================================
        public List<Exam> GetExamData()
        {
            List<Exam> examList = new List<Exam>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select ex.ExamID, ex.ExamName, sub.SubjectID as SubjectID,sub.SubjectName as SubjectName from Exams ex Left join Subjects sub on sub.SubjectID = ex.SubjectID", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { examList.Add(new Exam { ExamID = reader.GetInt32(0), ExamName = reader.GetString(1),
                    SubjectID = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                    SubjectName = reader.IsDBNull(3) ? null : reader.GetString(3)
                }); }
            }
            return examList;
        }

        public void EditExamData(Exam exam)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(@"UPDATE Subjects SET SubjectName = @subjectname WHERE SubjectID = @subjectID;update Exams SET ExamName = @examname where ExamID = @examID", connection);
                    cmd.Parameters.AddWithValue("@examID", exam.ExamID);
                    cmd.Parameters.AddWithValue("@examname", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectID", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@subjectname", exam.SubjectName);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edit successfully");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void DeleteExamData(Room room1)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand("Delete from Rooms WHERE RoomID = @roomID", connection);
                    cmd.Parameters.AddWithValue("@roomID", room1.RoomId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successfully");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        
    }
}
