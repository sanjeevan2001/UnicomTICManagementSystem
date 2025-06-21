using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using UnicomTICManagementSystem.Controller;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnloginlogin_Click(object sender, EventArgs e)
        {
            //mainForm.ShowDialog();
            lableloginerror.Text = "";
            lableloginerror.Visible = false;


            User user = new User
            {
                UserName = textboxloginusername.Text.Trim(),
                Password = textboxloginpassword.Text.Trim(),
            };

            //check role
            var check_user = LoginController.checkrole(user);
            if (check_user.Count == 1)
            {

                string role = check_user[0].Role; //============
                string name = check_user[0].UserName;
                Console.WriteLine("Logged in role: " + check_user[0].UserName);

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.SetWelcomeText(name, role);
                mainForm.ShowDialog();
                this.Show();


            }
            else
            {
                lableloginerror.Text = "Check your username and password.";

                lableloginerror.Visible = true;
                //MessageBox.Show("Login failed. Check your username and password.");

            }

        }
    }
}
