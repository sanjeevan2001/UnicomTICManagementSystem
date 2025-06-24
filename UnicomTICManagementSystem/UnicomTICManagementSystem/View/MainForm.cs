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
            if (role == "Admin") {  }
            else if (role == "Lecturer") { btnmaincourses.Visible = false; btnmainstudents.Visible = false; staffandlecturer.Visible = false; }
            else if (role == "Staff") { staffandlecturer.Visible = false; }

        }

        private void btnmaincourses_Click(object sender, EventArgs e)
        {
            CourseForm courseform = new CourseForm();
            courseform.ShowDialog();
        }

        private void btnmainstudents_Click(object sender, EventArgs e)
        {
            StudentForm studentform = new StudentForm();
            studentform.ShowDialog();
        }

        private void btnmainroom_Click(object sender, EventArgs e)
        {
            RoomForm roomform = new RoomForm();
            roomform.ShowDialog();
        }

        private void btnmainsubjects_Click(object sender, EventArgs e)
        {
            SubjectForm subjectform = new SubjectForm();
            subjectform.ShowDialog();
        }

        private void btnmainexams_Click(object sender, EventArgs e)
        {
            ExamForm examform = new ExamForm();
            examform.ShowDialog();
        }

        private void btnmainmarks_Click(object sender, EventArgs e)
        {
            MarkForm markform = new MarkForm();
            markform.ShowDialog();
        }

        private void btnmaintimetable_Click(object sender, EventArgs e)
        {
            TimetableForm tfmform = new TimetableForm();
            tfmform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentviewForm studentview = new StudentviewForm();
            this.Hide();
            studentview.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Staff_and_Lecturer staff_And_Lecturer = new Staff_and_Lecturer();
            staff_And_Lecturer.ShowDialog();
        }

        private void btnmainlogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void labelmainwelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
