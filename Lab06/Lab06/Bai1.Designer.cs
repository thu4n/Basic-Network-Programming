namespace Lab06
{
    partial class Bai1
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
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Shift = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Encrypted = new System.Windows.Forms.TextBox();
            this.Decrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(440, 103);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "button1";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(597, 103);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "button2";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Shift
            // 
            this.Shift.Location = new System.Drawing.Point(55, 144);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(100, 22);
            this.Shift.TabIndex = 2;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(50, 249);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(294, 22);
            this.Input.TabIndex = 3;
            // 
            // Encrypted
            // 
            this.Encrypted.Location = new System.Drawing.Point(50, 323);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(294, 22);
            this.Encrypted.TabIndex = 4;
            // 
            // Decrypted
            // 
            this.Decrypted.Location = new System.Drawing.Point(50, 407);
            this.Decrypted.Name = "Decrypted";
            this.Decrypted.Size = new System.Drawing.Size(294, 22);
            this.Decrypted.TabIndex = 5;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decrypted);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Shift);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox Shift;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Encrypted;
        private System.Windows.Forms.TextBox Decrypted;
    }
}