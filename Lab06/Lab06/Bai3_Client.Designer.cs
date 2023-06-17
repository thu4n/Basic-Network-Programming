namespace Lab06
{
    partial class Bai3_Client
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.pubKeyTB = new System.Windows.Forms.TextBox();
            this.pubKeyLabel = new System.Windows.Forms.Label();
            this.shareBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(23, 25);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(172, 20);
            this.ipLabel.TabIndex = 4;
            this.ipLabel.Text = "Địa chỉ IP của Server:";
            // 
            // ipTB
            // 
            this.ipTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTB.Location = new System.Drawing.Point(201, 22);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(206, 27);
            this.ipTB.TabIndex = 3;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(658, 16);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(130, 41);
            this.connectBtn.TabIndex = 5;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.White;
            this.chatBox.Location = new System.Drawing.Point(27, 63);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(536, 356);
            this.chatBox.TabIndex = 6;
            // 
            // typeTB
            // 
            this.typeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTB.Location = new System.Drawing.Point(27, 436);
            this.typeTB.Multiline = true;
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(412, 49);
            this.typeTB.TabIndex = 7;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(445, 436);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(118, 49);
            this.sendBtn.TabIndex = 8;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(413, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(510, 22);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(142, 27);
            this.usernameTB.TabIndex = 10;
            // 
            // pubKeyTB
            // 
            this.pubKeyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubKeyTB.Location = new System.Drawing.Point(569, 86);
            this.pubKeyTB.Multiline = true;
            this.pubKeyTB.Name = "pubKeyTB";
            this.pubKeyTB.ReadOnly = true;
            this.pubKeyTB.Size = new System.Drawing.Size(219, 273);
            this.pubKeyTB.TabIndex = 12;
            // 
            // pubKeyLabel
            // 
            this.pubKeyLabel.AutoSize = true;
            this.pubKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pubKeyLabel.Location = new System.Drawing.Point(569, 63);
            this.pubKeyLabel.Name = "pubKeyLabel";
            this.pubKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.pubKeyLabel.TabIndex = 11;
            this.pubKeyLabel.Text = "Public key";
            // 
            // shareBtn
            // 
            this.shareBtn.BackColor = System.Drawing.Color.White;
            this.shareBtn.Enabled = false;
            this.shareBtn.Location = new System.Drawing.Point(569, 365);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(219, 49);
            this.shareBtn.TabIndex = 13;
            this.shareBtn.Text = "Share public key";
            this.shareBtn.UseVisualStyleBackColor = false;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(569, 425);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(217, 60);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "Đây là phòng chat bảo mật, \r\nhãy chia sẻ public key của \r\nmình trước khi chat.\r\n";
            // 
            // Bai3_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.shareBtn);
            this.Controls.Add(this.pubKeyTB);
            this.Controls.Add(this.pubKeyLabel);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipTB);
            this.Name = "Bai3_Client";
            this.Text = "Bai3_Client";
            this.Load += new System.EventHandler(this.Bai3_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox pubKeyTB;
        private System.Windows.Forms.Label pubKeyLabel;
        private System.Windows.Forms.Button shareBtn;
        private System.Windows.Forms.Label infoLabel;
    }
}