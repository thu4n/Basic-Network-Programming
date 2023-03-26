using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhBuoi01
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
            Text = "Bài 07 – Bài tập tổng hợp";
        }

        private void Bai8_Load(object sender, EventArgs e)
        {

        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAdd = networkTB.Text;
                int subnetMask = Int32.Parse(subnetMaskTB.Text);
                string[] octets = ipAdd.Split('.');
                int firstOctet = Int32.Parse(octets[0]);
                int secondOctet = Int32.Parse(octets[1]);
                int thirdOctet = Int32.Parse(octets[2]);
                int lastOctet = Int32.Parse(octets[3]);
                int subnetNum = Int32.Parse(subnetTB.Text);
                if (firstOctet > 255 || secondOctet > 255 || thirdOctet > 255 || lastOctet > 255)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ IP private thuộc các lớp A,B hoặc C");
                    return;
                }
                if(subnetNum <= 1)
                {
                    MessageBox.Show("Vui lòng nhập số lượng mạng con lớn hơn 1");
                    return;
                }
                switch (firstOctet)
                {
                    case 10:
                        {
                            if (secondOctet == 255 && thirdOctet == 255 && lastOctet == 255)
                            {
                                MessageBox.Show("Không thể chia mạng con với địa chỉ này");
                                return;
                            }
                            if(subnetMask != 8)
                            {
                                MessageBox.Show("Subnetmask mặc nhiên không hợp lệ");
                                return;
                            }
                            if (subnetNum > 4194302)
                            {
                                MessageBox.Show("Vui lòng nhập số lượng mạng con nhỏ hơn");
                                return;
                            }
                            break;
                        }
                    case 172:
                        {
                            if(secondOctet < 16 || secondOctet > 31)
                            {
                                MessageBox.Show("Vui lòng nhập địa chỉ IP private thuộc các lớp A,B hoặc C");
                                return;
                            }
                            if (thirdOctet == 255 && lastOctet == 255)
                            {
                                MessageBox.Show("Không thể chia mạng con với địa chỉ này");
                                return;
                            }
                            if (subnetMask != 16)
                            {
                                MessageBox.Show("Subnetmask mặc nhiên không hợp lệ");
                                return;
                            }
                            if (subnetNum > 16382)
                            {
                                MessageBox.Show("Vui lòng nhập số lượng mạng con nhỏ hơn");
                                return;
                            }
                            break;
                        }
                    case 192:
                        {
                            if (secondOctet != 168)
                            {
                                MessageBox.Show("Vui lòng nhập địa chỉ IP private thuộc các lớp A,B hoặc C");
                                return;
                            }
                            if (thirdOctet == 255 && lastOctet == 255)
                            {
                                MessageBox.Show("Không thể chia mạng con với địa chỉ này");
                                return;
                            }
                            if (subnetMask != 24)
                            {
                                MessageBox.Show("Subnetmask mặc nhiên không hợp lệ");
                                return;
                            }
                            if (subnetNum > 62)
                            {
                                MessageBox.Show("Vui lòng nhập số lượng mạng con nhỏ hơn");
                                return;
                            }
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Vui lòng nhập địa chỉ IP private thuộc các lớp A,B hoặc C");
                            return;
                        }
                }
                Bai8_Result res = new Bai8_Result(firstOctet,secondOctet,thirdOctet,lastOctet,subnetNum,subnetMask);
                res.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng của một địa chỉ IP và subnetmask vào");
            }
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
