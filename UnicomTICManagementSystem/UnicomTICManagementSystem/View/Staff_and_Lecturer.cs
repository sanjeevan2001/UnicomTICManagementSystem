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
    public partial class Staff_and_Lecturer : Form
    {
        public Staff_and_Lecturer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffadd_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            User user = new User { UserName = textstaff.Text, Password = staffpassword.Text, Role = "Staff" };
            loginController.CreatePassword(user);
        }

        private void lectureradd_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            User user = new User { UserName = textboxlecturer.Text, Password = lecturerpassword.Text, Role = "Lecturer" };
            loginController.CreatePassword(user);
            Lecturer lecturer = new Lecturer { LecturerName=textboxlecturer.Text,Address=lectureraddress.Text,PhoneNumber=lecturerphonenumber.Text };
            loginController.AddLecturer(lecturer);

        }
    }
}
