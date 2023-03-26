
namespace ThucHanhBuoi01
{
    partial class Bai9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai9));
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.confBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(180, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(334, 36);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Steam Student Grades";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.instructionLabel.Location = new System.Drawing.Point(74, 89);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(225, 60);
            this.instructionLabel.TabIndex = 14;
            this.instructionLabel.Text = "Nhập vào tên sinh viên và\r\nđiểm các môn (cách nhau\r\nbởi dấu phẩy):";
            // 
            // infoTB
            // 
            this.infoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTB.Location = new System.Drawing.Point(315, 89);
            this.infoTB.MaxLength = 36000;
            this.infoTB.Multiline = true;
            this.infoTB.Name = "infoTB";
            this.infoTB.Size = new System.Drawing.Size(315, 60);
            this.infoTB.TabIndex = 16;
            this.infoTB.WordWrap = false;
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.confBtn.Location = new System.Drawing.Point(302, 185);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(90, 31);
            this.confBtn.TabIndex = 19;
            this.confBtn.Text = "Confirm";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(705, 260);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai9";
            this.Text = "Bai9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.Button confBtn;
    }
}