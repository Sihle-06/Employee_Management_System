using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void rgstrTxt_Click(object sender, EventArgs e)
        {
            if (rgstr_usernameTxt.Text == "" || rgstr_psswrdTxt.Text == "")
            {
                MessageBox.Show("Please Provide All Fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {

                        connect.Open();

                        string selectUsername = "SELECT COUNT(userID) FROM userAuthentication WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", rgstr_usernameTxt.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {

                                MessageBox.Show(rgstr_usernameTxt.Text.Trim() + " Username Already Exists",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                DateTime registeredDate = DateTime.Today;

                                string insertUser = "INSERT INTO userAuthentication " +
                                    "(username, password, date_registered) " +
                                    "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand command = new SqlCommand(insertUser, connect))
                                {

                                    command.Parameters.AddWithValue("@username", rgstr_usernameTxt.Text.Trim());
                                    command.Parameters.AddWithValue("@password", rgstr_psswrdTxt.Text.Trim());
                                    command.Parameters.AddWithValue("@dateReg", registeredDate);
                                    
                                    command.ExecuteNonQuery();

                                    MessageBox.Show(rgstr_usernameTxt.Text + " Registered Successfully!", " Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }

                        }


                    }
                    catch
                    {
                        MessageBox.Show("Cannot Connect To DataBase", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connect.Close();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            rgstr_psswrdTxt.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void rgstr_login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
