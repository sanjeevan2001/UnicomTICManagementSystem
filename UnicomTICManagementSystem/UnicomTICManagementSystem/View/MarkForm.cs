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
    public partial class MarkForm : Form
    {
        private readonly ExamController examcontroller;
        private readonly MarkController markcontroller;
        public int selectedStudentId = -1;
        public int selectedexamId = -1;
        public MarkForm()
        {
            markcontroller = new MarkController();
            examcontroller = new ExamController();
            InitializeComponent();
            loadstudent();
            loadExam();
            LoadRoomdata();
        }

        //===========================================================
        //public void EditData()
        //{
        //    MarkController editmarkController = new MarkController();
        //    Room room = new Room { RoomName = textboxroomroomname.Text, RoomId = int.Parse(textroomroomID.Text), RoomType = textboxroomroomtype.Text };
        //    editController.EditRoomData(room);
        //}
        //public void DeleteData()
        //{
        //    RoomController deleteController = new RoomController();
        //    Room room = new Room { RoomId = int.Parse(textroomroomID.Text) };
        //    deleteController.DeleteRoomData(room);
        //}
        public void LoadRoomdata()
        {
            MarkController getMarkdata = new MarkController();
            var markData = getMarkdata.GetMarkData();
            datamark.DataSource = markData;
            datamark.Columns["StudentID"].Visible = false;
            datamark.Columns["ExamID"].Visible = false;
        }
        //=============================================================



        private void comboboxmarkstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudentId = comboboxmarkstudent.SelectedIndex+1;
        }

        private void comboboxmarkexam_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedexamId= comboboxmarkexam.SelectedIndex+1;
        }

        public void loadExam()
        {
            try
            {

                var markList = markcontroller.GetExamList();
                if (markList.Count > 0)
                {
                    comboboxmarkexam.DataSource = markList;
                    comboboxmarkexam.DisplayMember = "ExamName";
                    comboboxmarkexam.ValueMember = "ExamID";
                }
                else
                {
                    labelmarkerror.Text = "No courses found. Please add a course first.";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void loadstudent()
        {
            try {

                var studentList = examcontroller.GetStudentList();
                if (studentList.Count > 0)
                {
                    comboboxmarkstudent.DataSource = studentList;
                    comboboxmarkstudent.DisplayMember = "Name";
                    comboboxmarkstudent.ValueMember = "StudentID";
                }
                else
                {
                    labelmarkerror.Text = "No courses found. Please add a course first.";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void btnmarkadd_Click(object sender, EventArgs e)
        {
            int score;
            if (int.TryParse(textboxmarkscore.Text, out score))
            { Mark mark = new Mark { StudentID = selectedStudentId, ExamID = selectedexamId, Score = score }; markcontroller.Addmark(mark); }
            
        }
    }
}
