using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controller;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.View
{
    public partial class StudentForm : Form
    {
        private readonly StudentController _studentController;
        private readonly CourseController _courseController;
        private readonly LoginController _loginController;
        private int selectedStudentId = -1;
        public StudentForm()
        {
            _studentController = new StudentController();
            _courseController = new CourseController();
            _loginController = new LoginController();
            InitializeComponent();
            comboboxload();
            LoadStudentdata();
        }



        //=============================================================
        //public void EditStudentData()
        //{
        //    StudentController editStudentController = new StudentController();
        //    Student room = new Student { RoomName = textboxroomroomname.Text, RoomId = int.Parse(textroomroomID.Text), RoomType = textboxroomroomtype.Text };
        //    editController.EditRoomData(room);
        //}
        //public void DeleteData()
        //{
        //    RoomController deleteController = new RoomController();
        //    Room room = new Room { RoomId = int.Parse(textroomroomID.Text) };
        //    deleteController.DeleteRoomData(room);
        //}
        public void LoadStudentdata()
        {
            StudentController getstudentdata = new StudentController();
            var studentData = getstudentdata.GetStudentData();
            datastudent.DataSource = studentData;
            datastudent.Columns["CourseID"].Visible = false;
        }
        //===================================================================
        public void comboboxload()
        {
            var courseList = _courseController.getCourseList();
            if (courseList .Count > 0) {
                comboboxstudentcourse.DataSource = courseList;
                comboboxstudentcourse.DisplayMember = "CourseName";
                comboboxstudentcourse.ValueMember = "CourseID";
            }
            else 
            {
                labelstudenterror.Text = "No courses found. Please add a course first.";
            }
        }

        private void btnstudentadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxstudentname.Text))
            {
                MessageBox.Show("Please enter student name.");
                return;
            }
            if (selectedStudentId > 0)
            {
                //labelstudenterror.Text = comboboxstudentcourse.SelectedValue.ToString(); 
                Student student = new Student { CourseID = selectedStudentId ,Name=textboxstudentname.Text,};
                User user = new User { UserName=textboxstudentname.Text,Password=textboxstudentpassword.Text,Role="Student" };
                _studentController.AddStudent(student);
                _loginController.CreatePassword(user);
                selectedStudentId = -1;
            }
            LoadStudentdata();
            //not work because starting select option
            // else { MessageBox.Show("rwsg"); }
            
        }

        private void comboboxstudentcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudentId = comboboxstudentcourse.SelectedIndex+1;
            labelstudenterror.Text = comboboxstudentcourse.SelectedValue.ToString();
        }

        private void textboxstudentname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
