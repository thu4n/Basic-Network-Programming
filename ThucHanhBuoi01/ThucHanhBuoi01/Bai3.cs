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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            Text = "Bài 3 - Đọc số";
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void numTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int res = Int32.Parse(numTB.Text);
                if(res < 0 || res > 9)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 cho đến 9 vào!");
                    return;
                }
                switch (res)
                {
                    case 0:
                        {
                            resTB.Text = "Không";
                            break;
                        }
                    case 1:
                        {
                            resTB.Text = "Một";
                            break;
                        }
                    case 2:
                        {
                            resTB.Text = "Hai";
                            break;
                        }
                    case 3:
                        {
                            resTB.Text = "Ba";
                            break;
                        }
                    case 4:
                        {
                            resTB.Text = "Bốn";
                            break;
                        }
                    case 5:
                        {
                            resTB.Text = "Năm";
                            break;
                        }
                    case 6:
                        {
                            resTB.Text = "Sáu";
                            break;
                        }
                    case 7:
                        {
                            resTB.Text = "Bảy";
                            break;
                        }
                    case 8:
                        {
                            resTB.Text = "Tám";
                            break;
                        }
                    case 9:
                        {
                            resTB.Text = "Chín";
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào!");
            }
            catch (Exception)
            {
                MessageBox.Show("Số nhập không hợp lệ");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resTB.Text = "";
            numTB.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
