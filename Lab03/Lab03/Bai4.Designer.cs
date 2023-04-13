
namespace Lab03
{
    partial class Bai4
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
            this.bai1Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1Btn
            // 
            this.bai1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(208)))));
            this.bai1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bai1Btn.FlatAppearance.BorderSize = 0;
            this.bai1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai1Btn.ForeColor = System.Drawing.Color.White;
            this.bai1Btn.Location = new System.Drawing.Point(316, 202);
            this.bai1Btn.Name = "bai1Btn";
            this.bai1Btn.Size = new System.Drawing.Size(169, 46);
            this.bai1Btn.TabIndex = 2;
            this.bai1Btn.Text = "Nút template";
            this.bai1Btn.UseVisualStyleBackColor = false;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bai1Btn);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bai1Btn;
    }
}