
namespace ThucHanhBuoi01
{
    partial class Bai8_Result
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai8_Result));
            this.titleLabel = new System.Windows.Forms.Label();
            this.subnetTable = new System.Windows.Forms.DataGridView();
            this.sttCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstHostAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastHostAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadcastAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subnetTable)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(298, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(204, 36);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Subnet Table";
            // 
            // subnetTable
            // 
            this.subnetTable.AllowUserToAddRows = false;
            this.subnetTable.AllowUserToDeleteRows = false;
            this.subnetTable.AllowUserToResizeColumns = false;
            this.subnetTable.AllowUserToResizeRows = false;
            this.subnetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subnetTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.subnetTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subnetTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subnetTable.ColumnHeadersHeight = 25;
            this.subnetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.subnetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttCol,
            this.netAdd,
            this.firstHostAdd,
            this.lastHostAdd,
            this.broadcastAdd});
            this.subnetTable.EnableHeadersVisualStyles = false;
            this.subnetTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.subnetTable.Location = new System.Drawing.Point(32, 101);
            this.subnetTable.Name = "subnetTable";
            this.subnetTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subnetTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.subnetTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.subnetTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.subnetTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.subnetTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.subnetTable.RowTemplate.Height = 24;
            this.subnetTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subnetTable.Size = new System.Drawing.Size(730, 300);
            this.subnetTable.TabIndex = 12;
            this.subnetTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subnetTable_CellContentClick);
            // 
            // sttCol
            // 
            this.sttCol.FillWeight = 45.13399F;
            this.sttCol.HeaderText = "STT";
            this.sttCol.MinimumWidth = 6;
            this.sttCol.Name = "sttCol";
            this.sttCol.ReadOnly = true;
            // 
            // netAdd
            // 
            this.netAdd.FillWeight = 100.3139F;
            this.netAdd.HeaderText = "Địa chỉ mạng";
            this.netAdd.MinimumWidth = 6;
            this.netAdd.Name = "netAdd";
            this.netAdd.ReadOnly = true;
            // 
            // firstHostAdd
            // 
            this.firstHostAdd.FillWeight = 97.51328F;
            this.firstHostAdd.HeaderText = "Địa chỉ đầu";
            this.firstHostAdd.MinimumWidth = 6;
            this.firstHostAdd.Name = "firstHostAdd";
            this.firstHostAdd.ReadOnly = true;
            // 
            // lastHostAdd
            // 
            this.lastHostAdd.FillWeight = 106.3456F;
            this.lastHostAdd.HeaderText = "Địa chỉ cuối";
            this.lastHostAdd.MinimumWidth = 6;
            this.lastHostAdd.Name = "lastHostAdd";
            this.lastHostAdd.ReadOnly = true;
            // 
            // broadcastAdd
            // 
            this.broadcastAdd.FillWeight = 150.6933F;
            this.broadcastAdd.HeaderText = "Địa chỉ Broadcast";
            this.broadcastAdd.MinimumWidth = 6;
            this.broadcastAdd.Name = "broadcastAdd";
            this.broadcastAdd.ReadOnly = true;
            // 
            // Bai8_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.subnetTable);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai8_Result";
            this.Text = "Bai8_Result";
            this.Load += new System.EventHandler(this.Bai8_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subnetTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView subnetTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstHostAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastHostAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadcastAdd;
    }
}