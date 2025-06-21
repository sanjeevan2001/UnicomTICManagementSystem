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
    public partial class SubjectForm : Form
    {
        private readonly CourseController _courseController;
        
        private int selectedCourseId = -1;

        public SubjectForm()
        {
            _courseController = new CourseController();
            InitializeComponent();
            comboboxload();
            LoadSubjectdata();
        }
//===========================================
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
        public void LoadSubjectdata()
        {
            SubjectController getsubjectdata = new SubjectController();
            var subjectData = getsubjectdata.GetsubjectData();
            datasubject.DataSource = subjectData;
            datasubject.Columns["CourseID"].Visible = false;
        }
//========================================================





        private void btnsubjectadd_Click(object sender, EventArgs e)
        {
            SubjectController subjectController = new SubjectController();
            Subject subject = new Subject { CourseID = selectedCourseId,SubjectName=textboxsubjectsubjectname.Text };
            subjectController.AddSubject(subject);
            LoadSubjectdata();


        }
        public void comboboxload()
        {
            var courseList = _courseController.getCourseList();
            if (courseList.Count > 0)
            {
                comboboxsubjectcoursename.DataSource = courseList;
                comboboxsubjectcoursename.DisplayMember = "CourseName";
                comboboxsubjectcoursename.ValueMember = "CourseID";
            }
            else
            {
                labelsubjecterror.Text = "No courses found. Please add a course first.";
            }
        }

        private void comboboxsubjectcoursename_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCourseId = (comboboxsubjectcoursename.SelectedIndex+1);
            labelsubjecterror.Text = comboboxsubjectcoursename.SelectedIndex.ToString();
        }
    }
}
