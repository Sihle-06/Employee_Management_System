using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Provide Username and Password",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectUser = "SELECT * FROM userAuthentication WHERE username = @username " +
                            "AND password = @password";


                        //Ensures only registered employees can login.
                        //string selectUser = "SELECT * FROM userAuthentication ua " +
                        //    "INNER JOIN employeeInfo ei ON ua.employeeID = ei.employeeID " +
                        //    "WHERE username = @employeeNumber AND password = @password";

                        

                        using (SqlCommand command = new SqlCommand(selectUser, connect))
                        {
                            //command.Parameters.AddWithValue("@employeeNumber", usernameTxt.Text.Trim());
                            command.Parameters.AddWithValue("@username", usernameTxt.Text.Trim());
                            command.Parameters.AddWithValue("@password", passwordTxt.Text.Trim());


                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(usernameTxt.Text + " Login Success!", " Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or Password Incorrect",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = showPassword.Checked ? '\0' : '*';
        }
    }
}
