
namespace ThucHanhBuoi01
{
    partial class Bai8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai8));
            this.titleLabel = new System.Windows.Forms.Label();
            this.networkLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.networkTB = new System.Windows.Forms.TextBox();
            this.subnetLabel = new System.Windows.Forms.Label();
            this.subnetTB = new System.Windows.Forms.TextBox();
            this.confBtn = new System.Windows.Forms.Button();
            this.subnetMaskTB = new System.Windows.Forms.TextBox();
            this.subnetmaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(99, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(507, 36);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Steam Network Subnetting Service";
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.networkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.networkLabel.Location = new System.Drawing.Point(101, 98);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(206, 40);
            this.networkLabel.TabIndex = 13;
            this.networkLabel.Text = "Nhập vào địa chỉ mạng \r\nkèm subnetmask";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.instructionLabel.Location = new System.Drawing.Point(309, 131);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(150, 20);
            this.instructionLabel.TabIndex = 14;
            this.instructionLabel.Text = "VD: 192.168.2.0/24";
            this.instructionLabel.Click += new System.EventHandler(this.instructionLabel_Click);
            // 
            // networkTB
            // 
            this.networkTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkTB.Location = new System.Drawing.Point(313, 98);
            this.networkTB.MaxLength = 15;
            this.networkTB.Name = "networkTB";
            this.networkTB.Size = new System.Drawing.Size(179, 30);
            this.networkTB.TabIndex = 15;
            // 
            // subnetLabel
            // 
            this.subnetLabel.AutoSize = true;
            this.subnetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.subnetLabel.Location = new System.Drawing.Point(101, 181);
            this.subnetLabel.Name = "subnetLabel";
            this.subnetLabel.Size = new System.Drawing.Size(200, 40);
            this.subnetLabel.TabIndex = 16;
            this.subnetLabel.Text = "Nhập vào số mạng con\r\ncần chia";
            // 
            // subnetTB
            // 
            this.subnetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetTB.Location = new System.Drawing.Point(313, 181);
            this.subnetTB.Name = "subnetTB";
            this.subnetTB.Size = new System.Drawing.Size(195, 30);
            this.subnetTB.TabIndex = 17;
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.confBtn.Location = new System.Drawing.Point(307, 252);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(90, 31);
            this.confBtn.TabIndex = 18;
            this.confBtn.Text = "Confirm";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // subnetMaskTB
            // 
            this.subnetMaskTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetMaskTB.Location = new System.Drawing.Point(517, 98);
            this.subnetMaskTB.MaxLength = 2;
            this.subnetMaskTB.Name = "subnetMaskTB";
            this.subnetMaskTB.Size = new System.Drawing.Size(59, 30);
            this.subnetMaskTB.TabIndex = 19;
            // 
            // subnetmaskLabel
            // 
            this.subnetmaskLabel.AutoSize = true;
            this.subnetmaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.subnetmaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetmaskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.subnetmaskLabel.Location = new System.Drawing.Point(492, 101);
            this.subnetmaskLabel.Name = "subnetmaskLabel";
            this.subnetmaskLabel.Size = new System.Drawing.Size(19, 25);
            this.subnetmaskLabel.TabIndex = 20;
            this.subnetmaskLabel.Text = "/";
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(705, 329);
            this.Controls.Add(this.subnetmaskLabel);
            this.Controls.Add(this.subnetMaskTB);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.subnetTB);
            this.Controls.Add(this.subnetLabel);
            this.Controls.Add(this.networkTB);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.networkLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai8";
            this.Text = "Bai8";
            this.Load += new System.EventHandler(this.Bai8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label networkLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox networkTB;
        private System.Windows.Forms.Label subnetLabel;
        private System.Windows.Forms.TextBox subnetTB;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.TextBox subnetMaskTB;
        private System.Windows.Forms.Label subnetmaskLabel;
    }
}