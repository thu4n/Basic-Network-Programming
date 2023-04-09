
namespace ThucHanhTuan02
{
    partial class Bai05
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
            this.readBtn = new System.Windows.Forms.Button();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.compressBtn = new System.Windows.Forms.Button();
            this.decompressBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readBtn
            // 
            this.readBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.readBtn.Location = new System.Drawing.Point(180, 120);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(107, 27);
            this.readBtn.TabIndex = 2;
            this.readBtn.Text = "Đọc File";
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // fileNameTB
            // 
            this.fileNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTB.Location = new System.Drawing.Point(305, 120);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.ReadOnly = true;
            this.fileNameTB.Size = new System.Drawing.Size(182, 27);
            this.fileNameTB.TabIndex = 16;
            this.fileNameTB.WordWrap = false;
            // 
            // compressBtn
            // 
            this.compressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.compressBtn.FlatAppearance.BorderSize = 0;
            this.compressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compressBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.compressBtn.Location = new System.Drawing.Point(180, 184);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(132, 35);
            this.compressBtn.TabIndex = 17;
            this.compressBtn.Text = "Nén File";
            this.compressBtn.UseVisualStyleBackColor = false;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // decompressBtn
            // 
            this.decompressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.decompressBtn.FlatAppearance.BorderSize = 0;
            this.decompressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decompressBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompressBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.decompressBtn.Location = new System.Drawing.Point(359, 184);
            this.decompressBtn.Name = "decompressBtn";
            this.decompressBtn.Size = new System.Drawing.Size(128, 35);
            this.decompressBtn.TabIndex = 18;
            this.decompressBtn.Text = "Giải Nén File";
            this.decompressBtn.UseVisualStyleBackColor = false;
            this.decompressBtn.Click += new System.EventHandler(this.decompressBtn_Click);
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(666, 338);
            this.Controls.Add(this.decompressBtn);
            this.Controls.Add(this.compressBtn);
            this.Controls.Add(this.fileNameTB);
            this.Controls.Add(this.readBtn);
            this.Name = "Bai05";
            this.Text = "Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.Button decompressBtn;
    }
}