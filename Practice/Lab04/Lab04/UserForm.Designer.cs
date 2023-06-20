namespace Lab04
{
    partial class UserForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Full_name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Full_name
            // 
            this.Full_name.AutoSize = true;
            this.Full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Full_name.Location = new System.Drawing.Point(28, 24);
            this.Full_name.Name = "Full_name";
            this.Full_name.Size = new System.Drawing.Size(94, 20);
            this.Full_name.TabIndex = 0;
            this.Full_name.Text = "Full Name";
            this.Full_name.Click += new System.EventHandler(this.Full_name_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Email.Location = new System.Drawing.Point(28, 78);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(51, 20);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // avatar
            // 
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.avatar.Location = new System.Drawing.Point(535, 13);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(103, 100);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Full_name);
            this.Name = "UserForm";
            this.Size = new System.Drawing.Size(717, 127);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Full_name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.PictureBox avatar;
    }
}
