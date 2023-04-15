namespace week5
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.sendBtn = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.serverIPTB = new System.Windows.Forms.TextBox();
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.sendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(152)))), ((int)(((byte)(251)))));
            this.sendBtn.Location = new System.Drawing.Point(561, 525);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(135, 53);
            this.sendBtn.TabIndex = 19;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.typeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.ForeColor = System.Drawing.Color.White;
            this.typeBox.Location = new System.Drawing.Point(107, 525);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(430, 53);
            this.typeBox.TabIndex = 18;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.ForeColor = System.Drawing.Color.White;
            this.chatBox.Location = new System.Drawing.Point(107, 135);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(589, 366);
            this.chatBox.TabIndex = 17;
            // 
            // connectBtn
            // 
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.connectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(152)))), ((int)(((byte)(251)))));
            this.connectBtn.Location = new System.Drawing.Point(561, 46);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(135, 43);
            this.connectBtn.TabIndex = 16;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.ForeColor = System.Drawing.Color.White;
            this.usernameTB.Location = new System.Drawing.Point(327, 76);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(195, 34);
            this.usernameTB.TabIndex = 15;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.usernameLabel.Location = new System.Drawing.Point(102, 76);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(186, 27);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Your username:";
            // 
            // serverIPTB
            // 
            this.serverIPTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(49)))), ((int)(((byte)(86)))));
            this.serverIPTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverIPTB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIPTB.ForeColor = System.Drawing.Color.White;
            this.serverIPTB.Location = new System.Drawing.Point(327, 22);
            this.serverIPTB.Name = "serverIPTB";
            this.serverIPTB.Size = new System.Drawing.Size(195, 34);
            this.serverIPTB.TabIndex = 13;
            this.serverIPTB.Text = "127.0.0.5";
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.serverIPLabel.Location = new System.Drawing.Point(102, 23);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(221, 27);
            this.serverIPLabel.TabIndex = 12;
            this.serverIPLabel.Text = "Server IP Address: ";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(775, 588);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serverIPTB);
            this.Controls.Add(this.serverIPLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox serverIPTB;
        private System.Windows.Forms.Label serverIPLabel;
    }
}