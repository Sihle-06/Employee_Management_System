using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Drawing.Image;
using System.Linq;
using System.Runtime.InteropServices;

namespace Employee_Management_System
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");
        public AddEmployee()
        {
            InitializeComponent();
            displayEmployees();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
                
            }
            displayEmployees();
        }

        public void displayEmployees()
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            List<EmployeeInfo> listData = employeeInfo.employeesList();

            addGrid.DataSource = listData;
        }

        public void clearFields()
        {
            firstnameTxt.Text = "";
            lastnameTxt.Text = "";
            dobPicker.Text = DateTime.Today.ToString();
            empNumberTxt.Text = "";
            roleCombo.SelectedIndex = -1;
            salarytxt.Text = "";
            profilePic.Image = null;
            status_comboBox.SelectedIndex = -1; 
            emailTxt.Text = ""; 
            managertxt.Text = "";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(firstnameTxt.Text == "" || lastnameTxt.Text  == "" || empNumberTxt.Text == "" || dobPicker.Text == "" ||
                roleCombo.Text == "" || emailTxt.Text == "" || status_comboBox.Text == "" || salarytxt.Text =="" || profilePic.Image == null)
            {
                MessageBox.Show("Fill In Required Fields", "Error Message ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmpId = "SELECT COUNT(*) FROM employeeInfo WHERE employeeNumber = @employeeNumber AND delete_date IS NULL";

                        using (SqlCommand command = new SqlCommand(checkEmpId, connect))
                        {
                            command.Parameters.AddWithValue("@employeeNumber", empNumberTxt.Text.Trim());

                            int count = (int)command.ExecuteScalar();
                            if (count >= 1) {

                                MessageBox.Show(empNumberTxt.Text.Trim() + " EmployeeID Already Exists",
                               "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if ((managertxt.Text.Trim() == "" && roleCombo.Text.Trim() != "Chief Executive Officer") ||
                                   (managertxt.Text.Trim() == empIDTxt.Text.Trim()))
                            {
                                MessageBox.Show("Role and ManagerID validation failed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime insertDate = DateTime.Today;
                                string insertInfo = "INSERT INTO employeeInfo (firstName, lastName, birthDate," +
                                    "employeeNumber, salary, role, managerID, image, email, status, insert_date) " +
                                    "VALUES(@firstName, @lastName, @birthDate, @employeeNumber, @salary, @role, " +
                                    "@managerID, @image, @email, @status, @insertDate)" ;


                                // Check if the role is the same as the managerID or if managerID is empty when the role is not "CEO"
                               




                                string imageFileName = "";

                                if (profilePic.Image != null)
                                {
                                    imageFileName = Path.Combine("C:\\Users\\s993540\\source\\Employee_Management_System\\Directory\\", empNumberTxt.Text.Trim() + ".jpg");
                                    string directoryPath = Path.GetDirectoryName(imageFileName);

                                    if (!Directory.Exists(directoryPath))
                                    {
                                        Directory.CreateDirectory(directoryPath);
                                    }

                                    profilePic.Image.Save(imageFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                }
                                

                                using (SqlCommand cmd = new SqlCommand(insertInfo, connect))
                                {
                                    cmd.Parameters.AddWithValue("@firstName", firstnameTxt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@lastName", lastnameTxt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@birthDate", dobPicker.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeNumber", empNumberTxt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", roleCombo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@salary", salarytxt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", imageFileName);
                                    cmd.Parameters.AddWithValue("@status", status_comboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertDate",insertDate);
                                    cmd.Parameters.AddWithValue("@managerID",managertxt.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    displayEmployees();

                                    MessageBox.Show("Added Successfully", "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    clearFields();
                                }
                            }
                        }


                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Error" + ex , "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally {
                        connect.Close();
                    }

                }
            }
        }

        private void addGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = addGrid.Rows[e.RowIndex];
                empIDTxt.Text = row.Cells[0].Value.ToString();
                empNumberTxt.Text = row.Cells[1].Value.ToString();
                firstnameTxt.Text = row.Cells[2].Value.ToString();
                lastnameTxt.Text = row.Cells[3].Value.ToString();
                dobPicker.Text = row.Cells[4].Value.ToString();

                //string dateString = row.Cells[4].Value.ToString();
                //DateTime date;

                //if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                //{

                //    dobPicker.Value = date;
                //}
                //else
                //{
                //    dobPicker.Text = dateString;
                //}
                emailTxt.Text = row.Cells[5].Value.ToString();
                roleCombo.Text = row.Cells[6].Value.ToString();
                salarytxt.Text = row.Cells[7].Value.ToString();
                string imageFileName = row.Cells[8].Value.ToString();

                if (!string.IsNullOrEmpty(imageFileName))
                {
                    try
                    {
                        profilePic.Image = System.Drawing.Image.FromFile(imageFileName);
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception, e.g., log the error or show an error message to the user.
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        profilePic.Image = null;
                    }
                }
                else
                {
                    profilePic.Image = null;
                }

                status_comboBox.Text = row.Cells[9].Value.ToString();  
                managertxt.Text = row.Cells[10].Value.ToString(); 

            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *png)|*.jpg;*png";
                //string imagePath = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                   
                    profilePic.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void gravatarBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string gravatarUrl = GravatarHelper.GetGravatarUrl(email);
                profilePic.ImageLocation = gravatarUrl;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the Gravatar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void salarytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (firstnameTxt.Text == "" || lastnameTxt.Text == "" || empNumberTxt.Text == "" || dobPicker.Text == "" ||
                roleCombo.Text == "" || emailTxt.Text == "" || status_comboBox.Text == "" || salarytxt.Text == "" || profilePic.Image == null)
            {
                MessageBox.Show("Fill In Required Fields", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Update Employee ID: " +
                    empNumberTxt.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(result == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime updateDate = DateTime.Today;
                        string updateEmployee = "UPDATE employeeInfo SET firstName = @firstName," +
                                    "lastName =@lastName,birthDate =@birthDate,employeeNumber = @employeeNumber,salary =@salary," +
                                    "role =@role,managerID =@managerID,image =@image,email =@email,status =@status," +
                                    "update_date = @update_Date " +
                                    "WHERE employeeNumber = @employeeNumber ";

                        //"WHERE(@managerID IS NULL AND @role = 'Chief Executive Officer') OR" +
                        //            "(@managerID IS NOT NULL AND @role<> 'Chief Executive Officer' AND @employeeNumber<> @managerID)"

                        string imageFileName = "";

                      
                            imageFileName = Path.Combine("C:\\Users\\s993540\\source\\Employee_Management_System\\Directory\\", empNumberTxt.Text.Trim() + ".jpg");
                            string directoryPath = Path.GetDirectoryName(imageFileName);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                       

                        using (SqlCommand cmd = new SqlCommand(updateEmployee, connect))
                        {
                            cmd.Parameters.AddWithValue("@firstName", firstnameTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastName", lastnameTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@birthDate", dobPicker.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeNumber", empNumberTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", roleCombo.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", salarytxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", imageFileName);
                            cmd.Parameters.AddWithValue("@status", status_comboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@update_date", updateDate);
                            cmd.Parameters.AddWithValue("@managerID", managertxt.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayEmployees();
                            

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
                    MessageBox.Show("Update Cancelled." , "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

              
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (firstnameTxt.Text == "" || lastnameTxt.Text == "" || empNumberTxt.Text == "" || dobPicker.Text == "" ||
               roleCombo.Text == "" || emailTxt.Text == "" || status_comboBox.Text == "" || salarytxt.Text == "" || profilePic.Image == null)
            {
                MessageBox.Show("Fill In Required Fields", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete Employee ID: " +
                    empNumberTxt.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime deleteDate = DateTime.Today;
                        string updateEmployee = "UPDATE employeeInfo SET "+
                                    "delete_date = @delete_Date " +
                                    "WHERE employeeNumber = @employeeNumber ";



                        using (SqlCommand cmd = new SqlCommand(updateEmployee, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeNumber", empNumberTxt.Text.Trim());                  
                            cmd.Parameters.AddWithValue("@delete_date", deleteDate);

                            cmd.ExecuteNonQuery();
                            displayEmployees();


                            MessageBox.Show(empNumberTxt.Text.Trim() + " deleted Successfully", "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public System.Drawing.Image LoadImage(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath) || !System.IO.File.Exists(imagePath))
                {
                    return null; 
                }

                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);

                return image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
                            empInfo.BirthDate = reader["birthDate"].ToString();
                            empInfo.Email = reader["email"].ToString();
                            empInfo.Role = reader["role"].ToString();
                            empInfo.Salary = (decimal)reader["salary"];
                            empInfo.Image = reader["image"].ToString();
                            empInfo.Status = reader["status"].ToString();
                            empInfo.ManagerID = (int)reader["managerID"];


                            firstnameTxt.Text = empInfo.Firstname;
                            lastnameTxt.Text = empInfo.Lastname;
                            dobPicker.Text = empInfo.BirthDate;
                            empNumberTxt.Text = empInfo.EmployeeNo;
                            roleCombo.SelectedItem = empInfo.Role;
                            salarytxt.Text = empInfo.Salary.ToString();
                            profilePic.Image = LoadImage( empInfo.Image);
                            status_comboBox.SelectedItem = empInfo.Status;
                            emailTxt.Text = empInfo.Email;
                            managertxt.Text = empInfo.ManagerID.ToString();


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

        private void button1_Click(object sender, EventArgs e)
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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            empIDTxt.Hide();
            label2.Hide();
        }

        private void orgBtn_Click(object sender, EventArgs e)
        {
            Organization organization = new Organization();
            organization.Show();
            this.Hide();
        }
    }
}
