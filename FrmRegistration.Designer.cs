namespace Sulit_Justin_LabStream
{
    partial class FrmRegistration
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
            lblTitle = new Label();
            lblStudentNo = new Label();
            txtStudentNo = new TextBox();
            lblProgram = new Label();
            cboProgram = new ComboBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblMI = new Label();
            txtMI = new TextBox();
            txtAge = new TextBox();
            lblAge = new Label();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            lblContact = new Label();
            txtContact = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F);
            lblTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.ForeColor = Color.FromArgb(31, 58, 95);
            lblStudentNo.Location = new Point(30, 95);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(82, 19);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(140, 92);
            txtStudentNo.MaxLength = 11;
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(140, 25);
            txtStudentNo.TabIndex = 2;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.ForeColor = Color.FromArgb(31, 58, 95);
            lblProgram.Location = new Point(330, 95);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(62, 19);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cboProgram
            // 
            cboProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProgram.FlatStyle = FlatStyle.Flat;
            cboProgram.FormattingEnabled = true;
            cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Business Administration", "BS Computer Engineering", "BS Criminology", "BS Tourism Management", "BS Hospitality Management" });
            cboProgram.Location = new Point(400, 92);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(250, 25);
            cboProgram.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.FromArgb(31, 58, 95);
            lblLastName.Location = new Point(30, 140);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(74, 19);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.FromArgb(31, 58, 95);
            lblFirstName.Location = new Point(295, 140);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(75, 19);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 137);
            txtLastName.MaxLength = 100;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 25);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(385, 137);
            txtFirstName.MaxLength = 100;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 25);
            txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.ForeColor = Color.FromArgb(31, 58, 95);
            lblMI.Location = new Point(560, 140);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(32, 19);
            lblMI.TabIndex = 9;
            lblMI.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(600, 137);
            txtMI.MaxLength = 2;
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(50, 25);
            txtMI.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(140, 182);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(80, 25);
            txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.FromArgb(31, 58, 95);
            lblAge.Location = new Point(30, 185);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(33, 19);
            lblAge.TabIndex = 12;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.FromArgb(31, 58, 95);
            lblGender.Location = new Point(260, 185);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 19);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(330, 182);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(120, 25);
            cboGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.ForeColor = Color.FromArgb(31, 58, 95);
            lblBirthday.Location = new Point(30, 235);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(60, 19);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(140, 232);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(220, 25);
            dtpBirthday.TabIndex = 16;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.ForeColor = Color.FromArgb(31, 58, 95);
            lblContact.Location = new Point(380, 235);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(82, 19);
            lblContact.TabIndex = 17;
            lblContact.Text = "Contact No.";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(480, 232);
            txtContact.MaxLength = 11;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(170, 25);
            txtContact.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(31, 58, 95);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(275, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 40);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(664, 409);
            Controls.Add(btnRegister);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(dtpBirthday);
            Controls.Add(lblBirthday);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(txtMI);
            Controls.Add(lblMI);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(cboProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentNo;
        private TextBox txtStudentNo;
        private Label lblProgram;
        private ComboBox cboProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMI;
        private TextBox txtMI;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnRegister;
    }
}