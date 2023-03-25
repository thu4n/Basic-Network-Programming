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
    public partial class Bai5 : Form
    {
        private float[] used = { 1.6f, 1.99f, 1.87f, 2.02f, 1.7f, 2.17f, 13};
        private float[] total = { 3.7f, 3.8f, 5.2f, 6f, 4.5f, 4.4f, 70 };
        public Bai5()
        {
            InitializeComponent();
            Text = "Bài 04 – Tính tiền xăng";
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void vehicleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleBox.SelectedIndex >= 0 && vehicleBox.SelectedIndex <= 2)
            {
                gasBox.Items.Clear();
                gasBox.Items.Add("RON 95-III");
                gasBox.Items.Add("E5 RON 92-II");
            }
            else if (vehicleBox.SelectedIndex >= 3 && vehicleBox.SelectedIndex <= 5)
            {
                gasBox.Items.Clear();
                gasBox.Items.Add("RON 95-III");
            }
            else if (vehicleBox.SelectedIndex == 6)
            {
                gasBox.Items.Clear();
                gasBox.Items.Add("DO 0,05S-II");
            }
            else if(vehicleBox.SelectedIndex == 7)
            {
                gasBox.Items.Clear();
                gasBox.Items.Add("Điện");
            }
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            if (vehicleBox.Text != "" && gasBox.Text != "")
            {
                if(vehicleBox.SelectedIndex == 7)
                {
                    MessageBox.Show("Trạm xăng tạm thời chưa hỗ trợ sạc cho xe điện, xin quý khách thông cảm.");
                    return;
                }
                Bai5_Bill bill = new Bai5_Bill(vehicleBox.Text,gasBox.Text,used[vehicleBox.SelectedIndex], total[vehicleBox.SelectedIndex]);
                bill.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết các thông tin cần thiết");
                return;
            }
        }
    }
}
