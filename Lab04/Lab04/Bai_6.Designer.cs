namespace Lab04
{
    partial class Bai6
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
            this.getBtn = new System.Windows.Forms.Button();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bai_6_Article1 = new Lab04.Bai_6_Article();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(908, 12);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(75, 22);
            this.getBtn.TabIndex = 2;
            this.getBtn.Text = "Get";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(13, 12);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(889, 22);
            this.urlTB.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bai_6_Article1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 384);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // bai_6_Article1
            // 
            this.bai_6_Article1.Location = new System.Drawing.Point(3, 3);
            this.bai_6_Article1.Name = "bai_6_Article1";
            this.bai_6_Article1.Size = new System.Drawing.Size(967, 188);
            this.bai_6_Article1.TabIndex = 0;
            this.bai_6_Article1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 457);
            this.progressBar1.Maximum = 90;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(967, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 492);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.getBtn);
            this.Name = "Bai6";
            this.Text = "Bài_6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bai_6_Article bai_6_Article1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}