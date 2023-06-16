namespace Lab06
{
    partial class Bai3_Server
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
            this.button1 = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Listening";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ipTB
            // 
            this.ipTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTB.Location = new System.Drawing.Point(120, 29);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(206, 27);
            this.ipTB.TabIndex = 1;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(33, 32);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(81, 20);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "Địa chỉ IP";
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.White;
            this.chatBox.Location = new System.Drawing.Point(37, 82);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(446, 356);
            this.chatBox.TabIndex = 3;
            // 
            // Bai3_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.button1);
            this.Name = "Bai3_Server";
            this.Text = "Bai3_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox chatBox;
    }
}