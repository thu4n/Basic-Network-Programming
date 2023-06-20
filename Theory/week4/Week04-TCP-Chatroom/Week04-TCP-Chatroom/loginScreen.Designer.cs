
namespace Week04_TCP_Chatroom
{
    partial class loginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.clientBtn = new System.Windows.Forms.Button();
            this.serverBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientBtn
            // 
            this.clientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.clientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.clientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBtn.Location = new System.Drawing.Point(185, 165);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(135, 43);
            this.clientBtn.TabIndex = 0;
            this.clientBtn.Text = "Client";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // serverBtn
            // 
            this.serverBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.serverBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.serverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverBtn.Location = new System.Drawing.Point(381, 165);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(135, 43);
            this.serverBtn.TabIndex = 1;
            this.serverBtn.Text = "Server";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.titleLabel.Location = new System.Drawing.Point(38, 107);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(625, 35);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Welcome to TCP Chat Room, who are you?";
            // 
            // subtextLabel
            // 
            this.subtextLabel.AutoSize = true;
            this.subtextLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.subtextLabel.Location = new System.Drawing.Point(332, 168);
            this.subtextLabel.Name = "subtextLabel";
            this.subtextLabel.Size = new System.Drawing.Size(43, 33);
            this.subtextLabel.TabIndex = 3;
            this.subtextLabel.Text = "or";
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(700, 315);
            this.Controls.Add(this.subtextLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.serverBtn);
            this.Controls.Add(this.clientBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(152)))), ((int)(((byte)(251)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginScreen";
            this.Text = "TCP Chat Room - Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtextLabel;
    }
}

