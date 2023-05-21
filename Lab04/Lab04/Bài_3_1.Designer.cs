namespace Lab04
{
    partial class Bài_3_1
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
            this.ListFile = new System.Windows.Forms.ListBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.picImages = new System.Windows.Forms.PictureBox();
            this.Download = new System.Windows.Forms.Button();
            this.GetImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).BeginInit();
            this.SuspendLayout();
            // 
            // ListFile
            // 
            this.ListFile.FormattingEnabled = true;
            this.ListFile.ItemHeight = 16;
            this.ListFile.Location = new System.Drawing.Point(36, 132);
            this.ListFile.Name = "ListFile";
            this.ListFile.Size = new System.Drawing.Size(409, 276);
            this.ListFile.TabIndex = 2;
            this.ListFile.SelectedValueChanged += new System.EventHandler(this.ListFile_SelectedValueChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(36, 24);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(409, 22);
            this.txtURL.TabIndex = 3;
            // 
            // picImages
            // 
            this.picImages.Location = new System.Drawing.Point(482, 132);
            this.picImages.Name = "picImages";
            this.picImages.Size = new System.Drawing.Size(306, 276);
            this.picImages.TabIndex = 4;
            this.picImages.TabStop = false;
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(118, 71);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(92, 43);
            this.Download.TabIndex = 5;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // GetImage
            // 
            this.GetImage.Location = new System.Drawing.Point(328, 71);
            this.GetImage.Name = "GetImage";
            this.GetImage.Size = new System.Drawing.Size(92, 43);
            this.GetImage.TabIndex = 6;
            this.GetImage.Text = "Get Image";
            this.GetImage.UseVisualStyleBackColor = true;
            this.GetImage.Click += new System.EventHandler(this.GetImage_Click);
            // 
            // Bài_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetImage);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.picImages);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.ListFile);
            this.Name = "Bài_3";
            this.Text = "Bài_3";
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListFile;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.PictureBox picImages;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button GetImage;
    }
}