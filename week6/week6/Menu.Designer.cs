
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
            this.customBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(177, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(446, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lựa chọn loại API bạn muốn gọi";
            // 
            // todosAPI
            // 
            this.todosAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.todosAPI.FlatAppearance.BorderSize = 0;
            this.todosAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todosAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todosAPI.Location = new System.Drawing.Point(308, 113);
            this.todosAPI.Name = "todosAPI";
            this.todosAPI.Size = new System.Drawing.Size(194, 49);
            this.todosAPI.TabIndex = 1;
            this.todosAPI.Text = "To Do List API";
            this.todosAPI.UseVisualStyleBackColor = false;
            this.todosAPI.Click += new System.EventHandler(this.todosAPI_Click);
            // 
            // puppyAPI
            // 
            this.puppyAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.puppyAPI.FlatAppearance.BorderSize = 0;
            this.puppyAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puppyAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puppyAPI.Location = new System.Drawing.Point(308, 202);
            this.puppyAPI.Name = "puppyAPI";
            this.puppyAPI.Size = new System.Drawing.Size(194, 49);
            this.puppyAPI.TabIndex = 2;
            this.puppyAPI.Text = "Puppy Image API";
            this.puppyAPI.UseVisualStyleBackColor = false;
            this.puppyAPI.Click += new System.EventHandler(this.puppyAPI_Click);
            // 
            // customBtn
            // 
            this.customBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.customBtn.FlatAppearance.BorderSize = 0;
            this.customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customBtn.Location = new System.Drawing.Point(308, 291);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(194, 67);
            this.customBtn.TabIndex = 3;
            this.customBtn.Text = "Custom API (Bảo tự đặt tên nhe)";
            this.customBtn.UseVisualStyleBackColor = false;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.puppyAPI);
            this.Controls.Add(this.todosAPI);
            this.Controls.Add(this.titleLabel);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button todosAPI;
        private System.Windows.Forms.Button puppyAPI;
        private System.Windows.Forms.Button customBtn;
    }
}

