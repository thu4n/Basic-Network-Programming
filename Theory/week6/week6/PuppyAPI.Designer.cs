
namespace week6
{
    partial class PuppyAPI
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
            this.MyDogImage = new System.Windows.Forms.PictureBox();
            this.callBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyDogImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDogImage
            // 
            this.MyDogImage.BackColor = System.Drawing.Color.White;
            this.MyDogImage.Location = new System.Drawing.Point(205, 44);
            this.MyDogImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyDogImage.Name = "MyDogImage";
            this.MyDogImage.Size = new System.Drawing.Size(447, 261);
            this.MyDogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyDogImage.TabIndex = 0;
            this.MyDogImage.TabStop = false;
            // 
            // callBtn
            // 
            this.callBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.callBtn.FlatAppearance.BorderSize = 0;
            this.callBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.callBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callBtn.ForeColor = System.Drawing.Color.Crimson;
            this.callBtn.Location = new System.Drawing.Point(258, 324);
            this.callBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.callBtn.Name = "callBtn";
            this.callBtn.Size = new System.Drawing.Size(353, 42);
            this.callBtn.TabIndex = 2;
            this.callBtn.Text = "I want to see ur lovely puppy";
            this.callBtn.UseVisualStyleBackColor = false;
            this.callBtn.Click += new System.EventHandler(this.GetDogImage_Click);
            // 
            // PuppyAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.callBtn);
            this.Controls.Add(this.MyDogImage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PuppyAPI";
            this.Text = "PuppyAPI";
            ((System.ComponentModel.ISupportInitialize)(this.MyDogImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MyDogImage;
        private System.Windows.Forms.Button callBtn;
    }
}