namespace RegistrationTextFile
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtContactNo = new TextBox();
            dtpBirthday = new DateTimePicker();
            cbGender = new ComboBox();
            txtMI = new TextBox();
            txtFirstName = new TextBox();
            cbProgram = new ComboBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtStudentNo = new TextBox();
            btnRegister = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Microsoft Sans Serif", 9F);
            txtContactNo.Location = new Point(422, 166);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(136, 21);
            txtContactNo.TabIndex = 39;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(88, 169);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(208, 23);
            dtpBirthday.TabIndex = 38;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(336, 131);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(149, 23);
            cbGender.TabIndex = 37;
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Microsoft Sans Serif", 9F);
            txtMI.Location = new Point(516, 90);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(42, 21);
            txtMI.TabIndex = 36;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.Location = new Point(336, 90);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(149, 21);
            txtFirstName.TabIndex = 35;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(336, 55);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(222, 23);
            cbProgram.TabIndex = 34;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Microsoft Sans Serif", 9F);
            txtAge.Location = new Point(88, 129);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(72, 21);
            txtAge.TabIndex = 33;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.Location = new Point(88, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(165, 21);
            txtLastName.TabIndex = 32;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Microsoft Sans Serif", 9F);
            txtStudentNo.Location = new Point(88, 53);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(165, 21);
            txtStudentNo.TabIndex = 31;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.System;
            btnRegister.Font = new Font("Microsoft Sans Serif", 9F);
            btnRegister.Location = new Point(248, 225);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(91, 29);
            btnRegister.TabIndex = 30;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(336, 169);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 29;
            label10.Text = "Contact No.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.Location = new Point(23, 169);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 28;
            label9.Text = "Birthday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(277, 131);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 27;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(49, 131);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 26;
            label7.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(488, 90);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 25;
            label6.Text = "M.I.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(259, 90);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 24;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(11, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 23;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(269, 55);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 22;
            label3.Text = "Program";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(11, 58);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 21;
            label2.Text = "Student No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 20;
            label1.Text = "Registration";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.Location = new Point(467, 225);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 40;
            button1.Text = "Records";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 270);
            Controls.Add(button1);
            Controls.Add(txtContactNo);
            Controls.Add(dtpBirthday);
            Controls.Add(cbGender);
            Controls.Add(txtMI);
            Controls.Add(txtFirstName);
            Controls.Add(cbProgram);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(btnRegister);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContactNo;
        private DateTimePicker dtpBirthday;
        private ComboBox cbGender;
        private TextBox txtMI;
        private TextBox txtFirstName;
        private ComboBox cbProgram;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtStudentNo;
        private Button btnRegister;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
