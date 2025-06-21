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
    internal class MarkController
    {
        public List<Exam> GetExamList()
        {
            List<Exam> examList = new List<Exam>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from Exams", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    examList.Add(new Exam { ExamName = reader.GetString(1), ExamID = reader.GetInt32(0) });

                }

            }
            return examList;
        }

        public void Addmark(Mark mark)
        {
            if (mark.Score >= 0 && mark.Score <= 100) 
            {
                try
                {
                    using (var connection = DatabaseManager.GetConnection())
                    {
                        SQLiteCommand command = new SQLiteCommand("insert into Marks (StudentID,ExamID,Score) values (@studentID,@examID,@score)", connection);
                        command.Parameters.AddWithValue("@studentID", mark.StudentID);
                        command.Parameters.AddWithValue("@examID", mark.ExamID);
                        command.Parameters.AddWithValue("@score", mark.Score);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Enter the correct score.");return; }
        }

        internal List<Mark> GetMarkData()
        {
            List<Mark> markList = new List<Mark>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select ma.MarkID,ma.Score,st.StudentID,st.Name,ex.ExamID,ex.ExamName from Marks ma Left Join Students st on ma.StudentID=st.StudentID Left join Exams ex on ex.ExamID=ma.ExamID ", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { markList.Add(new Mark { MarkID = reader.GetInt32(0), Score = reader.GetInt32(1), StudentID = reader.GetInt32(2),StudentName=reader.GetString(3),ExamID=reader.GetInt32(4),ExamName=reader.GetString(5) }); }
            }
            
            return markList;

        }
    }
}
