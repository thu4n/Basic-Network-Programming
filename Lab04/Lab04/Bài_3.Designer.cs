namespace Lab04
{
    partial class Bai3
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
            this.URL = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.GoFoward = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.DownFile = new System.Windows.Forms.Button();
            this.DownResource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(125, 12);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(665, 26);
            this.URL.TabIndex = 3;
            this.URL.Text = "http://uit.edu.vn";
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(12, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(101, 30);
            this.Load.TabIndex = 4;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 87);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 367);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // GoFoward
            // 
            this.GoFoward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoFoward.Location = new System.Drawing.Point(12, 48);
            this.GoFoward.Name = "GoFoward";
            this.GoFoward.Size = new System.Drawing.Size(101, 30);
            this.GoFoward.TabIndex = 6;
            this.GoFoward.Text = "Go Foward";
            this.GoFoward.UseVisualStyleBackColor = true;
            this.GoFoward.Click += new System.EventHandler(this.GoFoward_Click);
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(125, 48);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(103, 30);
            this.GoBack.TabIndex = 7;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(243, 48);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(103, 30);
            this.Refresh.TabIndex = 8;
            this.Refresh.Text = "refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DownFile
            // 
            this.DownFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownFile.Location = new System.Drawing.Point(507, 48);
            this.DownFile.Name = "DownFile";
            this.DownFile.Size = new System.Drawing.Size(110, 30);
            this.DownFile.TabIndex = 9;
            this.DownFile.Text = "Down File";
            this.DownFile.UseVisualStyleBackColor = true;
            this.DownFile.Click += new System.EventHandler(this.DownFile_Click);
            // 
            // DownResource
            // 
            this.DownResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownResource.Location = new System.Drawing.Point(633, 48);
            this.DownResource.Name = "DownResource";
            this.DownResource.Size = new System.Drawing.Size(157, 30);
            this.DownResource.TabIndex = 10;
            this.DownResource.Text = "Down Resource";
            this.DownResource.UseVisualStyleBackColor = true;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.DownResource);
            this.Controls.Add(this.DownFile);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.GoFoward);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.URL);
            this.Name = "Bai3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox URL;
        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button GoFoward;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button DownFile;
        private System.Windows.Forms.Button DownResource;
    }
}