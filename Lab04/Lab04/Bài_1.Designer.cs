namespace Lab04
{
    partial class Bài_1
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
            this.Get_btn = new System.Windows.Forms.Button();
            this.Url_txt = new System.Windows.Forms.TextBox();
            this.Content_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Get_btn
            // 
            this.Get_btn.Location = new System.Drawing.Point(663, 78);
            this.Get_btn.Name = "Get_btn";
            this.Get_btn.Size = new System.Drawing.Size(75, 23);
            this.Get_btn.TabIndex = 0;
            this.Get_btn.Text = "GET";
            this.Get_btn.UseVisualStyleBackColor = true;
            this.Get_btn.Click += new System.EventHandler(this.Get_btn_Click);
            // 
            // Url_txt
            // 
            this.Url_txt.Location = new System.Drawing.Point(105, 79);
            this.Url_txt.Name = "Url_txt";
            this.Url_txt.Size = new System.Drawing.Size(513, 22);
            this.Url_txt.TabIndex = 1;
            // 
            // Content_txt
            // 
            this.Content_txt.Location = new System.Drawing.Point(78, 134);
            this.Content_txt.Name = "Content_txt";
            this.Content_txt.ReadOnly = true;
            this.Content_txt.Size = new System.Drawing.Size(660, 287);
            this.Content_txt.TabIndex = 2;
            this.Content_txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // Bài_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Content_txt);
            this.Controls.Add(this.Url_txt);
            this.Controls.Add(this.Get_btn);
            this.Name = "Bài_1";
            this.Text = "Bài_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Get_btn;
        private System.Windows.Forms.TextBox Url_txt;
        private System.Windows.Forms.RichTextBox Content_txt;
        private System.Windows.Forms.Label label1;
    }
}