using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void SetWelcomeText(string name, string role)
        {
            labelmainwelcome.Text = $"Welcome {name} .Your role is {role}";
            if (role == "Admin") { btnmainmarks.Visible = false; }
            else if (role == "Student") 
            {
                btnmaincourses.Visible = false; btnmainstudents.Visible = false; btnmainexams.Visible = false;
                btnmaintimetable.Visible = false;btnmainroom.Visible = false;btnmainsubjects.Visible = false;
            }
            else if (role == "Lecturer") { btnmaincourses.Visible = false; btnmainstudents.Visible = false; }
            else if (role == "Staff") { }

        }

        private void btnmaincourses_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
        }

        private void btnmainstudents_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void btnmainroom_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();
        }

        private void btnmainsubjects_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }

        private void btnmainexams_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm();
            examForm.ShowDialog();
        }

        private void btnmainmarks_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm();
            markForm.ShowDialog();
        }

        private void btnmaintimetable_Click(object sender, EventArgs e)
        {
            TimetableForm tfmForm = new TimetableForm();
            tfmForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
