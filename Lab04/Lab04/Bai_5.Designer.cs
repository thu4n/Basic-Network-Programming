namespace Lab04
{
    partial class Bai5
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
            this.postBtn = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(481, 99);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(75, 23);
            this.postBtn.TabIndex = 1;
            this.postBtn.Text = "Post";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(72, 48);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(34, 16);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(153, 42);
            this.urlTB.Name = "urlTB";
            this.urlTB.ReadOnly = true;
            this.urlTB.Size = new System.Drawing.Size(403, 22);
            this.urlTB.TabIndex = 3;
            this.urlTB.Text = "https://reqres.in/api/register";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(72, 85);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(72, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(153, 82);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = true;
            this.usernameTB.Size = new System.Drawing.Size(314, 22);
            this.usernameTB.TabIndex = 6;
            this.usernameTB.Text = "eve.holt@reqres.in";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(153, 119);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(314, 22);
            this.passwordTB.TabIndex = 7;
            this.passwordTB.Text = "pistol";
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(75, 160);
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.Size = new System.Drawing.Size(481, 22);
            this.resultTB.TabIndex = 8;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.postBtn);
            this.Name = "Bai5";
            this.Text = "Bài_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button postBtn;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox resultTB;
    }
}