namespace Lab03
{
    partial class Bai1_Server
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
            this.Port_txt = new System.Windows.Forms.TextBox();
            this.Received_Mess = new System.Windows.Forms.TextBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Port_txt
            // 
            this.Port_txt.Location = new System.Drawing.Point(157, 107);
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.Size = new System.Drawing.Size(123, 22);
            this.Port_txt.TabIndex = 0;
            // 
            // Received_Mess
            // 
            this.Received_Mess.Location = new System.Drawing.Point(117, 187);
            this.Received_Mess.Multiline = true;
            this.Received_Mess.Name = "Received_Mess";
            this.Received_Mess.ReadOnly = true;
            this.Received_Mess.Size = new System.Drawing.Size(553, 220);
            this.Received_Mess.TabIndex = 1;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(565, 107);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(84, 23);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received Message";
            // 
            // Bai1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.Received_Mess);
            this.Controls.Add(this.Port_txt);
            this.Name = "Bai1_Server";
            this.Text = "Bai1_Server";
            this.Load += new System.EventHandler(this.Bai1_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Port_txt;
        private System.Windows.Forms.TextBox Received_Mess;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}