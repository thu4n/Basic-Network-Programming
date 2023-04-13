
namespace Lab03
{
    partial class MenuForm
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
            this.bai1Btn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bai3Btn = new System.Windows.Forms.Button();
            this.bai2Btn = new System.Windows.Forms.Button();
            this.bai4Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1Btn
            // 
            this.bai1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.bai1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bai1Btn.FlatAppearance.BorderSize = 0;
            this.bai1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai1Btn.ForeColor = System.Drawing.Color.White;
            this.bai1Btn.Location = new System.Drawing.Point(143, 157);
            this.bai1Btn.Name = "bai1Btn";
            this.bai1Btn.Size = new System.Drawing.Size(135, 46);
            this.bai1Btn.TabIndex = 0;
            this.bai1Btn.Text = "Bài 1";
            this.bai1Btn.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(179, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 51);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Lab03 - Menu";
            // 
            // bai3Btn
            // 
            this.bai3Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.bai3Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bai3Btn.FlatAppearance.BorderSize = 0;
            this.bai3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai3Btn.ForeColor = System.Drawing.Color.White;
            this.bai3Btn.Location = new System.Drawing.Point(143, 229);
            this.bai3Btn.Name = "bai3Btn";
            this.bai3Btn.Size = new System.Drawing.Size(135, 46);
            this.bai3Btn.TabIndex = 2;
            this.bai3Btn.Text = "Bài 3";
            this.bai3Btn.UseVisualStyleBackColor = false;
            // 
            // bai2Btn
            // 
            this.bai2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.bai2Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bai2Btn.FlatAppearance.BorderSize = 0;
            this.bai2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai2Btn.ForeColor = System.Drawing.Color.White;
            this.bai2Btn.Location = new System.Drawing.Point(347, 157);
            this.bai2Btn.Name = "bai2Btn";
            this.bai2Btn.Size = new System.Drawing.Size(135, 46);
            this.bai2Btn.TabIndex = 3;
            this.bai2Btn.Text = "Bài 2";
            this.bai2Btn.UseVisualStyleBackColor = false;
            // 
            // bai4Btn
            // 
            this.bai4Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.bai4Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bai4Btn.FlatAppearance.BorderSize = 0;
            this.bai4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai4Btn.ForeColor = System.Drawing.Color.White;
            this.bai4Btn.Location = new System.Drawing.Point(347, 229);
            this.bai4Btn.Name = "bai4Btn";
            this.bai4Btn.Size = new System.Drawing.Size(135, 46);
            this.bai4Btn.TabIndex = 4;
            this.bai4Btn.Text = "Bài 4";
            this.bai4Btn.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 353);
            this.Controls.Add(this.bai4Btn);
            this.Controls.Add(this.bai2Btn);
            this.Controls.Add(this.bai3Btn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bai1Btn);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bai1Btn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button bai3Btn;
        private System.Windows.Forms.Button bai2Btn;
        private System.Windows.Forms.Button bai4Btn;
    }
}

