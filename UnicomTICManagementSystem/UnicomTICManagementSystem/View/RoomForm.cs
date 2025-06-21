using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controller;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.View
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            LoadRoomdata();
        }

        private void btnroomadd_Click(object sender, EventArgs e)
        {
            Room room = new Room { RoomName = textboxroomroomname.Text,RoomType=textboxroomroomtype.Text };
            RoomController roomController = new RoomController();
            roomController.AddRoom(room);
            LoadRoomdata();

        }
        public void EditData()
        {
            RoomController editController = new RoomController();
            Room room = new Room { RoomName = textboxroomroomname.Text, RoomId = int.Parse(textroomroomID.Text), RoomType = textboxroomroomtype.Text };
            editController.EditRoomData(room);
        }
        public void DeleteData() {
            RoomController deleteController = new RoomController();
            Room room = new Room { RoomId = int.Parse(textroomroomID.Text)};
            deleteController.DeleteRoomData(room);
        }
        public void LoadRoomdata() 
        {
            RoomController getroomdata = new RoomController();
            var roomData = getroomdata.GetRoomData();
            dataroom.DataSource = roomData;
            dataroom.Columns["RoomID"].Visible = false;
        }

        private void btnroomedit_Click(object sender, EventArgs e)
        {
            EditData();
            LoadRoomdata();
        }

        private void dataroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedrow = dataroom.Rows[e.RowIndex].DataBoundItem as Room;
                if (selectedrow != null)
                {
                    textroomroomID.Text = selectedrow.RoomId.ToString();
                    textboxroomroomname.Text = selectedrow.RoomName;
                    textboxroomroomtype.Text = selectedrow.RoomType;
                }
            }
        }















        private void dataroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectedrow = dataroom.SelectedRows[0].DataBoundItem as Room;
            //textroomroomID.Text = selectedrow.RoomId.ToString();
            //textboxroomroomname.Text = selectedrow.RoomName.ToString();
            //textbocroomroomtype.Text = selectedrow.RoomType.ToString();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void btnroomdelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadRoomdata();
        }
    }
}
