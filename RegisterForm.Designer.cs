namespace Employee_Management_System
{
    partial class RegisterForm
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
            this.rgstr_usernameTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rgstr_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.psswrdLbl = new System.Windows.Forms.Label();
            this.rgstr_psswrdTxt = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.rgstrbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rgstr_usernameTxt
            // 
            this.rgstr_usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgstr_usernameTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgstr_usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgstr_usernameTxt.Location = new System.Drawing.Point(537, 235);
            this.rgstr_usernameTxt.Multiline = true;
            this.rgstr_usernameTxt.Name = "rgstr_usernameTxt";
            this.rgstr_usernameTxt.Size = new System.Drawing.Size(445, 49);
            this.rgstr_usernameTxt.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.rgstr_login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 597);
            this.panel1.TabIndex = 10;
            // 
            // rgstr_login
            // 
            this.rgstr_login.BackColor = System.Drawing.Color.IndianRed;
            this.rgstr_login.FlatAppearance.BorderSize = 0;
            this.rgstr_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rgstr_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rgstr_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rgstr_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgstr_login.ForeColor = System.Drawing.Color.White;
            this.rgstr_login.Location = new System.Drawing.Point(25, 492);
            this.rgstr_login.Name = "rgstr_login";
            this.rgstr_login.Size = new System.Drawing.Size(407, 41);
            this.rgstr_login.TabIndex = 5;
            this.rgstr_login.Text = "LOG IN";
            this.rgstr_login.UseVisualStyleBackColor = false;
            this.rgstr_login.Click += new System.EventHandler(this.rgstr_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Already Have An Account?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // psswrdLbl
            // 
            this.psswrdLbl.AutoSize = true;
            this.psswrdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psswrdLbl.Location = new System.Drawing.Point(532, 319);
            this.psswrdLbl.Name = "psswrdLbl";
            this.psswrdLbl.Size = new System.Drawing.Size(104, 25);
            this.psswrdLbl.TabIndex = 17;
            this.psswrdLbl.Text = "Password:";
            // 
            // rgstr_psswrdTxt
            // 
            this.rgstr_psswrdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgstr_psswrdTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgstr_psswrdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgstr_psswrdTxt.Location = new System.Drawing.Point(537, 365);
            this.rgstr_psswrdTxt.Multiline = true;
            this.rgstr_psswrdTxt.Name = "rgstr_psswrdTxt";
            this.rgstr_psswrdTxt.PasswordChar = '*';
            this.rgstr_psswrdTxt.Size = new System.Drawing.Size(445, 49);
            this.rgstr_psswrdTxt.TabIndex = 16;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(532, 192);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(108, 25);
            this.usernamelbl.TabIndex = 15;
            this.usernamelbl.Text = "Username:";
            // 
            // rgstrbtn
            // 
            this.rgstrbtn.BackColor = System.Drawing.Color.IndianRed;
            this.rgstrbtn.FlatAppearance.BorderSize = 0;
            this.rgstrbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rgstrbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.rgstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rgstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgstrbtn.Location = new System.Drawing.Point(663, 492);
            this.rgstrbtn.Name = "rgstrbtn";
            this.rgstrbtn.Size = new System.Drawing.Size(160, 41);
            this.rgstrbtn.TabIndex = 13;
            this.rgstrbtn.Text = "REGISTER";
            this.rgstrbtn.UseVisualStyleBackColor = false;
            this.rgstrbtn.Click += new System.EventHandler(this.rgstrTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register New User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Employee_Management_System.Properties.Resources.icons8_employee_100;
            this.pictureBox2.Location = new System.Drawing.Point(136, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // showPassword
            // 
            this.showPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.showPassword.AutoSize = true;
            this.showPassword.FlatAppearance.BorderSize = 0;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Image = global::Employee_Management_System.Properties.Resources.icons8_eyes_30;
            this.showPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPassword.Location = new System.Drawing.Point(988, 365);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(36, 36);
            this.showPassword.TabIndex = 19;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Employee_Management_System.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(485, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_Management_System.Properties.Resources.icons8_exit_50__1_;
            this.pictureBox1.Location = new System.Drawing.Point(989, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 597);
            this.Controls.Add(this.rgstr_usernameTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.psswrdLbl);
            this.Controls.Add(this.rgstr_psswrdTxt);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.rgstrbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rgstr_usernameTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rgstr_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label psswrdLbl;
        private System.Windows.Forms.TextBox rgstr_psswrdTxt;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button rgstrbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}