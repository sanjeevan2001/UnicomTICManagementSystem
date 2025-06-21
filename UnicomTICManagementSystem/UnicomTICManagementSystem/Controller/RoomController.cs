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
    internal class RoomController
    {
        public void AddRoom(Room room)
        {
            try { 

                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand command = new SQLiteCommand("insert into Rooms (RoomName,RoomType) values (@roomname,@roomtype)",connection);
                    command.Parameters.AddWithValue("@roomname",room.RoomName);
                    command.Parameters.AddWithValue("@roomtype", room.RoomType);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully.");
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        public object GetRoomData()
        {
            List<Room> roomList = new List<Room>();
            using (var connection = DatabaseManager.GetConnection()) { SQLiteCommand cmd = new SQLiteCommand("select * from Rooms",connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { roomList.Add(new Room { RoomId=reader.GetInt32(0),RoomName=reader.GetString(1),RoomType=reader.GetString(2)}); }
            }
            return roomList;
        }

        public void EditRoomData(Room room1)
        {
            try {
                 using (var connection = DatabaseManager.GetConnection()) 
                { 
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE Rooms SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomID = @roomID", connection);
                    cmd.Parameters.AddWithValue("@RoomName", room1.RoomName);
                    cmd.Parameters.AddWithValue("@RoomType", room1.RoomType);
                    cmd.Parameters.AddWithValue("@roomID", room1.RoomId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edit successfully");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void DeleteRoomData(Room room1)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand("Delete from Rooms WHERE RoomID = @roomID", connection);
                    cmd.Parameters.AddWithValue("@roomID", room1.RoomId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edit successfully");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



    }
}
