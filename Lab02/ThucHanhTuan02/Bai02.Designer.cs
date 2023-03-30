
namespace ThucHanhTuan02
{
    partial class Bai02
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
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.lineCountLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.sizeTB = new System.Windows.Forms.TextBox();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.lineCountTB = new System.Windows.Forms.TextBox();
            this.wordCountTB = new System.Windows.Forms.TextBox();
            this.characterCountTB = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readBtn
            // 
            this.readBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.readBtn.Location = new System.Drawing.Point(47, 34);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(255, 35);
            this.readBtn.TabIndex = 1;
            this.readBtn.Text = "Đọc File";
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.fileNameLabel.Location = new System.Drawing.Point(43, 105);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(87, 20);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "File name:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.sizeLabel.Location = new System.Drawing.Point(43, 148);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(47, 20);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.urlLabel.Location = new System.Drawing.Point(43, 191);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(48, 20);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "URL:";
            // 
            // lineCountLabel
            // 
            this.lineCountLabel.AutoSize = true;
            this.lineCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.lineCountLabel.Location = new System.Drawing.Point(43, 234);
            this.lineCountLabel.Name = "lineCountLabel";
            this.lineCountLabel.Size = new System.Drawing.Size(92, 20);
            this.lineCountLabel.TabIndex = 5;
            this.lineCountLabel.Text = "Line count:";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.wordCountLabel.Location = new System.Drawing.Point(43, 277);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(109, 20);
            this.wordCountLabel.TabIndex = 6;
            this.wordCountLabel.Text = "Words count:";
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.AutoSize = true;
            this.characterCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.characterCountLabel.Location = new System.Drawing.Point(43, 320);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(134, 20);
            this.characterCountLabel.TabIndex = 7;
            this.characterCountLabel.Text = "Character count:";
            // 
            // fileNameTB
            // 
            this.fileNameTB.Location = new System.Drawing.Point(136, 103);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.Size = new System.Drawing.Size(166, 22);
            this.fileNameTB.TabIndex = 8;
            this.fileNameTB.WordWrap = false;
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(96, 146);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(206, 22);
            this.sizeTB.TabIndex = 9;
            this.sizeTB.WordWrap = false;
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(97, 189);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(205, 22);
            this.urlTB.TabIndex = 10;
            this.urlTB.WordWrap = false;
            // 
            // lineCountTB
            // 
            this.lineCountTB.Location = new System.Drawing.Point(141, 232);
            this.lineCountTB.Name = "lineCountTB";
            this.lineCountTB.Size = new System.Drawing.Size(161, 22);
            this.lineCountTB.TabIndex = 11;
            this.lineCountTB.WordWrap = false;
            // 
            // wordCountTB
            // 
            this.wordCountTB.Location = new System.Drawing.Point(158, 275);
            this.wordCountTB.Name = "wordCountTB";
            this.wordCountTB.Size = new System.Drawing.Size(144, 22);
            this.wordCountTB.TabIndex = 12;
            this.wordCountTB.WordWrap = false;
            // 
            // characterCountTB
            // 
            this.characterCountTB.Location = new System.Drawing.Point(183, 318);
            this.characterCountTB.Name = "characterCountTB";
            this.characterCountTB.Size = new System.Drawing.Size(119, 22);
            this.characterCountTB.TabIndex = 13;
            this.characterCountTB.WordWrap = false;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(328, 34);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(433, 372);
            this.textBox.TabIndex = 14;
            this.textBox.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(36)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(76)))), ((int)(((byte)(24)))));
            this.button1.Location = new System.Drawing.Point(47, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.characterCountTB);
            this.Controls.Add(this.wordCountTB);
            this.Controls.Add(this.lineCountTB);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.sizeTB);
            this.Controls.Add(this.fileNameTB);
            this.Controls.Add(this.characterCountLabel);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.lineCountLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.readBtn);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label lineCountLabel;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.TextBox sizeTB;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.TextBox lineCountTB;
        private System.Windows.Forms.TextBox wordCountTB;
        private System.Windows.Forms.TextBox characterCountTB;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
    }
}