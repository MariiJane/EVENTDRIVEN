namespace OrganizationProfile
{
    partial class Form1
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			btnRegister = new Button();
			txtStudentNo = new TextBox();
			txtLastName = new TextBox();
			txtFirstName = new TextBox();
			txtAge = new TextBox();
			txtContactNo = new TextBox();
			txtMiddleInitial = new TextBox();
			cbPrograms = new ComboBox();
			datePickerBirthday = new DateTimePicker();
			cbGender = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 21);
			label1.Name = "label1";
			label1.Size = new Size(128, 28);
			label1.TabIndex = 0;
			label1.Text = "Registration";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 71);
			label2.Name = "label2";
			label2.Size = new Size(87, 20);
			label2.TabIndex = 1;
			label2.Text = "Student No.";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(381, 71);
			label3.Name = "label3";
			label3.Size = new Size(69, 20);
			label3.TabIndex = 2;
			label3.Text = "Program:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(20, 130);
			label4.Name = "label4";
			label4.Size = new Size(79, 20);
			label4.TabIndex = 3;
			label4.Text = "Last Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(370, 130);
			label5.Name = "label5";
			label5.Size = new Size(80, 20);
			label5.TabIndex = 4;
			label5.Text = "First Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(689, 130);
			label6.Name = "label6";
			label6.Size = new Size(29, 20);
			label6.TabIndex = 5;
			label6.Text = "M.I";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(63, 195);
			label7.Name = "label7";
			label7.Size = new Size(36, 20);
			label7.TabIndex = 6;
			label7.Text = "Age";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(393, 195);
			label8.Name = "label8";
			label8.Size = new Size(57, 20);
			label8.TabIndex = 7;
			label8.Text = "Gender";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(35, 245);
			label9.Name = "label9";
			label9.Size = new Size(64, 20);
			label9.TabIndex = 8;
			label9.Text = "Birthday";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(378, 245);
			label10.Name = "label10";
			label10.Size = new Size(87, 20);
			label10.TabIndex = 9;
			label10.Text = "Contact No.";
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(356, 304);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(94, 43);
			btnRegister.TabIndex = 10;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// txtStudentNo
			// 
			txtStudentNo.Location = new Point(105, 68);
			txtStudentNo.Name = "txtStudentNo";
			txtStudentNo.Size = new Size(259, 27);
			txtStudentNo.TabIndex = 11;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(105, 127);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(259, 27);
			txtLastName.TabIndex = 12;
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(471, 127);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(212, 27);
			txtFirstName.TabIndex = 13;
			// 
			// txtAge
			// 
			txtAge.Location = new Point(105, 188);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(125, 27);
			txtAge.TabIndex = 14;
			// 
			// txtContactNo
			// 
			txtContactNo.Location = new Point(471, 242);
			txtContactNo.Name = "txtContactNo";
			txtContactNo.Size = new Size(212, 27);
			txtContactNo.TabIndex = 15;
			// 
			// txtMiddleInitial
			// 
			txtMiddleInitial.Location = new Point(724, 127);
			txtMiddleInitial.Name = "txtMiddleInitial";
			txtMiddleInitial.Size = new Size(64, 27);
			txtMiddleInitial.TabIndex = 16;
			// 
			// cbPrograms
			// 
			cbPrograms.FormattingEnabled = true;
			cbPrograms.Location = new Point(471, 63);
			cbPrograms.Name = "cbPrograms";
			cbPrograms.Size = new Size(317, 28);
			cbPrograms.TabIndex = 17;
			// 
			// datePickerBirthday
			// 
			datePickerBirthday.Location = new Point(107, 240);
			datePickerBirthday.Name = "datePickerBirthday";
			datePickerBirthday.Size = new Size(257, 27);
			datePickerBirthday.TabIndex = 18;
			// 
			// cbGender
			// 
			cbGender.FormattingEnabled = true;
			cbGender.Location = new Point(471, 195);
			cbGender.Name = "cbGender";
			cbGender.Size = new Size(317, 28);
			cbGender.TabIndex = 19;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 369);
			Controls.Add(cbGender);
			Controls.Add(datePickerBirthday);
			Controls.Add(cbPrograms);
			Controls.Add(txtMiddleInitial);
			Controls.Add(txtContactNo);
			Controls.Add(txtAge);
			Controls.Add(txtFirstName);
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
			Name = "Form1";
			Text = "Organization Profile";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Button btnRegister;
		private TextBox txtStudentNo;
		private TextBox txtLastName;
		private TextBox txtFirstName;
		private TextBox txtAge;
		private TextBox txtContactNo;
		private TextBox txtMiddleInitial;
		private ComboBox cbPrograms;
		private DateTimePicker datePickerBirthday;
		private ComboBox cbGender;
	}
}
