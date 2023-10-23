namespace Employee_Management_System
{
    partial class AddEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.gravatarBtn = new System.Windows.Forms.Button();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.managertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empNumberTxt = new System.Windows.Forms.TextBox();
            this.EmpNoTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.empIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 301);
            this.panel1.TabIndex = 0;
            // 
            // addGrid
            // 
            this.addGrid.AllowUserToAddRows = false;
            this.addGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.addGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addGrid.EnableHeadersVisualStyles = false;
            this.addGrid.Location = new System.Drawing.Point(23, 57);
            this.addGrid.Name = "addGrid";
            this.addGrid.ReadOnly = true;
            this.addGrid.RowHeadersVisible = false;
            this.addGrid.RowHeadersWidth = 51;
            this.addGrid.RowTemplate.Height = 24;
            this.addGrid.Size = new System.Drawing.Size(1172, 216);
            this.addGrid.TabIndex = 1;
            this.addGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.empIDTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.gravatarBtn);
            this.panel2.Controls.Add(this.dobPicker);
            this.panel2.Controls.Add(this.status_comboBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.roleCombo);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Controls.Add(this.uploadBtn);
            this.panel2.Controls.Add(this.profilePic);
            this.panel2.Controls.Add(this.managertxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.salarytxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.empNumberTxt);
            this.panel2.Controls.Add(this.EmpNoTxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lastnameTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.firstnameTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(29, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 403);
            this.panel2.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.IndianRed;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(59, 316);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(193, 61);
            this.searchBtn.TabIndex = 32;
            this.searchBtn.Text = "Search Employee";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gravatarBtn
            // 
            this.gravatarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.gravatarBtn.FlatAppearance.BorderSize = 0;
            this.gravatarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.gravatarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.gravatarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gravatarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravatarBtn.ForeColor = System.Drawing.Color.White;
            this.gravatarBtn.Location = new System.Drawing.Point(1021, 199);
            this.gravatarBtn.Name = "gravatarBtn";
            this.gravatarBtn.Size = new System.Drawing.Size(174, 41);
            this.gravatarBtn.TabIndex = 31;
            this.gravatarBtn.Text = "Gravatar ";
            this.gravatarBtn.UseVisualStyleBackColor = false;
            this.gravatarBtn.Click += new System.EventHandler(this.gravatarBtn_Click);
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(151, 183);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(233, 28);
            this.dobPicker.TabIndex = 30;
            // 
            // status_comboBox
            // 
            this.status_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_comboBox.Location = new System.Drawing.Point(641, 196);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(237, 30);
            this.status_comboBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Status";
            // 
            // roleCombo
            // 
            this.roleCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.roleCombo.Location = new System.Drawing.Point(641, 76);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(237, 30);
            this.roleCombo.TabIndex = 27;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.IndianRed;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(1004, 316);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(193, 61);
            this.clearBtn.TabIndex = 26;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(768, 316);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(193, 61);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete Employee";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(537, 316);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(193, 61);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update Employee";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.IndianRed;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(292, 316);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(193, 61);
            this.createBtn.TabIndex = 23;
            this.createBtn.Text = "Create Employee";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.IndianRed;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.uploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(1021, 256);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(174, 41);
            this.uploadBtn.TabIndex = 22;
            this.uploadBtn.Text = "Upload Picture";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // managertxt
            // 
            this.managertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managertxt.Location = new System.Drawing.Point(641, 135);
            this.managertxt.Multiline = true;
            this.managertxt.Name = "managertxt";
            this.managertxt.Size = new System.Drawing.Size(237, 30);
            this.managertxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Manager";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(151, 230);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(237, 30);
            this.emailTxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Role";
            // 
            // salarytxt
            // 
            this.salarytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarytxt.Location = new System.Drawing.Point(641, 23);
            this.salarytxt.Multiline = true;
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(237, 30);
            this.salarytxt.TabIndex = 14;
            this.salarytxt.TextChanged += new System.EventHandler(this.salarytxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salary";
            // 
            // empNumberTxt
            // 
            this.empNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNumberTxt.Location = new System.Drawing.Point(151, 22);
            this.empNumberTxt.Multiline = true;
            this.empNumberTxt.Name = "empNumberTxt";
            this.empNumberTxt.Size = new System.Drawing.Size(237, 30);
            this.empNumberTxt.TabIndex = 12;
            // 
            // EmpNoTxt
            // 
            this.EmpNoTxt.AutoSize = true;
            this.EmpNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNoTxt.Location = new System.Drawing.Point(18, 23);
            this.EmpNoTxt.Name = "EmpNoTxt";
            this.EmpNoTxt.Size = new System.Drawing.Size(134, 25);
            this.EmpNoTxt.TabIndex = 11;
            this.EmpNoTxt.Text = "Employee No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birth Date";
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxt.Location = new System.Drawing.Point(151, 135);
            this.lastnameTxt.Multiline = true;
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(237, 30);
            this.lastnameTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxt.Location = new System.Drawing.Point(151, 79);
            this.firstnameTxt.Multiline = true;
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(237, 30);
            this.firstnameTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Location = new System.Drawing.Point(1059, 22);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(136, 157);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 21;
            this.profilePic.TabStop = false;
            // 
            // empIDTxt
            // 
            this.empIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDTxt.Location = new System.Drawing.Point(641, 255);
            this.empIDTxt.Multiline = true;
            this.empIDTxt.Name = "empIDTxt";
            this.empIDTxt.Size = new System.Drawing.Size(237, 30);
            this.empIDTxt.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "EmployeeID.";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1274, 764);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView addGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empNumberTxt;
        private System.Windows.Forms.Label EmpNoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox managertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox roleCombo;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Button gravatarBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox empIDTxt;
        private System.Windows.Forms.Label label2;
    }
}
