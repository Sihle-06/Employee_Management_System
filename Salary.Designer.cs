namespace Employee_Management_System
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.empNumberTxt = new System.Windows.Forms.TextBox();
            this.EmpNoTxt = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.roleCombo);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.empNumberTxt);
            this.panel1.Controls.Add(this.EmpNoTxt);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.salarytxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lastnameTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.firstnameTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(19, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 764);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(24, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "Search Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roleCombo
            // 
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.Items.AddRange(new object[] {
            "Graduate",
            "Junior Developer",
            "Business Management",
            "Finance",
            "Human Resourses",
            "Team Lead",
            "Manager",
            "Head Of Department",
            "Chief Technology Officer",
            "Chief Finance Officer",
            "Chief Operation Officer",
            "Chief Executive Officer"});
            this.roleCombo.Location = new System.Drawing.Point(23, 288);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(237, 24);
            this.roleCombo.TabIndex = 31;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.IndianRed;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(24, 580);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(257, 39);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Update Employee";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empNumberTxt
            // 
            this.empNumberTxt.Location = new System.Drawing.Point(24, 49);
            this.empNumberTxt.Multiline = true;
            this.empNumberTxt.Name = "empNumberTxt";
            this.empNumberTxt.Size = new System.Drawing.Size(151, 30);
            this.empNumberTxt.TabIndex = 26;
            // 
            // EmpNoTxt
            // 
            this.EmpNoTxt.AutoSize = true;
            this.EmpNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNoTxt.Location = new System.Drawing.Point(19, 21);
            this.EmpNoTxt.Name = "EmpNoTxt";
            this.EmpNoTxt.Size = new System.Drawing.Size(140, 25);
            this.EmpNoTxt.TabIndex = 25;
            this.EmpNoTxt.Text = "Employee No:.";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(24, 375);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(236, 30);
            this.emailTxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Role:";
            // 
            // salarytxt
            // 
            this.salarytxt.Location = new System.Drawing.Point(24, 461);
            this.salarytxt.Multiline = true;
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(236, 30);
            this.salarytxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Salary:";
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Location = new System.Drawing.Point(24, 207);
            this.lastnameTxt.Multiline = true;
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(236, 30);
            this.lastnameTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Location = new System.Drawing.Point(24, 128);
            this.firstnameTxt.Multiline = true;
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(236, 30);
            this.firstnameTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addGrid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(341, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 762);
            this.panel2.TabIndex = 1;
            // 
            // addGrid
            // 
            this.addGrid.AllowUserToAddRows = false;
            this.addGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.addGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.addGrid.EnableHeadersVisualStyles = false;
            this.addGrid.Location = new System.Drawing.Point(0, 0);
            this.addGrid.Name = "addGrid";
            this.addGrid.ReadOnly = true;
            this.addGrid.RowHeadersVisible = false;
            this.addGrid.RowHeadersWidth = 51;
            this.addGrid.RowTemplate.Height = 24;
            this.addGrid.Size = new System.Drawing.Size(978, 760);
            this.addGrid.TabIndex = 2;
            this.addGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(1335, 794);
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empNumberTxt;
        private System.Windows.Forms.Label EmpNoTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox roleCombo;
        private System.Windows.Forms.DataGridView addGrid;
        private System.Windows.Forms.Button button2;
    }
}
