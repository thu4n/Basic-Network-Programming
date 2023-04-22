namespace Lab03
{
    partial class Bai3_TCP_Server
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
            this.btn_Listen = new System.Windows.Forms.Button();
            this.lst_mess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(644, 40);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(113, 32);
            this.btn_Listen.TabIndex = 0;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // lst_mess
            // 
            this.lst_mess.FormattingEnabled = true;
            this.lst_mess.ItemHeight = 16;
            this.lst_mess.Location = new System.Drawing.Point(35, 106);
            this.lst_mess.Name = "lst_mess";
            this.lst_mess.Size = new System.Drawing.Size(722, 308);
            this.lst_mess.TabIndex = 1;
            // 
            // Bai3_TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_mess);
            this.Controls.Add(this.btn_Listen);
            this.Name = "Bai3_TCP_Server";
            this.Text = "Bai3_TCP_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ListBox lst_mess;
    }
}