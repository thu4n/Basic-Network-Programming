
namespace Lab03
{
    partial class Bai4_Client
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.titleLabel0 = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SendFile = new System.Windows.Forms.Button();
            this.File_Receive = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExitFile = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(744, 508);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(113, 49);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(46, 508);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(690, 49);
            this.textBox.TabIndex = 4;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.Control;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.Location = new System.Drawing.Point(46, 128);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(690, 373);
            this.chatBox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(40, 85);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(117, 25);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(152, 87);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(169, 23);
            this.usernameTB.TabIndex = 8;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.connectBtn.FlatAppearance.BorderSize = 0;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(328, 85);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(118, 25);
            this.connectBtn.TabIndex = 11;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // titleLabel0
            // 
            this.titleLabel0.AutoSize = true;
            this.titleLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel0.Location = new System.Drawing.Point(39, 37);
            this.titleLabel0.Name = "titleLabel0";
            this.titleLabel0.Size = new System.Drawing.Size(497, 32);
            this.titleLabel0.TabIndex = 12;
            this.titleLabel0.Text = "You are not connected to the server";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(744, 100);
            this.usersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(131, 25);
            this.usersLabel.TabIndex = 13;
            this.usersLabel.Text = "Active users";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(743, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 162);
            this.listBox1.TabIndex = 14;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // SendFile
            // 
            this.SendFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.SendFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendFile.FlatAppearance.BorderSize = 0;
            this.SendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendFile.ForeColor = System.Drawing.Color.White;
            this.SendFile.Location = new System.Drawing.Point(865, 508);
            this.SendFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(123, 49);
            this.SendFile.TabIndex = 15;
            this.SendFile.Text = "Send file";
            this.SendFile.UseVisualStyleBackColor = false;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // File_Receive
            // 
            this.File_Receive.AutoSize = true;
            this.File_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Receive.Location = new System.Drawing.Point(744, 293);
            this.File_Receive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.File_Receive.Name = "File_Receive";
            this.File_Receive.Size = new System.Drawing.Size(130, 25);
            this.File_Receive.TabIndex = 16;
            this.File_Receive.Text = "File Receive";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(743, 321);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(244, 180);
            this.listBox2.TabIndex = 1;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 373);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(46, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(690, 374);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // ExitFile
            // 
            this.ExitFile.BackColor = System.Drawing.Color.Red;
            this.ExitFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitFile.FlatAppearance.BorderSize = 0;
            this.ExitFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitFile.ForeColor = System.Drawing.Color.White;
            this.ExitFile.Location = new System.Drawing.Point(703, 97);
            this.ExitFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitFile.Name = "ExitFile";
            this.ExitFile.Size = new System.Drawing.Size(33, 31);
            this.ExitFile.TabIndex = 20;
            this.ExitFile.Text = "X";
            this.ExitFile.UseVisualStyleBackColor = false;
            this.ExitFile.Visible = false;
            this.ExitFile.Click += new System.EventHandler(this.ExitFile_Click);
            // 
            // ipTB
            // 
            this.ipTB.BackColor = System.Drawing.SystemColors.Control;
            this.ipTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTB.Location = new System.Drawing.Point(542, 43);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(169, 23);
            this.ipTB.TabIndex = 21;
            // 
            // Bai4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 577);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.ExitFile);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.File_Receive);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.titleLabel0);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai4_Client";
            this.Text = "Bai4_Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bai4_Client_FormClosed);
            this.Load += new System.EventHandler(this.Bai4_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label titleLabel0;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.Label File_Receive;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ExitFile;
        private System.Windows.Forms.TextBox ipTB;
    }
}