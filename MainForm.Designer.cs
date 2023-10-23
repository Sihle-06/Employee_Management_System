namespace Employee_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signoutLbl = new System.Windows.Forms.Label();
            this.signout_btn = new System.Windows.Forms.Button();
            this.salaryBtn = new System.Windows.Forms.Button();
            this.addempBtn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dashboardForm1 = new Employee_Management_System.DashboardForm();
            this.addEmployee1 = new Employee_Management_System.AddEmployee();
            this.salary1 = new Employee_Management_System.Salary();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.signoutLbl);
            this.panel1.Controls.Add(this.signout_btn);
            this.panel1.Controls.Add(this.salaryBtn);
            this.panel1.Controls.Add(this.addempBtn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.greetUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 836);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // signoutLbl
            // 
            this.signoutLbl.AutoSize = true;
            this.signoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutLbl.ForeColor = System.Drawing.Color.White;
            this.signoutLbl.Location = new System.Drawing.Point(86, 756);
            this.signoutLbl.Name = "signoutLbl";
            this.signoutLbl.Size = new System.Drawing.Size(125, 32);
            this.signoutLbl.TabIndex = 10;
            this.signoutLbl.Text = "Sign Out";
            this.signoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signout_btn
            // 
            this.signout_btn.FlatAppearance.BorderSize = 0;
            this.signout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.signout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.signout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout_btn.Image = global::Employee_Management_System.Properties.Resources.icons8_logout_50;
            this.signout_btn.Location = new System.Drawing.Point(21, 747);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(70, 63);
            this.signout_btn.TabIndex = 9;
            this.signout_btn.UseVisualStyleBackColor = true;
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            // 
            // salaryBtn
            // 
            this.salaryBtn.BackColor = System.Drawing.Color.Navy;
            this.salaryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.salaryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.salaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBtn.ForeColor = System.Drawing.Color.White;
            this.salaryBtn.Image = global::Employee_Management_System.Properties.Resources.icons8_salary_male_64;
            this.salaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryBtn.Location = new System.Drawing.Point(11, 466);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(351, 79);
            this.salaryBtn.TabIndex = 8;
            this.salaryBtn.Text = "SALARY";
            this.salaryBtn.UseVisualStyleBackColor = false;
            this.salaryBtn.Click += new System.EventHandler(this.salaryBtn_Click);
            // 
            // addempBtn
            // 
            this.addempBtn.BackColor = System.Drawing.Color.Navy;
            this.addempBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.addempBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addempBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addempBtn.ForeColor = System.Drawing.Color.White;
            this.addempBtn.Image = global::Employee_Management_System.Properties.Resources.icons8_employee_64__2_;
            this.addempBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addempBtn.Location = new System.Drawing.Point(12, 369);
            this.addempBtn.Name = "addempBtn";
            this.addempBtn.Size = new System.Drawing.Size(349, 91);
            this.addempBtn.TabIndex = 7;
            this.addempBtn.Text = "ADD EMPLOYEE";
            this.addempBtn.UseVisualStyleBackColor = false;
            this.addempBtn.Click += new System.EventHandler(this.addempBtn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.Navy;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_btn.Image")));
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 269);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(350, 84);
            this.dashboard_btn.TabIndex = 6;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUser.ForeColor = System.Drawing.Color.White;
            this.greetUser.Location = new System.Drawing.Point(67, 201);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(219, 32);
            this.greetUser.TabIndex = 5;
            this.greetUser.Text = "Welcome, User";
            this.greetUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.greetUser.Click += new System.EventHandler(this.greetUser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(390, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 68);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1472, 785);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1135, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(367, 61);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1277, 824);
            this.dashboardForm1.TabIndex = 4;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(367, 61);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1473, 830);
            this.addEmployee1.TabIndex = 3;
            // 
            // salary1
            // 
            this.salary1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salary1.Location = new System.Drawing.Point(368, 64);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(1384, 794);
            this.salary1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 836);
            this.Controls.Add(this.dashboardForm1);
            this.Controls.Add(this.addEmployee1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button salaryBtn;
        private System.Windows.Forms.Button addempBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signout_btn;
        private System.Windows.Forms.Label signoutLbl;
        private System.Windows.Forms.Panel panel3;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private DashboardForm dashboardForm1;
    }
}