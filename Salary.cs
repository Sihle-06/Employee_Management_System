using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public Salary()
        {
            InitializeComponent();
            getEmployeeDetails();
        }

        public void getEmployeeDetails()
        {
            SalaryData employeeInfo = new SalaryData();
            List<SalaryData> employees = employeeInfo.salaryEmployeesList();
            addGrid.DataSource = employees;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            getEmployeeDetails();
        }

        public void clearFields()
        {
            firstnameTxt.Text = "";
            lastnameTxt.Text = "";
            empNumberTxt.Text = "";
            roleCombo.SelectedIndex = -1;
            salarytxt.Text = "";
            emailTxt.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void addGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = addGrid.Rows[e.RowIndex];
                empNumberTxt.Text = row.Cells[0].Value.ToString();
                firstnameTxt.Text = row.Cells[1].Value.ToString();
                lastnameTxt.Text = row.Cells[2].Value.ToString();
                emailTxt.Text = row.Cells[3].Value.ToString();
                roleCombo.Text = row.Cells[4].Value.ToString();
                salarytxt.Text = row.Cells[5].Value.ToString();



            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (firstnameTxt.Text == "" || lastnameTxt.Text == "" || empNumberTxt.Text == "" ||
                roleCombo.Text == "" || emailTxt.Text == "" || salarytxt.Text == "")
            {
                MessageBox.Show("Fields missing information", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Update Employee ID: " +
                    empNumberTxt.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime updateDate = DateTime.Today;
                        string updateEmployee = "UPDATE employeeInfo SET firstName = @firstName," +
                                    "lastName =@lastName,employeeNumber = @employeeNumber,salary =@salary," +
                                    "role =@role,email =@email," +
                                    "update_date = @update_Date " +
                                    "WHERE employeeNumber = @employeeNumber ";


                        using (SqlCommand cmd = new SqlCommand(updateEmployee, connect))
                        {
                            cmd.Parameters.AddWithValue("@firstName", firstnameTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastName", lastnameTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeNumber", empNumberTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", roleCombo.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", salarytxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@update_date", updateDate);

                            cmd.ExecuteNonQuery();
                            getEmployeeDetails();


                            MessageBox.Show("Updated Successfully", "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Update Cancelled.", "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void SearchEmployeeByID(string employeeNumber)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectUser = "SELECT * FROM employeeInfo WHERE employeeNumber = @employeeNumber";

                    using (SqlCommand command = new SqlCommand(selectUser, connect))
                    {
                        command.Parameters.AddWithValue("@employeeNumber", employeeNumber);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            EmployeeInfo empInfo = new EmployeeInfo();
                            empInfo.EmployeeNo = reader["employeeNumber"].ToString();
                            empInfo.Firstname = reader["firstName"].ToString();
                            empInfo.Firstname = reader["firstName"].ToString();
                            empInfo.Lastname = reader["lastName"].ToString();
                            empInfo.Email = reader["email"].ToString();
                            empInfo.Role = reader["role"].ToString();
                            empInfo.Salary = (decimal)reader["salary"];


                            firstnameTxt.Text = empInfo.Firstname;
                            lastnameTxt.Text = empInfo.Lastname;
                            empNumberTxt.Text = empInfo.EmployeeNo;
                            roleCombo.SelectedItem = empInfo.Role;
                            salarytxt.Text = empInfo.Salary.ToString();
                            emailTxt.Text = empInfo.Email;



                        }
                        else
                        {
                            MessageBox.Show("Invalid Employee Number",
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(empNumberTxt.Text))
            {
                MessageBox.Show("Provide Employee Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchEmployeeByID(empNumberTxt.Text.Trim());
            }
        }
    }
}
