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
    internal class TimetableController
    {
        public List<Room> GetRoomList()
        {
            List<Room> subjectList = new List<Room>();
            using (var connection = DatabaseManager.GetConnection())
            {
                var cmd = new SQLiteCommand("select * from Rooms", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjectList.Add(new Room { RoomId = reader.GetInt32(0), RoomName = reader.GetString(1) });
                }
            }


            return subjectList;
        }

        public void AddTimetable(Timetable timetable)
        {
            try { using (var connection=DatabaseManager.GetConnection()) 
                {
                    SQLiteCommand cmd = new SQLiteCommand("insert into Timetables (SubjectID,TimeSlot,RoomID) values (@subjectid,@timeslot,@roomid)",connection);
                    cmd.Parameters.AddWithValue("@subjectid", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@timeslot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@roomid", timetable.RoomID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Timetable> GettimetableData()
        {
            List<Timetable> timetableList = new List<Timetable>();
            using (var connection = DatabaseManager.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("select ta.TimetableID,ta.SubjectID,ta.RoomID,ta.TimeSlot,ro.RoomName,su.SubjectName from Timetables ta Left Join Rooms ro on ro.RoomID=ta.RoomID Left join Subjects su on su.SubjectID=ta.SubjectID ", connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { timetableList.Add(new Timetable { TimetableID = reader.GetInt32(0), SubjectID= reader.GetInt32(1), RoomID= reader.GetInt32(2), TimeSlot= reader.GetString(3),
                    RoomName = reader.IsDBNull(4) ? null : reader.GetString(4),
                    SubjectName = reader.IsDBNull(5) ? null : reader.GetString(5)
                }); }
            }

            return timetableList;
        }
    }
}
