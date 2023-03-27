
namespace ThucHanhBuoi01
{
    partial class Bai5_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5_Bill));
            this.titleLabel = new System.Windows.Forms.Label();
            this.kmLabel = new System.Windows.Forms.Label();
            this.gasTotalLabel = new System.Windows.Forms.Label();
            this.gasFilledLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.km = new System.Windows.Forms.Label();
            this.gasTotal = new System.Windows.Forms.Label();
            this.gasFilled = new System.Windows.Forms.Label();
            this.paymentBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(203, 57);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(395, 29);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Thông tin hóa đơn của quý khách";
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.kmLabel.Location = new System.Drawing.Point(200, 230);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(159, 20);
            this.kmLabel.TabIndex = 19;
            this.kmLabel.Text = "Số km xe đi được:";
            // 
            // gasTotalLabel
            // 
            this.gasTotalLabel.AutoSize = true;
            this.gasTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.gasTotalLabel.Location = new System.Drawing.Point(200, 173);
            this.gasTotalLabel.Name = "gasTotalLabel";
            this.gasTotalLabel.Size = new System.Drawing.Size(226, 20);
            this.gasTotalLabel.TabIndex = 18;
            this.gasTotalLabel.Text = "Tổng lượng xăng trong xe:";
            // 
            // gasFilledLabel
            // 
            this.gasFilledLabel.AutoSize = true;
            this.gasFilledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasFilledLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.gasFilledLabel.Location = new System.Drawing.Point(200, 113);
            this.gasFilledLabel.Name = "gasFilledLabel";
            this.gasFilledLabel.Size = new System.Drawing.Size(163, 20);
            this.gasFilledLabel.TabIndex = 17;
            this.gasFilledLabel.Text = "Lượng xăng đã đổ:";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.moneyLabel.Location = new System.Drawing.Point(200, 289);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(103, 20);
            this.moneyLabel.TabIndex = 20;
            this.moneyLabel.Text = "Thành tiền:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(34)))));
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(17)))));
            this.money.Location = new System.Drawing.Point(309, 283);
            this.money.Margin = new System.Windows.Forms.Padding(3);
            this.money.Name = "money";
            this.money.Padding = new System.Windows.Forms.Padding(3);
            this.money.Size = new System.Drawing.Size(69, 26);
            this.money.TabIndex = 24;
            this.money.Text = "Money";
            this.money.Click += new System.EventHandler(this.money_Click);
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(34)))));
            this.km.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.km.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(17)))));
            this.km.Location = new System.Drawing.Point(373, 224);
            this.km.Margin = new System.Windows.Forms.Padding(3);
            this.km.Name = "km";
            this.km.Padding = new System.Windows.Forms.Padding(3);
            this.km.Size = new System.Drawing.Size(165, 26);
            this.km.TabIndex = 23;
            this.km.Text = "Số km xe đi được:";
            // 
            // gasTotal
            // 
            this.gasTotal.AutoSize = true;
            this.gasTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(34)))));
            this.gasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(17)))));
            this.gasTotal.Location = new System.Drawing.Point(432, 167);
            this.gasTotal.Margin = new System.Windows.Forms.Padding(3);
            this.gasTotal.Name = "gasTotal";
            this.gasTotal.Padding = new System.Windows.Forms.Padding(3);
            this.gasTotal.Size = new System.Drawing.Size(232, 26);
            this.gasTotal.TabIndex = 22;
            this.gasTotal.Text = "Tổng lượng xăng trong xe:";
            // 
            // gasFilled
            // 
            this.gasFilled.AutoSize = true;
            this.gasFilled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(34)))));
            this.gasFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasFilled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(17)))));
            this.gasFilled.Location = new System.Drawing.Point(373, 107);
            this.gasFilled.Margin = new System.Windows.Forms.Padding(3);
            this.gasFilled.Name = "gasFilled";
            this.gasFilled.Padding = new System.Windows.Forms.Padding(3);
            this.gasFilled.Size = new System.Drawing.Size(169, 26);
            this.gasFilled.TabIndex = 21;
            this.gasFilled.Text = "Lượng xăng đã đổ:";
            // 
            // paymentBox
            // 
            this.paymentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.paymentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.paymentBox.FormattingEnabled = true;
            this.paymentBox.Items.AddRange(new object[] {
            "Tiền mặt",
            "MoMo",
            "ZaloPay",
            "VNPay",
            "Internet Banking",
            "MasterCard"});
            this.paymentBox.Location = new System.Drawing.Point(247, 381);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(157, 24);
            this.paymentBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(252, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chọn phương thức thanh toán";
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            this.confBtn.Location = new System.Drawing.Point(439, 377);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(109, 29);
            this.confBtn.TabIndex = 27;
            this.confBtn.Text = "Chốt đơn";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // Bai5_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.money);
            this.Controls.Add(this.km);
            this.Controls.Add(this.gasTotal);
            this.Controls.Add(this.gasFilled);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.gasTotalLabel);
            this.Controls.Add(this.gasFilledLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai5_Bill";
            this.Text = "Bai5_Bill";
            this.Load += new System.EventHandler(this.Bai5_Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Label gasTotalLabel;
        private System.Windows.Forms.Label gasFilledLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Label gasTotal;
        private System.Windows.Forms.Label gasFilled;
        private System.Windows.Forms.ComboBox paymentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confBtn;
    }
}