
namespace Lab03
{
    partial class Bai3
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
            this.TCP_Client = new System.Windows.Forms.Button();
            this.TCP_Server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCP_Client
            // 
            this.TCP_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.TCP_Client.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TCP_Client.FlatAppearance.BorderSize = 0;
            this.TCP_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TCP_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP_Client.ForeColor = System.Drawing.Color.White;
            this.TCP_Client.Location = new System.Drawing.Point(147, 215);
            this.TCP_Client.Name = "TCP_Client";
            this.TCP_Client.Size = new System.Drawing.Size(169, 46);
            this.TCP_Client.TabIndex = 2;
            this.TCP_Client.Text = "TCP Client";
            this.TCP_Client.UseVisualStyleBackColor = false;
            this.TCP_Client.Click += new System.EventHandler(this.TCP_Client_Click);
            // 
            // TCP_Server
            // 
            this.TCP_Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.TCP_Server.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TCP_Server.FlatAppearance.BorderSize = 0;
            this.TCP_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TCP_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP_Server.ForeColor = System.Drawing.Color.White;
            this.TCP_Server.Location = new System.Drawing.Point(471, 215);
            this.TCP_Server.Name = "TCP_Server";
            this.TCP_Server.Size = new System.Drawing.Size(169, 46);
            this.TCP_Server.TabIndex = 3;
            this.TCP_Server.Text = "TCP Server";
            this.TCP_Server.UseVisualStyleBackColor = false;
            this.TCP_Server.Click += new System.EventHandler(this.TCP_Server_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCP_Server);
            this.Controls.Add(this.TCP_Client);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TCP_Client;
        private System.Windows.Forms.Button TCP_Server;
    }
}