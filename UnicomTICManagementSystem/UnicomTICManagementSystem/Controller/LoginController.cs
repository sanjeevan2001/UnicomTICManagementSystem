using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controller
{
    internal class LoginController
    {
        public static List<User> checkrole(User user)
        {
            List<User> roles = new List<User>();
            if (user == null || string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.Password))
            {
                //LoginForm loginForm = new LoginForm;

                Console.WriteLine("Invalid user or username.");
                return roles; //empty list
            }
            using (var conn = Repositories.DatabaseManager.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE UserName = @username AND Password = @password", conn);

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User foundUser = new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        UserName = reader["UserName"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString()
                    };

                    roles.Add(foundUser);
                }
            }
            return roles;
        }

        public void CreatePassword(User user)
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Users (Username,Password,Role) VALUES (@username,@password,@role)", connection);
                    cmd.Parameters.AddWithValue("@username", user.UserName);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.ExecuteNonQuery();
                    //return true
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//return false }

            }
        }
    }
}
