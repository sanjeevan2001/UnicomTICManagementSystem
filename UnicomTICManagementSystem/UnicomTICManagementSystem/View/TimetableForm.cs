using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controller;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.View
{
    public partial class TimetableForm : Form
    {
        private readonly ExamController subjectController;
        TimetableController timetableController;
        public int selectedSubjectID = -1;
        public int selectedRoomID = -1;
        public TimetableForm()
        {
            timetableController = new TimetableController();
            subjectController = new ExamController();
            InitializeComponent();
            loadSubject();
            loadRoom();
            LoadTimetabledata();
        }


        //==============================================================
        //public void EditData()
        //{
        //    RoomController editController = new RoomController();
        //    Room room = new Room { RoomName = textboxroomroomname.Text, RoomId = int.Parse(textroomroomID.Text), RoomType = textboxroomroomtype.Text };
        //    editController.EditRoomData(room);
        //}
        //public void DeleteData()
        //{
        //    RoomController deleteController = new RoomController();
        //    Room room = new Room { RoomId = int.Parse(textroomroomID.Text) };
        //    deleteController.DeleteRoomData(room);
        //}
        public void LoadTimetabledata()
        {
            TimetableController gettimetabledata = new TimetableController();
            var timetableData = gettimetabledata.GettimetableData();
            datatimetable.DataSource = timetableData;
            datatimetable.Columns["RoomID"].Visible = false;
            datatimetable.Columns["SubjectID"].Visible = false;
        }
        //======================================================
        public void loadSubject()
        {

            var subjectList = subjectController.GetSubjectList();
            if (subjectList.Count > 0)
            {
                comboboxtimetablesubject.DataSource = subjectList;
                comboboxtimetablesubject.DisplayMember = "SubjectName";
                comboboxtimetablesubject.ValueMember = "SubjectID";
            }
            else
            {
                labeltimetableerror.Text = "No subject found. Please add a subject first.";
            }
        }
        public void loadRoom() 
        {
            var roomList = timetableController.GetRoomList();
            if (roomList.Count > 0)
            {
                comboboxtimetableroom.DataSource = roomList;
                comboboxtimetableroom.DisplayMember = "RoomName";
                comboboxtimetableroom.ValueMember = "RoomId";
            }
            else { labeltimetableerror.Text = "No room found. Please add a room first."; }
        }



        private void comboboxtimetablesubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubjectID = comboboxtimetablesubject.SelectedIndex+1;
        }

        private void comboboxtimetableroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoomID = comboboxtimetableroom.SelectedIndex+1;
        }

        private void btntimetableadd_Click(object sender, EventArgs e)
        {
            Timetable timetable = new Timetable {SubjectID = selectedSubjectID, RoomID=selectedRoomID,TimeSlot=textboxtimetabletimeslot.Text };
            timetableController.AddTimetable(timetable);
            LoadTimetabledata();
        }
    }
}
