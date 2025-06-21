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
    public partial class ExamForm : Form
    {
        private readonly ExamController examcontroller;
        public int selectedSubjectId = -1;
        public ExamForm()
        {
            examcontroller = new ExamController();
            InitializeComponent();
            loadsubject();
            Loadexamdata();
        }
        //======================
        public void EditData()
        {
            ExamController editController = new ExamController();
            
            Exam editexam = new Exam { 
                ExamName = textboxexamexamname.Text, 
                ExamID = int.Parse(textboxexamexamid.Text), 
                SubjectName = comboboxexamsubject.Text, 
                SubjectID = int.Parse(textboxexamsubjectid.Text) };
            editController.EditExamData(editexam);
            
                
        }
        //public void DeleteData()
        //{
        //    RoomController deleteController = new RoomController();
        //    Room room = new Room { RoomId = int.Parse(textroomroomID.Text) };
        //    deleteController.DeleteRoomData(room);
        //}
        public void Loadexamdata()
        {
            ExamController getexamdata = new ExamController();
            var examData = getexamdata.GetExamData();
            dataexamview.DataSource = examData;
            dataexamview.Columns["ExamID"].Visible = false;
            dataexamview.Columns["SubjectID"].Visible = false;

        }


        //==================================



        public void loadsubject() 
        {
            var subjectList = examcontroller.GetSubjectList();
            if (subjectList.Count > 0)
            {
                comboboxexamsubject.DataSource = subjectList;
                comboboxexamsubject.DisplayMember = "SubjectName";
                comboboxexamsubject.ValueMember = "SubjectID";
            }
            else
            {
                labelexamerror.Text = "No courses found. Please add a course first.";
            }
        }

        private void btnexamadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxexamexamname.Text))
            {
                MessageBox.Show("Please enter exam name.");
                return;
            }
            if (selectedSubjectId>0) 
            {
                Exam exam = new Exam { ExamName = textboxexamexamname.Text, SubjectID = selectedSubjectId };
                examcontroller.Addexam(exam);
                
            }
            
        }

        private void comboboxexamsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubjectId = comboboxexamsubject.SelectedIndex+1;
            textboxexamsubjectid.Text = selectedSubjectId.ToString(); // optional

        }

        private void dataexamview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedrow = dataexamview.Rows[e.RowIndex].DataBoundItem as Exam;
               
                    textboxexamexamid.Text = selectedrow.ExamID.ToString();
                    textboxexamexamname.Text = selectedrow.ExamName;
                    textboxexamsubjectid.Text = selectedrow.SubjectID.ToString();
                    comboboxexamsubject.Text = selectedrow.SubjectName;


                    // Select the matching subject in the ComboBox
                   // comboboxexamsubject.SelectedValue = selectedrow.SubjectID;
                
            }
        }

        private void btnexamedit_Click(object sender, EventArgs e)
        {
            EditData();
            Loadexamdata();
        }

        private void labelexamexamid_Click(object sender, EventArgs e)
        {

        }
    }
}
