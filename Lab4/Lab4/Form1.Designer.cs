namespace Lab4
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
            Bai1 = new Button();
            Bai2 = new Button();
            Bai3 = new Button();
            Bai4 = new Button();
            Bai5 = new Button();
            Bai6 = new Button();
            SuspendLayout();
            // 
            // Bai1
            // 
            Bai1.BackColor = SystemColors.ActiveCaption;
            Bai1.ForeColor = SystemColors.ActiveCaptionText;
            Bai1.Location = new Point(147, 112);
            Bai1.Name = "Bai1";
            Bai1.Size = new Size(136, 59);
            Bai1.TabIndex = 0;
            Bai1.Text = "Bài 1";
            Bai1.UseVisualStyleBackColor = false;
            Bai1.Click += Bai1_Click;
            // 
            // Bai2
            // 
            Bai2.BackColor = SystemColors.ActiveCaption;
            Bai2.Location = new Point(357, 112);
            Bai2.Name = "Bai2";
            Bai2.Size = new Size(136, 59);
            Bai2.TabIndex = 1;
            Bai2.Text = "Bài 2";
            Bai2.UseVisualStyleBackColor = false;
            Bai2.Click += Bai2_Click;
            // 
            // Bai3
            // 
            Bai3.BackColor = SystemColors.ActiveCaption;
            Bai3.Location = new Point(573, 112);
            Bai3.Name = "Bai3";
            Bai3.Size = new Size(136, 59);
            Bai3.TabIndex = 2;
            Bai3.Text = "Bài 3";
            Bai3.UseVisualStyleBackColor = false;
            Bai3.Click += Bai3_Click;
            // 
            // Bai4
            // 
            Bai4.BackColor = SystemColors.ActiveCaption;
            Bai4.Location = new Point(147, 251);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(136, 59);
            Bai4.TabIndex = 3;
            Bai4.Text = "Bài 4";
            Bai4.UseVisualStyleBackColor = false;
            Bai4.Click += Bai4_Click;
            // 
            // Bai5
            // 
            Bai5.BackColor = SystemColors.ActiveCaption;
            Bai5.Location = new Point(357, 251);
            Bai5.Name = "Bai5";
            Bai5.Size = new Size(136, 59);
            Bai5.TabIndex = 4;
            Bai5.Text = "Bài 5";
            Bai5.UseVisualStyleBackColor = false;
            Bai5.Click += Bai5_Click;
            // 
            // Bai6
            // 
            Bai6.BackColor = SystemColors.ActiveCaption;
            Bai6.Location = new Point(573, 251);
            Bai6.Name = "Bai6";
            Bai6.Size = new Size(136, 59);
            Bai6.TabIndex = 5;
            Bai6.Text = "Bài 6";
            Bai6.UseVisualStyleBackColor = false;
            Bai6.Click += Bai6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bai6);
            Controls.Add(Bai5);
            Controls.Add(Bai4);
            Controls.Add(Bai3);
            Controls.Add(Bai2);
            Controls.Add(Bai1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Bai1;
        private Button Bai2;
        private Button Bai3;
        private Button Bai4;
        private Button Bai5;
        private Button Bai6;
    }
}