namespace CreatingTextFile
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Poppins", 12F);
            txtFileName.Location = new Point(12, 59);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(269, 31);
            txtFileName.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.White;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Poppins", 12F);
            btnOK.Location = new Point(101, 113);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(89, 31);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 174);
            Controls.Add(btnOK);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnOK;
    }
}