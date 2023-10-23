using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class DashboardForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public DashboardForm()
        {
            InitializeComponent();
            getActiveEmployees();
            getInactiveEmployees();
            getTotalEmployees();
        }

        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

            }
            getActiveEmployees();
            getInactiveEmployees();
            getTotalEmployees();
        }

        private void getTotalEmployees()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectUser = "SELECT COUNT(employeeID) FROM employeeInfo WHERE delete_date IS NULL";

                    using (SqlCommand command = new SqlCommand(selectUser, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            totalEmpLbl.Text = count.ToString();

                        }
                        reader.Close();
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

        private void getActiveEmployees()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectUser = "SELECT COUNT(employeeID) FROM employeeInfo WHERE delete_date IS NULL AND status = @status ";

                    using (SqlCommand command = new SqlCommand(selectUser, connect))
                    {
                        command.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            activeEmpsLbl.Text = count.ToString();

                        }
                        reader.Close();
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

        private void getInactiveEmployees()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectUser = "SELECT COUNT(employeeID) FROM employeeInfo WHERE delete_date IS NULL AND status = @status ";

                    using (SqlCommand command = new SqlCommand(selectUser, connect))
                    {
                        command.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            inactiveEmpsLbl.Text = count.ToString();

                        }
                        reader.Close();
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

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
