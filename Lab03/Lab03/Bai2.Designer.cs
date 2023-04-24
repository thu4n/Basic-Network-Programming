
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
            this.Listen_btn = new System.Windows.Forms.Button();
            this.Mess_txt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Listen_btn
            // 
            this.Listen_btn.Location = new System.Drawing.Point(611, 50);
            this.Listen_btn.Name = "Listen_btn";
            this.Listen_btn.Size = new System.Drawing.Size(99, 45);
            this.Listen_btn.TabIndex = 1;
            this.Listen_btn.Text = "Listen";
            this.Listen_btn.UseVisualStyleBackColor = true;
            this.Listen_btn.Click += new System.EventHandler(this.Listen_btn_Click);
            // 
            // Mess_txt
            // 
            this.Mess_txt.Location = new System.Drawing.Point(76, 118);
            this.Mess_txt.Name = "Mess_txt";
            this.Mess_txt.ReadOnly = true;
            this.Mess_txt.Size = new System.Drawing.Size(675, 298);
            this.Mess_txt.TabIndex = 2;
            this.Mess_txt.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mess_txt);
            this.Controls.Add(this.Listen_btn);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Listen_btn;
        private System.Windows.Forms.RichTextBox Mess_txt;
    }
}