namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            Num1 = new TextBox();
            cbOperations = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Num2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.Location = new Point(21, 38);
            Num1.Name = "Num1";
            Num1.Size = new Size(200, 23);
            Num1.TabIndex = 0;
            // 
            // cbOperations
            // 
            cbOperations.FormattingEnabled = true;
            cbOperations.Location = new Point(82, 77);
            cbOperations.Name = "cbOperations";
            cbOperations.Size = new Size(75, 23);
            cbOperations.TabIndex = 1;
            cbOperations.SelectedIndexChanged += cbOperations_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(82, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 78);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 6;
            label3.Text = "Total";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            label1.Click += label1_Click;
            // 
            // Num2
            // 
            Num2.Location = new Point(21, 116);
            Num2.Name = "Num2";
            Num2.Size = new Size(200, 23);
            Num2.TabIndex = 4;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 297);
            Controls.Add(Num2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(cbOperations);
            Controls.Add(Num1);
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num1;
        private ComboBox cbOperations;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private TextBox Num2;
        private Label label3;
        private Label label2;
    }
}
