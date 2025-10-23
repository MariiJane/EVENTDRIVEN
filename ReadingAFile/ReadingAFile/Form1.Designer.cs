namespace ReadingAFile
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
            openFileDialog1 = new OpenFileDialog();
            btnOpen = new Button();
            lvShowText = new ListView();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.White;
            btnOpen.FlatStyle = FlatStyle.System;
            btnOpen.Location = new Point(151, 218);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(79, 28);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(12, 13);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(360, 187);
            lvShowText.TabIndex = 2;
            lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 274);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "Form1";
            Text = "FrmOpenTextFile";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnOpen;
        private ListView lvShowText;
    }
}
