﻿namespace Lab06
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(430, 73);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(103, 43);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Mã hóa";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(597, 73);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(98, 43);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Giải mã";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Shift
            // 
            this.Shift.Location = new System.Drawing.Point(34, 83);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(126, 22);
            this.Shift.TabIndex = 2;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(34, 178);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(661, 75);
            this.Input.TabIndex = 3;
            // 
            // Encrypted
            // 
            this.Encrypted.Location = new System.Drawing.Point(34, 311);
            this.Encrypted.Multiline = true;
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(661, 74);
            this.Encrypted.TabIndex = 4;
            this.Encrypted.TextChanged += new System.EventHandler(this.Encrypted_TextChanged);
            // 
            // Decrypted
            // 
            this.Decrypted.Location = new System.Drawing.Point(34, 439);
            this.Decrypted.Multiline = true;
            this.Decrypted.Name = "Decrypted";
            this.Decrypted.Size = new System.Drawing.Size(661, 79);
            this.Decrypted.TabIndex = 5;
            this.Decrypted.TextChanged += new System.EventHandler(this.Decrypted_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa Caesar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dịch (Shift)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dữ liệu (Input)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(36, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(36, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giải mã";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 543);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}