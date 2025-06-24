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
    public partial class StudentviewForm : Form
    {
        public StudentviewForm()
        {
            InitializeComponent();
            loadTimetable();
            LoadMarks();
        }

        internal void SetWelcomeText(string name)
        {
            studentviewwelcome.Text = $"Welcome {name}";
        }
        public void LoadMarks() { MarkController markController = new MarkController(); var markslist = markController.GetMarkData(); marks.DataSource = markslist;
            marks.Columns["MarkID"].Visible = false;
            marks.Columns["StudentID"].Visible = false;
            marks.Columns["ExamID"].Visible = false;
        }

        public void loadTimetable() { TimetableController timetableController = new TimetableController();List<Timetable> timetablelist = timetableController.GettimetableData();
            timetable.DataSource = timetablelist;
            timetable.Columns["TimetableID"].Visible = false;
            timetable.Columns["SubjectID"].Visible = false;
            timetable.Columns["RoomID"].Visible = false;
        }


        private void timetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
