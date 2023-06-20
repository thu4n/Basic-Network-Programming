namespace Lab04
{
    partial class Bai_3_1
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
            this.picImages = new System.Windows.Forms.PictureBox();
            this.ListResouce = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).BeginInit();
            this.SuspendLayout();
            // 
            // ListFile
            // 
            this.ListFile.FormattingEnabled = true;
            this.ListFile.ItemHeight = 20;
            this.ListFile.Location = new System.Drawing.Point(15, 65);
            this.ListFile.Margin = new System.Windows.Forms.Padding(4);
            this.ListFile.Name = "ListFile";
            this.ListFile.Size = new System.Drawing.Size(408, 344);
            this.ListFile.TabIndex = 2;
            this.ListFile.SelectedValueChanged += new System.EventHandler(this.ListFile_SelectedValueChanged);
            // 
            // picImages
            // 
            this.picImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImages.Location = new System.Drawing.Point(431, 65);
            this.picImages.Margin = new System.Windows.Forms.Padding(4);
            this.picImages.Name = "picImages";
            this.picImages.Size = new System.Drawing.Size(632, 344);
            this.picImages.TabIndex = 4;
            this.picImages.TabStop = false;
            // 
            // ListResouce
            // 
            this.ListResouce.AutoSize = true;
            this.ListResouce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListResouce.Location = new System.Drawing.Point(15, 22);
            this.ListResouce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListResouce.Name = "ListResouce";
            this.ListResouce.Size = new System.Drawing.Size(96, 20);
            this.ListResouce.TabIndex = 5;
            this.ListResouce.Text = "list resouce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show file";
            // 
            // Bai_3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListResouce);
            this.Controls.Add(this.picImages);
            this.Controls.Add(this.ListFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai_3_1";
            this.Text = "Bài_3";
            this.Load += new System.EventHandler(this.Bài_3_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListFile;
        private System.Windows.Forms.PictureBox picImages;
        private System.Windows.Forms.Label ListResouce;
        private System.Windows.Forms.Label label1;
    }
}