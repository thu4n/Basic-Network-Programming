namespace Lab05
{
    partial class Bai4
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.configLabel = new System.Windows.Forms.Label();
            this.imapLabel = new System.Windows.Forms.Label();
            this.portLabel1 = new System.Windows.Forms.Label();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.portLabel2 = new System.Windows.Forms.Label();
            this.imapPortNum = new System.Windows.Forms.NumericUpDown();
            this.smtpPortNum = new System.Windows.Forms.NumericUpDown();
            this.imapTB = new System.Windows.Forms.TextBox();
            this.smtpTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imapPortNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(27, 24);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(138, 29);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Đăng nhập";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(28, 109);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(28, 70);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(90, 20);
            this.accountLabel.TabIndex = 2;
            this.accountLabel.Text = "Tài khoản";
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(124, 67);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(238, 27);
            this.emailTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(124, 109);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(238, 27);
            this.passwordTB.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(255, 156);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(107, 37);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.Location = new System.Drawing.Point(399, 24);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(95, 29);
            this.configLabel.TabIndex = 6;
            this.configLabel.Text = "Cài đặt";
            // 
            // imapLabel
            // 
            this.imapLabel.AutoSize = true;
            this.imapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imapLabel.Location = new System.Drawing.Point(404, 70);
            this.imapLabel.Name = "imapLabel";
            this.imapLabel.Size = new System.Drawing.Size(53, 20);
            this.imapLabel.TabIndex = 7;
            this.imapLabel.Text = "IMAP";
            // 
            // portLabel1
            // 
            this.portLabel1.AutoSize = true;
            this.portLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel1.Location = new System.Drawing.Point(404, 116);
            this.portLabel1.Name = "portLabel1";
            this.portLabel1.Size = new System.Drawing.Size(44, 20);
            this.portLabel1.TabIndex = 8;
            this.portLabel1.Text = "Port";
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtpLabel.Location = new System.Drawing.Point(648, 70);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(59, 20);
            this.smtpLabel.TabIndex = 9;
            this.smtpLabel.Text = "SMTP";
            // 
            // portLabel2
            // 
            this.portLabel2.AutoSize = true;
            this.portLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel2.Location = new System.Drawing.Point(648, 116);
            this.portLabel2.Name = "portLabel2";
            this.portLabel2.Size = new System.Drawing.Size(44, 20);
            this.portLabel2.TabIndex = 10;
            this.portLabel2.Text = "Port";
            // 
            // imapPortNum
            // 
            this.imapPortNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imapPortNum.Location = new System.Drawing.Point(464, 110);
            this.imapPortNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.imapPortNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imapPortNum.Name = "imapPortNum";
            this.imapPortNum.Size = new System.Drawing.Size(166, 27);
            this.imapPortNum.TabIndex = 11;
            this.imapPortNum.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // smtpPortNum
            // 
            this.smtpPortNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtpPortNum.Location = new System.Drawing.Point(713, 110);
            this.smtpPortNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.smtpPortNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smtpPortNum.Name = "smtpPortNum";
            this.smtpPortNum.Size = new System.Drawing.Size(166, 27);
            this.smtpPortNum.TabIndex = 12;
            this.smtpPortNum.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // imapTB
            // 
            this.imapTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imapTB.Location = new System.Drawing.Point(464, 67);
            this.imapTB.Name = "imapTB";
            this.imapTB.Size = new System.Drawing.Size(166, 27);
            this.imapTB.TabIndex = 13;
            this.imapTB.Text = "imap.gmail.com";
            // 
            // smtpTB
            // 
            this.smtpTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtpTB.Location = new System.Drawing.Point(713, 67);
            this.smtpTB.Name = "smtpTB";
            this.smtpTB.Size = new System.Drawing.Size(166, 27);
            this.smtpTB.TabIndex = 14;
            this.smtpTB.Text = "smtp.gmail.com";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttCol,
            this.fromCol,
            this.subjectCol,
            this.dateCol});
            this.dataGridView1.Location = new System.Drawing.Point(32, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 424);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // sttCol
            // 
            this.sttCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sttCol.HeaderText = "#";
            this.sttCol.MinimumWidth = 6;
            this.sttCol.Name = "sttCol";
            this.sttCol.Width = 43;
            // 
            // fromCol
            // 
            this.fromCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fromCol.HeaderText = "From";
            this.fromCol.MinimumWidth = 6;
            this.fromCol.Name = "fromCol";
            // 
            // subjectCol
            // 
            this.subjectCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectCol.HeaderText = "Subject";
            this.subjectCol.MinimumWidth = 6;
            this.subjectCol.Name = "subjectCol";
            // 
            // dateCol
            // 
            this.dateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCol.HeaderText = "Datetime";
            this.dateCol.MinimumWidth = 6;
            this.dateCol.Name = "dateCol";
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(32, 156);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(107, 37);
            this.sendBtn.TabIndex = 16;
            this.sendBtn.Text = "Gửi mail";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Visible = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(142, 156);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(107, 37);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Visible = false;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 646);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.smtpTB);
            this.Controls.Add(this.imapTB);
            this.Controls.Add(this.smtpPortNum);
            this.Controls.Add(this.imapPortNum);
            this.Controls.Add(this.portLabel2);
            this.Controls.Add(this.smtpLabel);
            this.Controls.Add(this.portLabel1);
            this.Controls.Add(this.imapLabel);
            this.Controls.Add(this.configLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "Bai4";
            this.Text = "Bai4";
            ((System.ComponentModel.ISupportInitialize)(this.imapPortNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Label imapLabel;
        private System.Windows.Forms.Label portLabel1;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.Label portLabel2;
        private System.Windows.Forms.NumericUpDown imapPortNum;
        private System.Windows.Forms.NumericUpDown smtpPortNum;
        private System.Windows.Forms.TextBox imapTB;
        private System.Windows.Forms.TextBox smtpTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}