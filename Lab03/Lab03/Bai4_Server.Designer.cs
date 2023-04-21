
namespace Lab03
{
    partial class Bai4_Server
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
            this.listenBtn = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listenBtn
            // 
            this.listenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.listenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.listenBtn.FlatAppearance.BorderSize = 0;
            this.listenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenBtn.ForeColor = System.Drawing.Color.White;
            this.listenBtn.Location = new System.Drawing.Point(295, 21);
            this.listenBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(211, 49);
            this.listenBtn.TabIndex = 4;
            this.listenBtn.Text = "Start listening";
            this.listenBtn.UseVisualStyleBackColor = false;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.Control;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.Location = new System.Drawing.Point(35, 88);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(721, 350);
            this.chatBox.TabIndex = 5;
            // 
            // Bai4_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.listenBtn);
            this.Name = "Bai4_Server";
            this.Text = "Bai4_Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bai4_Server_FormClosed);
            this.Load += new System.EventHandler(this.Bai4_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.TextBox chatBox;
    }
}