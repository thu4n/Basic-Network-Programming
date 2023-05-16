namespace Lab4
{
    partial class Bài_4
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
            Temp = new Button();
            SuspendLayout();
            // 
            // Temp
            // 
            Temp.BackColor = SystemColors.ActiveCaption;
            Temp.Location = new Point(335, 200);
            Temp.Name = "Temp";
            Temp.Size = new Size(131, 51);
            Temp.TabIndex = 1;
            Temp.Text = "Nút Template";
            Temp.UseVisualStyleBackColor = false;
            // 
            // Bài_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Temp);
            Name = "Bài_4";
            Text = "Bài_4";
            ResumeLayout(false);
        }

        #endregion

        private Button Temp;
    }
}