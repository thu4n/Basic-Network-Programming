
namespace Lab03
{
    partial class Bai1
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
            this.Udp_C = new System.Windows.Forms.Button();
            this.Udp_S = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Udp_C
            // 
            this.Udp_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.Udp_C.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Udp_C.FlatAppearance.BorderSize = 0;
            this.Udp_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Udp_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Udp_C.ForeColor = System.Drawing.Color.White;
            this.Udp_C.Location = new System.Drawing.Point(157, 192);
            this.Udp_C.Name = "Udp_C";
            this.Udp_C.Size = new System.Drawing.Size(169, 46);
            this.Udp_C.TabIndex = 1;
            this.Udp_C.Text = "Udp Client";
            this.Udp_C.UseVisualStyleBackColor = false;
            this.Udp_C.Click += new System.EventHandler(this.Udp_C_Click);
            // 
            // Udp_S
            // 
            this.Udp_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.Udp_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Udp_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Udp_S.ForeColor = System.Drawing.Color.White;
            this.Udp_S.Location = new System.Drawing.Point(467, 192);
            this.Udp_S.Name = "Udp_S";
            this.Udp_S.Size = new System.Drawing.Size(164, 46);
            this.Udp_S.TabIndex = 2;
            this.Udp_S.Text = "Udp Server";
            this.Udp_S.UseVisualStyleBackColor = false;
            this.Udp_S.Click += new System.EventHandler(this.Udp_S_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Udp_S);
            this.Controls.Add(this.Udp_C);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Udp_C;
        private System.Windows.Forms.Button Udp_S;
    }
}