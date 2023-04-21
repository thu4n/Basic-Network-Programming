
namespace Lab03
{
    partial class Bai2
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
            this.lst_mess = new System.Windows.Forms.ListView();
            this.Listen_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_mess
            // 
            this.lst_mess.HideSelection = false;
            this.lst_mess.Location = new System.Drawing.Point(84, 137);
            this.lst_mess.Name = "lst_mess";
            this.lst_mess.Size = new System.Drawing.Size(659, 280);
            this.lst_mess.TabIndex = 0;
            this.lst_mess.UseCompatibleStateImageBehavior = false;
            // 
            // Listen_btn
            // 
            this.Listen_btn.Location = new System.Drawing.Point(581, 75);
            this.Listen_btn.Name = "Listen_btn";
            this.Listen_btn.Size = new System.Drawing.Size(75, 23);
            this.Listen_btn.TabIndex = 1;
            this.Listen_btn.Text = "Listen";
            this.Listen_btn.UseVisualStyleBackColor = true;
            this.Listen_btn.Click += new System.EventHandler(this.Listen_btn_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listen_btn);
            this.Controls.Add(this.lst_mess);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_mess;
        private System.Windows.Forms.Button Listen_btn;
    }
}