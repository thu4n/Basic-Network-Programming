using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhBuoi01
{
    public partial class Bai5_Bill : Form
    {
        private float expense = 0;
        private float distance = 0;
        private float usedTemp = 0;
        private float totalTemp = 0;
        public Bai5_Bill()
        {
            InitializeComponent();
            Text = "Thông tin hóa đơn";
        }
        public Bai5_Bill(string vehicle, string gasType, float used, float total)
        {
            InitializeComponent();
            Text = "Thông tin hóa đơn";
            distance = (total / used) * 100;
            if (gasType == "RON 95-III")
            {
                expense = 26830f * total;
            }
            else if (gasType == "E5 RON 92-II")
            {
                expense = 26070f * total;
            }
            else if (gasType == "DO 0,05S-II")
            {
                expense = 21310f * total;
            }
            totalTemp = total;
            usedTemp = used;
        }

        private void Bai5_Bill_Load(object sender, EventArgs e)
        {
            money.Text = expense.ToString() + " VNĐ";
            km.Text = distance.ToString() + " km";
            gasTotal.Text = totalTemp.ToString() + " lít";
            gasFilled.Text = totalTemp.ToString() + " lít";
        }

        private void money_Click(object sender, EventArgs e)
        {

        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
            Close();
        }
    }
}
