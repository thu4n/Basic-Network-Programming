
namespace ThucHanhBuoi01
{
    partial class Bai7_Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai7_Result));
            this.titleLabel = new System.Windows.Forms.Label();
            this.peronaLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.signTB = new System.Windows.Forms.TextBox();
            this.personaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(238, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(325, 32);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Kết quả chiêm tinh học";
            // 
            // peronaLabel
            // 
            this.peronaLabel.AutoSize = true;
            this.peronaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peronaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.peronaLabel.Location = new System.Drawing.Point(205, 212);
            this.peronaLabel.Name = "peronaLabel";
            this.peronaLabel.Size = new System.Drawing.Size(169, 20);
            this.peronaLabel.TabIndex = 22;
            this.peronaLabel.Text = "Tính cách của bạn:";
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.signLabel.Location = new System.Drawing.Point(205, 161);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(222, 20);
            this.signLabel.TabIndex = 21;
            this.signLabel.Text = "Cung hoàng đạo của bạn:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.dateLabel.Location = new System.Drawing.Point(205, 120);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(124, 20);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "Bạn sinh vào:";
            // 
            // dateTB
            // 
            this.dateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTB.Location = new System.Drawing.Point(335, 113);
            this.dateTB.MaxLength = 10;
            this.dateTB.Name = "dateTB";
            this.dateTB.ReadOnly = true;
            this.dateTB.Size = new System.Drawing.Size(163, 27);
            this.dateTB.TabIndex = 23;
            // 
            // signTB
            // 
            this.signTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signTB.Location = new System.Drawing.Point(433, 158);
            this.signTB.MaxLength = 10;
            this.signTB.Name = "signTB";
            this.signTB.ReadOnly = true;
            this.signTB.Size = new System.Drawing.Size(163, 27);
            this.signTB.TabIndex = 24;
            // 
            // personaTB
            // 
            this.personaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personaTB.Location = new System.Drawing.Point(209, 235);
            this.personaTB.MaxLength = 10;
            this.personaTB.Multiline = true;
            this.personaTB.Name = "personaTB";
            this.personaTB.ReadOnly = true;
            this.personaTB.Size = new System.Drawing.Size(387, 172);
            this.personaTB.TabIndex = 25;
            // 
            // Bai7_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personaTB);
            this.Controls.Add(this.signTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.peronaLabel);
            this.Controls.Add(this.signLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai7_Result";
            this.Text = "Bai7_Result";
            this.Load += new System.EventHandler(this.Bai7_Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label peronaLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.TextBox signTB;
        private System.Windows.Forms.TextBox personaTB;
    }
}