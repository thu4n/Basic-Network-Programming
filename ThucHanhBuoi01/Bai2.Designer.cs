
namespace ThucHanhBuoi01
{
    partial class Bai2
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
            this.numOneLabel = new System.Windows.Forms.Label();
            this.numTwoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxRes = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numOneLabel
            // 
            this.numOneLabel.AutoSize = true;
            this.numOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOneLabel.ForeColor = System.Drawing.Color.White;
            this.numOneLabel.Location = new System.Drawing.Point(150, 54);
            this.numOneLabel.Name = "numOneLabel";
            this.numOneLabel.Size = new System.Drawing.Size(123, 25);
            this.numOneLabel.TabIndex = 0;
            this.numOneLabel.Text = "Số Thứ Nhất";
            // 
            // numTwoLabel
            // 
            this.numTwoLabel.AutoSize = true;
            this.numTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTwoLabel.ForeColor = System.Drawing.Color.White;
            this.numTwoLabel.Location = new System.Drawing.Point(387, 54);
            this.numTwoLabel.Name = "numTwoLabel";
            this.numTwoLabel.Size = new System.Drawing.Size(111, 25);
            this.numTwoLabel.TabIndex = 1;
            this.numTwoLabel.Text = "Số Thứ Hai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(620, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Thứ Ba";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(173, 99);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(398, 98);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 4;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(625, 99);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 22);
            this.num3.TabIndex = 5;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(67, 204);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 6;
            this.findBtn.Text = "Tìm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(293, 204);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(528, 204);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 8;
            this.quitBtn.Text = "Thoát";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(62, 296);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(121, 25);
            this.maxLabel.TabIndex = 9;
            this.maxLabel.Text = "Số Lớn Nhất";
            // 
            // maxRes
            // 
            this.maxRes.Location = new System.Drawing.Point(206, 296);
            this.maxRes.Name = "maxRes";
            this.maxRes.ReadOnly = true;
            this.maxRes.Size = new System.Drawing.Size(100, 22);
            this.maxRes.TabIndex = 10;
            this.maxRes.TextChanged += new System.EventHandler(this.maxRes_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(374, 296);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(124, 25);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Số Nhỏ Nhất";
            // 
            // minRes
            // 
            this.minRes.Location = new System.Drawing.Point(518, 296);
            this.minRes.Name = "minRes";
            this.minRes.ReadOnly = true;
            this.minRes.Size = new System.Drawing.Size(100, 22);
            this.minRes.TabIndex = 12;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minRes);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxRes);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTwoLabel);
            this.Controls.Add(this.numOneLabel);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOneLabel;
        private System.Windows.Forms.Label numTwoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxRes;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minRes;
    }
}