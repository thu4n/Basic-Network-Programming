namespace Lab05
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
            this.bai1Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bai23Btn = new System.Windows.Forms.Button();
            this.bai4Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1Btn
            // 
            this.bai1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai1Btn.Location = new System.Drawing.Point(247, 123);
            this.bai1Btn.Name = "bai1Btn";
            this.bai1Btn.Size = new System.Drawing.Size(183, 59);
            this.bai1Btn.TabIndex = 0;
            this.bai1Btn.Text = "Bài 1";
            this.bai1Btn.UseVisualStyleBackColor = true;
            this.bai1Btn.Click += new System.EventHandler(this.bai1Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LAB05 - Menu điều hướng";
            // 
            // bai23Btn
            // 
            this.bai23Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai23Btn.Location = new System.Drawing.Point(247, 206);
            this.bai23Btn.Name = "bai23Btn";
            this.bai23Btn.Size = new System.Drawing.Size(183, 59);
            this.bai23Btn.TabIndex = 2;
            this.bai23Btn.Text = "Bài 2 và 3";
            this.bai23Btn.UseVisualStyleBackColor = true;
            this.bai23Btn.Click += new System.EventHandler(this.bai23Btn_Click);
            // 
            // bai4Btn
            // 
            this.bai4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai4Btn.Location = new System.Drawing.Point(247, 287);
            this.bai4Btn.Name = "bai4Btn";
            this.bai4Btn.Size = new System.Drawing.Size(183, 59);
            this.bai4Btn.TabIndex = 3;
            this.bai4Btn.Text = "Bài 4";
            this.bai4Btn.UseVisualStyleBackColor = true;
            this.bai4Btn.Click += new System.EventHandler(this.bai4Btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.bai4Btn);
            this.Controls.Add(this.bai23Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bai1Btn);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bai1Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bai23Btn;
        private System.Windows.Forms.Button bai4Btn;
    }
}

