﻿
namespace Lab03
{
    partial class Bai4_Client_DM
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
            this.chatBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.titleLabel0 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.Control;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.Location = new System.Drawing.Point(46, 80);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(702, 363);
            this.chatBox.TabIndex = 8;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(46, 449);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(450, 49);
            this.textBox.TabIndex = 7;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(504, 448);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(104, 49);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // titleLabel0
            // 
            this.titleLabel0.AutoSize = true;
            this.titleLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel0.Location = new System.Drawing.Point(40, 44);
            this.titleLabel0.Name = "titleLabel0";
            this.titleLabel0.Size = new System.Drawing.Size(227, 32);
            this.titleLabel0.TabIndex = 13;
            this.titleLabel0.Text = "Chatting with ...";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(0, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            // 
            // SendFile
            // 
            this.SendFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.SendFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendFile.FlatAppearance.BorderSize = 0;
            this.SendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendFile.ForeColor = System.Drawing.Color.White;
            this.SendFile.Location = new System.Drawing.Point(616, 448);
            this.SendFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(132, 49);
            this.SendFile.TabIndex = 14;
            this.SendFile.Text = "SendFIle";
            this.SendFile.UseVisualStyleBackColor = false;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // Bai4_Client_DM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 539);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.titleLabel0);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.sendBtn);
            this.Name = "Bai4_Client_DM";
            this.Text = "Bai4_Client_DM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bai4_Client_DM_FormClosed);
            this.Load += new System.EventHandler(this.Bai4_Client_DM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label titleLabel0;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SendFile;
    }
}