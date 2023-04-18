
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
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.titleLabel0 = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.sendBtn.Size = new System.Drawing.Size(211, 49);
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
            this.chatBox.Location = new System.Drawing.Point(46, 138);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(690, 363);
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
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(272, 28);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(301, 32);
            this.titleLabel1.TabIndex = 9;
            this.titleLabel1.Text = "You are chatting with";
            this.titleLabel1.Visible = false;
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.titleLabel2.Location = new System.Drawing.Point(569, 28);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(159, 32);
            this.titleLabel2.TabIndex = 10;
            this.titleLabel2.Text = "titleLabel2";
            this.titleLabel2.Visible = false;
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
            this.titleLabel0.Location = new System.Drawing.Point(251, 28);
            this.titleLabel0.Name = "titleLabel0";
            this.titleLabel0.Size = new System.Drawing.Size(498, 32);
            this.titleLabel0.TabIndex = 12;
            this.titleLabel0.Text = "You are not connected to the server";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(739, 110);
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
            this.listBox1.Location = new System.Drawing.Point(744, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 360);
            this.listBox1.TabIndex = 14;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Bai4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 577);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.titleLabel0);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.sendBtn);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai4_Client";
            this.Text = "Bai4_Client";
            this.Load += new System.EventHandler(this.Bai4_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label titleLabel0;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}