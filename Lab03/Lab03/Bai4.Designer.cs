
namespace Lab03
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
            this.serverBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverBtn
            // 
            this.serverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.serverBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.serverBtn.FlatAppearance.BorderSize = 0;
            this.serverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverBtn.ForeColor = System.Drawing.Color.White;
            this.serverBtn.Location = new System.Drawing.Point(177, 104);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(169, 46);
            this.serverBtn.TabIndex = 2;
            this.serverBtn.Text = "I\'m a Server";
            this.serverBtn.UseVisualStyleBackColor = false;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.clientBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clientBtn.FlatAppearance.BorderSize = 0;
            this.clientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBtn.ForeColor = System.Drawing.Color.White;
            this.clientBtn.Location = new System.Drawing.Point(177, 177);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(169, 46);
            this.clientBtn.TabIndex = 3;
            this.clientBtn.Text = "I\'m a Client";
            this.clientBtn.UseVisualStyleBackColor = false;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 327);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.serverBtn);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button clientBtn;
    }
}