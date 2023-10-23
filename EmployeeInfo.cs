using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace Employee_Management_System
{
    class EmployeeInfo
    {
        public int EmployeeID { get; set; }
        public string EmployeeNo { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }       
        public decimal Salary { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public int ManagerID { get; set; }
        
        
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\s993540\OneDrive - Sanlam Life Insurance Limited\Documents\employee.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<EmployeeInfo> employeesList()
        {
            List<EmployeeInfo> employees = new List<EmployeeInfo>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectEmployees = "SELECT * FROM employeeInfo " +
                        "WHERE delete_date IS NULL";
                    using(SqlCommand cmd = new SqlCommand(selectEmployees, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeInfo empInfo = new EmployeeInfo();
                            empInfo.EmployeeID = (int)reader["employeeID"];
                            empInfo.EmployeeNo = reader["employeeNumber"].ToString();
                            empInfo.Firstname = reader["firstName"].ToString();
                            empInfo.Lastname = reader["lastName"].ToString();
                            empInfo.BirthDate = reader["birthDate"].ToString();
                            empInfo.Email = reader["email"].ToString();
                            empInfo.Role = reader["role"].ToString();
                            empInfo.Salary = (decimal)reader["salary"];
                            empInfo.Image = reader["image"].ToString();
                            empInfo.Status = reader["status"].ToString();                            
                            empInfo.ManagerID = (int)reader["managerID"];
                            employees.Add(empInfo);
                        }
                    }
                }
                catch(SqlException se) { 
                    Console.WriteLine("Error Encountered: "+ se);
                }
                finally { 
                    connect.Close(); 
                }
            }
            return employees;
        }



    }
}
