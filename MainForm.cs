using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //greetUser.Text = 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            DashboardForm dashForm = dashboardForm1 as DashboardForm;

            if(dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void addempBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;

            AddEmployee addEmployee = addEmployee1 as AddEmployee;
            if(addEmployee != null)
            {
                addEmployee.RefreshData();
            }
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;

            Salary salaryForm = salary1 as Salary;
            if(salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void greetUser_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
