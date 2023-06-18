namespace Lab06
{
    partial class Menu
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bai1Btn = new System.Windows.Forms.Button();
            this.bai2Btn = new System.Windows.Forms.Button();
            this.bai3Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(139, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(366, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LAB06 - Menu điều hướng";
            // 
            // bai1Btn
            // 
            this.bai1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai1Btn.Location = new System.Drawing.Point(228, 106);
            this.bai1Btn.Name = "bai1Btn";
            this.bai1Btn.Size = new System.Drawing.Size(188, 53);
            this.bai1Btn.TabIndex = 1;
            this.bai1Btn.Text = "Bài 1";
            this.bai1Btn.UseVisualStyleBackColor = true;
            this.bai1Btn.Click += new System.EventHandler(this.bai1Btn_Click);
            // 
            // bai2Btn
            // 
            this.bai2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai2Btn.Location = new System.Drawing.Point(228, 199);
            this.bai2Btn.Name = "bai2Btn";
            this.bai2Btn.Size = new System.Drawing.Size(188, 53);
            this.bai2Btn.TabIndex = 2;
            this.bai2Btn.Text = "Bài 2";
            this.bai2Btn.UseVisualStyleBackColor = true;
            this.bai2Btn.Click += new System.EventHandler(this.bai2Btn_Click);
            // 
            // bai3Btn
            // 
            this.bai3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai3Btn.Location = new System.Drawing.Point(228, 285);
            this.bai3Btn.Name = "bai3Btn";
            this.bai3Btn.Size = new System.Drawing.Size(188, 53);
            this.bai3Btn.TabIndex = 3;
            this.bai3Btn.Text = "Bài 3";
            this.bai3Btn.UseVisualStyleBackColor = true;
            this.bai3Btn.Click += new System.EventHandler(this.bai3Btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 379);
            this.Controls.Add(this.bai3Btn);
            this.Controls.Add(this.bai2Btn);
            this.Controls.Add(this.bai1Btn);
            this.Controls.Add(this.titleLabel);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button bai1Btn;
        private System.Windows.Forms.Button bai2Btn;
        private System.Windows.Forms.Button bai3Btn;
    }
}

