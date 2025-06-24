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
        public int selectedTimetableID = -1;
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
        public void EditData()
        {
            TimetableController editController = new TimetableController();
            Timetable timetable = new Timetable { SubjectID = int.Parse(comboboxtimetablesubject.Text), RoomID = int.Parse(comboboxtimetableroom.Text), TimeSlot = textboxtimetabletimeslot.Text, TimetableID = selectedTimetableID };
            editController.EditRoomData(timetable);
        }
        public void DeleteData()
        {
            TimetableController deleteController = new TimetableController();
            Timetable deletetimetable = new Timetable { TimetableID = selectedTimetableID };
            deleteController.DeleteTimetableData(deletetimetable);
        }
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
                SubjectForm subjectForm = new SubjectForm();this.Hide();subjectForm.ShowDialog();LoadTimetabledata();
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
            else { RoomForm roomForm = new RoomForm();this.Hide();roomForm.ShowDialog();LoadTimetabledata(); }
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

        private void btntimetableadd_Click_1(object sender, EventArgs e)
        {
            Timetable timetable = new Timetable { SubjectID = selectedSubjectID, RoomID = selectedRoomID, TimeSlot = textboxtimetabletimeslot.Text };
            timetableController.AddTimetable(timetable);
            LoadTimetabledata();
        }

        private void datatimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btntimetableedit_Click(object sender, EventArgs e)
        {
            EditData();
            LoadTimetabledata();
        }

        private void btntimetabledelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadTimetabledata();
        }

        private void datatimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedrow = datatimetable.Rows[e.RowIndex].DataBoundItem as Timetable;
                if (selectedrow != null)
                {
                    selectedTimetableID = selectedrow.TimetableID;
                    
                }
            }
        }
    }
}
