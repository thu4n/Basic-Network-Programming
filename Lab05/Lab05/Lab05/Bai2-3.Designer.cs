namespace Lab05
{
    partial class Bai2_3
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
            this.User_txt = new System.Windows.Forms.TextBox();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.User_lb = new System.Windows.Forms.Label();
            this.Pass_lb = new System.Windows.Forms.Label();
            this.IMAP_btn = new System.Windows.Forms.Button();
            this.POP_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(97, 48);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(239, 22);
            this.User_txt.TabIndex = 0;
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(97, 94);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(239, 22);
            this.Pass_txt.TabIndex = 1;
            // 
            // User_lb
            // 
            this.User_lb.AutoSize = true;
            this.User_lb.Location = new System.Drawing.Point(12, 48);
            this.User_lb.Name = "User_lb";
            this.User_lb.Size = new System.Drawing.Size(76, 16);
            this.User_lb.TabIndex = 2;
            this.User_lb.Text = "User Name";
            // 
            // Pass_lb
            // 
            this.Pass_lb.AutoSize = true;
            this.Pass_lb.Location = new System.Drawing.Point(12, 100);
            this.Pass_lb.Name = "Pass_lb";
            this.Pass_lb.Size = new System.Drawing.Size(67, 16);
            this.Pass_lb.TabIndex = 3;
            this.Pass_lb.Text = "Password";
            // 
            // IMAP_btn
            // 
            this.IMAP_btn.Location = new System.Drawing.Point(389, 80);
            this.IMAP_btn.Name = "IMAP_btn";
            this.IMAP_btn.Size = new System.Drawing.Size(131, 36);
            this.IMAP_btn.TabIndex = 4;
            this.IMAP_btn.Text = "Read with IMAP";
            this.IMAP_btn.UseVisualStyleBackColor = true;
            this.IMAP_btn.Click += new System.EventHandler(this.IMAP_btn_Click);
            // 
            // POP_btn
            // 
            this.POP_btn.Location = new System.Drawing.Point(567, 80);
            this.POP_btn.Name = "POP_btn";
            this.POP_btn.Size = new System.Drawing.Size(131, 36);
            this.POP_btn.TabIndex = 5;
            this.POP_btn.Text = "Read with POP";
            this.POP_btn.UseVisualStyleBackColor = true;
            this.POP_btn.Click += new System.EventHandler(this.POP_btn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 283);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Bai2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.POP_btn);
            this.Controls.Add(this.IMAP_btn);
            this.Controls.Add(this.Pass_lb);
            this.Controls.Add(this.User_lb);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.User_txt);
            this.Name = "Bai2_3";
            this.Text = "Bai2_3";
            this.Load += new System.EventHandler(this.Bai2_3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User_txt;
        private System.Windows.Forms.TextBox Pass_txt;
        private System.Windows.Forms.Label User_lb;
        private System.Windows.Forms.Label Pass_lb;
        private System.Windows.Forms.Button IMAP_btn;
        private System.Windows.Forms.Button POP_btn;
        private System.Windows.Forms.ListView listView1;
    }
}