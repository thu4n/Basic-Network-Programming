namespace Lab04
{
    partial class Bài_2
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
            this.DownLoad = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.HTML = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DownLoad
            // 
            this.DownLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownLoad.Location = new System.Drawing.Point(482, 59);
            this.DownLoad.Name = "DownLoad";
            this.DownLoad.Size = new System.Drawing.Size(117, 53);
            this.DownLoad.TabIndex = 1;
            this.DownLoad.Text = "Download";
            this.DownLoad.UseVisualStyleBackColor = true;
            this.DownLoad.Click += new System.EventHandler(this.DownLoad_Click);
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(58, 37);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(400, 30);
            this.URL.TabIndex = 2;
            this.URL.Text = "http://uit.edu.vn";
            // 
            // HTML
            // 
            this.HTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTML.Location = new System.Drawing.Point(58, 82);
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(400, 30);
            this.HTML.TabIndex = 3;
            this.HTML.Text = "C:\\Users\\ACER\\Downloads\\huhuhu.html";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 268);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Bài_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HTML);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.DownLoad);
            this.Name = "Bài_2";
            this.Text = "Bài_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownLoad;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox HTML;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}