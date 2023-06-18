namespace Lab06
{
    partial class Bai2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelKey = new System.Windows.Forms.Label();
            this.TieuDe = new System.Windows.Forms.Label();
            this.Decrypted = new System.Windows.Forms.TextBox();
            this.Encrypted = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(68, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giải mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(68, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(68, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dữ liệu (Input)";
            // 
            // LabelKey
            // 
            this.LabelKey.AutoSize = true;
            this.LabelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelKey.Location = new System.Drawing.Point(68, 55);
            this.LabelKey.Name = "LabelKey";
            this.LabelKey.Size = new System.Drawing.Size(92, 20);
            this.LabelKey.TabIndex = 18;
            this.LabelKey.Text = "Khóa (Key)";
            // 
            // TieuDe
            // 
            this.TieuDe.AllowDrop = true;
            this.TieuDe.AutoSize = true;
            this.TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TieuDe.Location = new System.Drawing.Point(44, 14);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(135, 20);
            this.TieuDe.TabIndex = 17;
            this.TieuDe.Text = "Mã hóa Vigenère";
            // 
            // Decrypted
            // 
            this.Decrypted.Location = new System.Drawing.Point(66, 444);
            this.Decrypted.Multiline = true;
            this.Decrypted.Name = "Decrypted";
            this.Decrypted.Size = new System.Drawing.Size(661, 79);
            this.Decrypted.TabIndex = 16;
            // 
            // Encrypted
            // 
            this.Encrypted.Location = new System.Drawing.Point(66, 316);
            this.Encrypted.Multiline = true;
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(661, 74);
            this.Encrypted.TabIndex = 15;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(66, 183);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(661, 75);
            this.Input.TabIndex = 14;
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(66, 88);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(126, 22);
            this.Key.TabIndex = 13;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(629, 78);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(98, 43);
            this.Decrypt.TabIndex = 12;
            this.Decrypt.Text = "Giải mã";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(458, 78);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(103, 43);
            this.Encrypt.TabIndex = 11;
            this.Encrypt.Text = "Mã hóa";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelKey);
            this.Controls.Add(this.TieuDe);
            this.Controls.Add(this.Decrypted);
            this.Controls.Add(this.Encrypted);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelKey;
        private System.Windows.Forms.Label TieuDe;
        private System.Windows.Forms.TextBox Decrypted;
        private System.Windows.Forms.TextBox Encrypted;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Encrypt;
    }
}