namespace Lab03
{
    partial class Bai1_Client
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
            this.Ip_txt = new System.Windows.Forms.TextBox();
            this.Port_txt = new System.Windows.Forms.TextBox();
            this.Mess_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ip_txt
            // 
            this.Ip_txt.Location = new System.Drawing.Point(106, 115);
            this.Ip_txt.Name = "Ip_txt";
            this.Ip_txt.Size = new System.Drawing.Size(153, 22);
            this.Ip_txt.TabIndex = 0;
            // 
            // Port_txt
            // 
            this.Port_txt.Location = new System.Drawing.Point(533, 115);
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.Size = new System.Drawing.Size(164, 22);
            this.Port_txt.TabIndex = 1;
            // 
            // Mess_txt
            // 
            this.Mess_txt.Location = new System.Drawing.Point(106, 214);
            this.Mess_txt.Multiline = true;
            this.Mess_txt.Name = "Mess_txt";
            this.Mess_txt.Size = new System.Drawing.Size(591, 161);
            this.Mess_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ip Remote host";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(119, 403);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 6;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // Bai1_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mess_txt);
            this.Controls.Add(this.Port_txt);
            this.Controls.Add(this.Ip_txt);
            this.Name = "Bai1_Client";
            this.Text = "Bai1_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ip_txt;
        private System.Windows.Forms.TextBox Port_txt;
        private System.Windows.Forms.TextBox Mess_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sendbtn;
    }
}