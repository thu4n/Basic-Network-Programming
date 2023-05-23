namespace Lab04
{
    partial class Bai_4
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Previous = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Page = new System.Windows.Forms.Label();
            this.UserPpage = new System.Windows.Forms.Label();
            this.TotalPage = new System.Windows.Forms.Label();
            this.TotalUser = new System.Windows.Forms.Label();
            this.UserList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(40, 405);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(724, 27);
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 250);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.Location = new System.Drawing.Point(440, 76);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(108, 29);
            this.Previous.TabIndex = 4;
            this.Previous.Text = "<<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Forward
            // 
            this.Forward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Forward.Location = new System.Drawing.Point(661, 76);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(103, 29);
            this.Forward.TabIndex = 5;
            this.Forward.Text = ">>";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Page
            // 
            this.Page.AutoSize = true;
            this.Page.Location = new System.Drawing.Point(43, 20);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(40, 16);
            this.Page.TabIndex = 6;
            this.Page.Text = "Page";
            // 
            // UserPpage
            // 
            this.UserPpage.AutoSize = true;
            this.UserPpage.Location = new System.Drawing.Point(43, 76);
            this.UserPpage.Name = "UserPpage";
            this.UserPpage.Size = new System.Drawing.Size(73, 16);
            this.UserPpage.TabIndex = 7;
            this.UserPpage.Text = "User/Page";
            // 
            // TotalPage
            // 
            this.TotalPage.AutoSize = true;
            this.TotalPage.Location = new System.Drawing.Point(230, 20);
            this.TotalPage.Name = "TotalPage";
            this.TotalPage.Size = new System.Drawing.Size(73, 16);
            this.TotalPage.TabIndex = 8;
            this.TotalPage.Text = "Total page";
            // 
            // TotalUser
            // 
            this.TotalUser.AutoSize = true;
            this.TotalUser.Location = new System.Drawing.Point(230, 76);
            this.TotalUser.Name = "TotalUser";
            this.TotalUser.Size = new System.Drawing.Size(70, 16);
            this.TotalUser.TabIndex = 9;
            this.TotalUser.Text = "Total User";
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserList.AutoSize = true;
            this.UserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UserList.Location = new System.Drawing.Point(570, 82);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(68, 16);
            this.UserList.TabIndex = 10;
            this.UserList.Text = "User List";
            // 
            // Bai_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.TotalUser);
            this.Controls.Add(this.TotalPage);
            this.Controls.Add(this.UserPpage);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ProgressBar);
            this.Name = "Bai_4";
            this.Text = "Bài_4";
            this.Load += new System.EventHandler(this.Bài_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label Page;
        private System.Windows.Forms.Label UserPpage;
        private System.Windows.Forms.Label TotalPage;
        private System.Windows.Forms.Label TotalUser;
        private System.Windows.Forms.Label UserList;
    }
}