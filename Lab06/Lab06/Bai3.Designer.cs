namespace Lab06
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LAB06 - BAI03";
            // 
            // serverBtn
            // 
            this.serverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverBtn.Location = new System.Drawing.Point(197, 106);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(164, 41);
            this.serverBtn.TabIndex = 1;
            this.serverBtn.Text = "Server";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBtn.Location = new System.Drawing.Point(197, 165);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(164, 41);
            this.clientBtn.TabIndex = 2;
            this.clientBtn.Text = "Client";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.serverBtn);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button clientBtn;
    }
}