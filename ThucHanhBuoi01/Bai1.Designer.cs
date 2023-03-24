
namespace ThucHanhBuoi01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Label.ForeColor = System.Drawing.Color.White;
            this.num1Label.Location = new System.Drawing.Point(112, 108);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(100, 29);
            this.num1Label.TabIndex = 0;
            this.num1Label.Text = "Số thứ 1";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Label.ForeColor = System.Drawing.Color.White;
            this.num2Label.Location = new System.Drawing.Point(112, 171);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(100, 29);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "Số thứ 2";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(112, 274);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(95, 29);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Kết quả";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(260, 108);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(381, 30);
            this.num1.TabIndex = 3;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(260, 170);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(381, 30);
            this.num2.TabIndex = 4;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(260, 272);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(381, 30);
            this.result.TabIndex = 5;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.confirm.Location = new System.Drawing.Point(112, 225);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(95, 31);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Cộng lại";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button confirm;
    }
}