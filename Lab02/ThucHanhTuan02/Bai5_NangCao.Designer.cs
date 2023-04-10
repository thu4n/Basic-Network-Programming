
namespace ThucHanhTuan02
{
    partial class Bai5_NangCao
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.decompressBtn = new System.Windows.Forms.Button();
            this.compressBtn = new System.Windows.Forms.Button();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(136, 293);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(529, 34);
            this.progressBar1.TabIndex = 0;
            // 
            // decompressBtn
            // 
            this.decompressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.decompressBtn.FlatAppearance.BorderSize = 0;
            this.decompressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decompressBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompressBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.decompressBtn.Location = new System.Drawing.Point(426, 240);
            this.decompressBtn.Name = "decompressBtn";
            this.decompressBtn.Size = new System.Drawing.Size(128, 35);
            this.decompressBtn.TabIndex = 22;
            this.decompressBtn.Text = "Giải Nén File";
            this.decompressBtn.UseVisualStyleBackColor = false;
            this.decompressBtn.Click += new System.EventHandler(this.decompressBtn_Click);
            // 
            // compressBtn
            // 
            this.compressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.compressBtn.FlatAppearance.BorderSize = 0;
            this.compressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compressBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.compressBtn.Location = new System.Drawing.Point(247, 240);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(132, 35);
            this.compressBtn.TabIndex = 21;
            this.compressBtn.Text = "Nén File";
            this.compressBtn.UseVisualStyleBackColor = false;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // fileNameTB
            // 
            this.fileNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTB.Location = new System.Drawing.Point(372, 176);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.ReadOnly = true;
            this.fileNameTB.Size = new System.Drawing.Size(182, 27);
            this.fileNameTB.TabIndex = 20;
            this.fileNameTB.WordWrap = false;
            // 
            // readBtn
            // 
            this.readBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.readBtn.Location = new System.Drawing.Point(247, 176);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(107, 27);
            this.readBtn.TabIndex = 19;
            this.readBtn.Text = "Đọc File";
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // Bai5_NangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decompressBtn);
            this.Controls.Add(this.compressBtn);
            this.Controls.Add(this.fileNameTB);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.progressBar1);
            this.Name = "Bai5_NangCao";
            this.Text = "Bai5_NangCao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button decompressBtn;
        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.Button readBtn;
    }
}