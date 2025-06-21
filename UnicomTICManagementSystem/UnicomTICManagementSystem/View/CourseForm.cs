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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            LoadCoursedata();
        }
        public void EditCourseData()
        {
            CourseController editcourseController = new CourseController();
            Course course = new Course { CourseName = textboxcoursename.Text, CourseID = int.Parse(textboxcoursecourseID.Text)};
            editcourseController.EditCourseData(course);
        }
        public void DeleteCourseData()
        {
            CourseController deletecourseController = new CourseController();
            Course Dcourse = new Course { CourseID = int.Parse(textboxcoursecourseID.Text) };
            deletecourseController.DeleteCourseData(Dcourse);
        }
        public void LoadCoursedata()
        {
            CourseController getcoursedata = new CourseController();
            var courseData = getcoursedata.GetCourseData();
            datacourse.DataSource = courseData;
            datacourse.Columns["CourseID"].Visible = false;
        }

        private void btncourseadd_Click(object sender, EventArgs e)
        {
            Course course = new Course { CourseName = textboxcoursename.Text.Trim() };
            CourseController courseController = new CourseController();
            bool addresult = courseController.addCourse(course);
            if (!addresult) { labelcourseerror.Text = "Courses couldn't be added."; }
            else { labelcourseerror.Text = "Course added successfully!"; }
            LoadCoursedata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedrow = datacourse.Rows[e.RowIndex].DataBoundItem as Course;
                if (selectedrow != null)
                {
                    textboxcoursecourseID.Text = selectedrow.CourseID.ToString();
                    textboxcoursename.Text = selectedrow.CourseName;
                   
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncourseedit_Click(object sender, EventArgs e)
        {
            LoadCoursedata();
            EditCourseData();
        }

        private void btncoursedelete_Click(object sender, EventArgs e)
        {
            LoadCoursedata();
            DeleteCourseData();
        }
    }
}
