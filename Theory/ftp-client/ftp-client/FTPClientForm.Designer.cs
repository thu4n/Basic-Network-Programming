namespace ftp_client
{
    partial class FTPClientForm
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
            this.FTPClientLB = new System.Windows.Forms.Label();
            this.IPServerLB = new System.Windows.Forms.Label();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.IPServerTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.fileListLV = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.fileDownloadTB = new System.Windows.Forms.TextBox();
            this.nameFileDownloadLB = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FTPClientLB
            // 
            this.FTPClientLB.AutoSize = true;
            this.FTPClientLB.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPClientLB.Location = new System.Drawing.Point(265, 7);
            this.FTPClientLB.Name = "FTPClientLB";
            this.FTPClientLB.Size = new System.Drawing.Size(129, 32);
            this.FTPClientLB.TabIndex = 0;
            this.FTPClientLB.Text = "FTP Client";
            // 
            // IPServerLB
            // 
            this.IPServerLB.AutoSize = true;
            this.IPServerLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPServerLB.Location = new System.Drawing.Point(36, 47);
            this.IPServerLB.Name = "IPServerLB";
            this.IPServerLB.Size = new System.Drawing.Size(111, 23);
            this.IPServerLB.TabIndex = 1;
            this.IPServerLB.Text = "IP FTP Server";
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.Location = new System.Drawing.Point(36, 86);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(88, 23);
            this.UsernameLB.TabIndex = 2;
            this.UsernameLB.Text = "Username";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLB.Location = new System.Drawing.Point(36, 126);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(82, 23);
            this.PasswordLB.TabIndex = 3;
            this.PasswordLB.Text = "Password";
            // 
            // IPServerTB
            // 
            this.IPServerTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.IPServerTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPServerTB.Location = new System.Drawing.Point(171, 45);
            this.IPServerTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPServerTB.Name = "IPServerTB";
            this.IPServerTB.Size = new System.Drawing.Size(267, 30);
            this.IPServerTB.TabIndex = 4;
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.UsernameTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(171, 86);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(267, 30);
            this.UsernameTB.TabIndex = 5;
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(171, 126);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(267, 30);
            this.PasswordTB.TabIndex = 6;
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.UploadBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.ForeColor = System.Drawing.Color.Crimson;
            this.UploadBtn.Location = new System.Drawing.Point(477, 92);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(182, 28);
            this.UploadBtn.TabIndex = 7;
            this.UploadBtn.Text = "UPLOAD FILE";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.DownloadBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.ForeColor = System.Drawing.Color.Crimson;
            this.DownloadBtn.Location = new System.Drawing.Point(477, 134);
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(182, 28);
            this.DownloadBtn.TabIndex = 8;
            this.DownloadBtn.Text = "DOWNLOAD FILE";
            this.DownloadBtn.UseVisualStyleBackColor = false;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // fileListLV
            // 
            this.fileListLV.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileListLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
            this.fileListLV.HideSelection = false;
            this.fileListLV.Location = new System.Drawing.Point(40, 230);
            this.fileListLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileListLV.Name = "fileListLV";
            this.fileListLV.Size = new System.Drawing.Size(603, 192);
            this.fileListLV.TabIndex = 9;
            this.fileListLV.UseCompatibleStateImageBehavior = false;
            this.fileListLV.View = System.Windows.Forms.View.Details;
            this.fileListLV.DoubleClick += new System.EventHandler(this.fileListLV_DoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileName.Width = 600;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.RefreshBtn.BackgroundImage = global::ftp_client.Properties.Resources.Refresh_icon;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.RefreshBtn.Location = new System.Drawing.Point(544, 174);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(46, 28);
            this.RefreshBtn.TabIndex = 10;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // fileDownloadTB
            // 
            this.fileDownloadTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileDownloadTB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileDownloadTB.Location = new System.Drawing.Point(171, 171);
            this.fileDownloadTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileDownloadTB.Name = "fileDownloadTB";
            this.fileDownloadTB.ReadOnly = true;
            this.fileDownloadTB.Size = new System.Drawing.Size(267, 30);
            this.fileDownloadTB.TabIndex = 13;
            // 
            // nameFileDownloadLB
            // 
            this.nameFileDownloadLB.AutoSize = true;
            this.nameFileDownloadLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFileDownloadLB.Location = new System.Drawing.Point(36, 171);
            this.nameFileDownloadLB.Name = "nameFileDownloadLB";
            this.nameFileDownloadLB.Size = new System.Drawing.Size(119, 23);
            this.nameFileDownloadLB.TabIndex = 12;
            this.nameFileDownloadLB.Text = "File download";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Crimson;
            this.loginBtn.Location = new System.Drawing.Point(477, 45);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(182, 28);
            this.loginBtn.TabIndex = 15;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // FTPClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1015, 475);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.fileDownloadTB);
            this.Controls.Add(this.nameFileDownloadLB);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.fileListLV);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.IPServerTB);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.UsernameLB);
            this.Controls.Add(this.IPServerLB);
            this.Controls.Add(this.FTPClientLB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FTPClientForm";
            this.Text = "FTPClientForm";
            this.Load += new System.EventHandler(this.FTPClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FTPClientLB;
        private System.Windows.Forms.Label IPServerLB;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox IPServerTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.ListView fileListLV;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.TextBox fileDownloadTB;
        private System.Windows.Forms.Label nameFileDownloadLB;
        private System.Windows.Forms.Button loginBtn;
    }
}