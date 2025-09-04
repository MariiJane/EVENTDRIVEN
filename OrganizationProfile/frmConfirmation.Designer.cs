namespace OrganizationProfile
{
	partial class frmConfirmation
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			button1 = new Button();
			lblStudentNo = new Label();
			lblName = new Label();
			lblProgram = new Label();
			lblAge = new Label();
			lblBirthday = new Label();
			lblGender = new Label();
			lblContactNo = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 29);
			label1.Name = "label1";
			label1.Size = new Size(94, 20);
			label1.TabIndex = 0;
			label1.Text = "Student No. :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 76);
			label2.Name = "label2";
			label2.Size = new Size(52, 20);
			label2.TabIndex = 1;
			label2.Text = "Name:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 128);
			label3.Name = "label3";
			label3.Size = new Size(69, 20);
			label3.TabIndex = 2;
			label3.Text = "Program:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 171);
			label4.Name = "label4";
			label4.Size = new Size(39, 20);
			label4.TabIndex = 3;
			label4.Text = "Age:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 220);
			label5.Name = "label5";
			label5.Size = new Size(67, 20);
			label5.TabIndex = 4;
			label5.Text = "Birthday:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 272);
			label6.Name = "label6";
			label6.Size = new Size(60, 20);
			label6.TabIndex = 5;
			label6.Text = "Gender:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 319);
			label7.Name = "label7";
			label7.Size = new Size(90, 20);
			label7.TabIndex = 6;
			label7.Text = "Contact No.:";
			// 
			// button1
			// 
			button1.Location = new Point(215, 389);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 7;
			button1.Text = "Submit";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// lblStudentNo
			// 
			lblStudentNo.AutoSize = true;
			lblStudentNo.Location = new Point(155, 29);
			lblStudentNo.Name = "lblStudentNo";
			lblStudentNo.Size = new Size(94, 20);
			lblStudentNo.TabIndex = 8;
			lblStudentNo.Text = "Student No. :";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(155, 76);
			lblName.Name = "lblName";
			lblName.Size = new Size(52, 20);
			lblName.TabIndex = 9;
			lblName.Text = "Name:";
			// 
			// lblProgram
			// 
			lblProgram.AutoSize = true;
			lblProgram.Location = new Point(155, 128);
			lblProgram.Name = "lblProgram";
			lblProgram.Size = new Size(69, 20);
			lblProgram.TabIndex = 10;
			lblProgram.Text = "Program:";
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.Location = new Point(155, 171);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(39, 20);
			lblAge.TabIndex = 11;
			lblAge.Text = "Age:";
			// 
			// lblBirthday
			// 
			lblBirthday.AutoSize = true;
			lblBirthday.Location = new Point(155, 220);
			lblBirthday.Name = "lblBirthday";
			lblBirthday.Size = new Size(67, 20);
			lblBirthday.TabIndex = 12;
			lblBirthday.Text = "Birthday:";
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Location = new Point(155, 272);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(60, 20);
			lblGender.TabIndex = 13;
			lblGender.Text = "Gender:";
			// 
			// lblContactNo
			// 
			lblContactNo.AutoSize = true;
			lblContactNo.Location = new Point(159, 319);
			lblContactNo.Name = "lblContactNo";
			lblContactNo.Size = new Size(90, 20);
			lblContactNo.TabIndex = 14;
			lblContactNo.Text = "Contact No.:";
			// 
			// frmConfirmation
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(514, 450);
			Controls.Add(lblContactNo);
			Controls.Add(lblGender);
			Controls.Add(lblBirthday);
			Controls.Add(lblAge);
			Controls.Add(lblProgram);
			Controls.Add(lblName);
			Controls.Add(lblStudentNo);
			Controls.Add(button1);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmConfirmation";
			Text = "frmConfirmation";
			Load += frmConfirmation_Load;
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
		private Button button1;
		private Label lblStudentNo;
		private Label lblName;
		private Label lblProgram;
		private Label lblAge;
		private Label lblBirthday;
		private Label lblGender;
		private Label lblContactNo;
	}
}