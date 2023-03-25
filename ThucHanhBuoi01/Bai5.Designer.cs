
namespace ThucHanhBuoi01
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            this.titleLabel = new System.Windows.Forms.Label();
            this.vehicleBox = new System.Windows.Forms.ComboBox();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.gasLabel = new System.Windows.Forms.Label();
            this.gasBox = new System.Windows.Forms.ComboBox();
            this.confBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(153, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(495, 29);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Bạn đã dắt xe đi bộ tới Steam Gas Station";
            // 
            // vehicleBox
            // 
            this.vehicleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.vehicleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.vehicleBox.FormattingEnabled = true;
            this.vehicleBox.Items.AddRange(new object[] {
            "Wave Alpha",
            "Sirius",
            "Vision",
            "Lead",
            "Winner",
            "AirBlade",
            "Xe tải 9 tấn",
            "Tesla Model Y"});
            this.vehicleBox.Location = new System.Drawing.Point(420, 129);
            this.vehicleBox.Name = "vehicleBox";
            this.vehicleBox.Size = new System.Drawing.Size(157, 28);
            this.vehicleBox.TabIndex = 3;
            this.vehicleBox.SelectedIndexChanged += new System.EventHandler(this.vehicleBox_SelectedIndexChanged);
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.vehicleLabel.Location = new System.Drawing.Point(223, 129);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(191, 20);
            this.vehicleLabel.TabIndex = 12;
            this.vehicleLabel.Text = "Chọn loại xe của bạn:";
            // 
            // gasLabel
            // 
            this.gasLabel.AutoSize = true;
            this.gasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.gasLabel.Location = new System.Drawing.Point(223, 183);
            this.gasLabel.Name = "gasLabel";
            this.gasLabel.Size = new System.Drawing.Size(175, 20);
            this.gasLabel.TabIndex = 13;
            this.gasLabel.Text = "Chọn loại xăng dầu:";
            // 
            // gasBox
            // 
            this.gasBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.gasBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.gasBox.FormattingEnabled = true;
            this.gasBox.Location = new System.Drawing.Point(420, 183);
            this.gasBox.Name = "gasBox";
            this.gasBox.Size = new System.Drawing.Size(157, 28);
            this.gasBox.TabIndex = 14;
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.confBtn.Location = new System.Drawing.Point(293, 260);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(215, 31);
            this.confBtn.TabIndex = 15;
            this.confBtn.Text = "Đầy bình luôn anh ơi!";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.gasBox);
            this.Controls.Add(this.gasLabel);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.vehicleBox);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.ComboBox vehicleBox;
        private System.Windows.Forms.Label gasLabel;
        private System.Windows.Forms.ComboBox gasBox;
        private System.Windows.Forms.Button confBtn;
    }
}