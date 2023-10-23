using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public class SalaryData
    {
        public string EmployeeNo { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public decimal Salary { get; set; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeesList()
        {
            List<SalaryData> employees = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectEmployees = "SELECT * FROM employeeInfo " +
                        "WHERE status = 'Active' AND delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectEmployees, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            SalaryData empInfo = new SalaryData();
                            empInfo.EmployeeNo = reader["employeeNumber"].ToString();
                            empInfo.Firstname = reader["firstName"].ToString();
                            empInfo.Lastname = reader["lastName"].ToString();
                            empInfo.Email = reader["email"].ToString();
                            empInfo.Role = reader["role"].ToString();
                            empInfo.Salary = (decimal)reader["salary"];
                            employees.Add(empInfo);
                        }
                    }
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Error Encountered: " + se);
                }
                finally
                {
                    connect.Close();
                }
            }
            return employees;
        }
    }
}
