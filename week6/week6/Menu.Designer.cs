
namespace week6
{
    partial class Menu
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.todosAPI = new System.Windows.Forms.Button();
            this.puppyAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(199, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(506, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lựa chọn loại API bạn muốn gọi";
            // 
            // todosAPI
            // 
            this.todosAPI.BackColor = System.Drawing.Color.LavenderBlush;
            this.todosAPI.FlatAppearance.BorderSize = 0;
            this.todosAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todosAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todosAPI.Location = new System.Drawing.Point(346, 141);
            this.todosAPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.todosAPI.Name = "todosAPI";
            this.todosAPI.Size = new System.Drawing.Size(218, 61);
            this.todosAPI.TabIndex = 1;
            this.todosAPI.Text = "To Do List API";
            this.todosAPI.UseVisualStyleBackColor = false;
            this.todosAPI.Click += new System.EventHandler(this.todosAPI_Click);
            // 
            // puppyAPI
            // 
            this.puppyAPI.BackColor = System.Drawing.Color.LavenderBlush;
            this.puppyAPI.FlatAppearance.BorderSize = 0;
            this.puppyAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puppyAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puppyAPI.Location = new System.Drawing.Point(346, 252);
            this.puppyAPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.puppyAPI.Name = "puppyAPI";
            this.puppyAPI.Size = new System.Drawing.Size(218, 61);
            this.puppyAPI.TabIndex = 2;
            this.puppyAPI.Text = "Puppy Image API";
            this.puppyAPI.UseVisualStyleBackColor = false;
            this.puppyAPI.Click += new System.EventHandler(this.puppyAPI_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.puppyAPI);
            this.Controls.Add(this.todosAPI);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button todosAPI;
        private System.Windows.Forms.Button puppyAPI;
    }
}

