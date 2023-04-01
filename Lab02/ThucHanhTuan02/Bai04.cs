using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhTuan02
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            previewTB.ScrollBars = ScrollBars.Vertical;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string[] vals = { nameTB.Text, mssvTB.Text, phoneTB.Text, firstGradeTB.Text, secondGradeTB.Text, thirdGradeTB.Text };
           for(int i = 0; i < vals.Length; i++)
            {
                if (i == 0)
                {
                    foreach(char c in vals[i])
                    {
                        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                        {
                            MessageBox.Show("Vui lòng nhập tên đúng định dạng");
                            return;
                        }
                    }
                }
                else if (i == 1 || i == 2)
                {
                    if (i == 2 && (vals[i][0] != '0' || vals[i].Length < 1))
                    {
                        MessageBox.Show("SĐT phải có số 0 ở đầu và có đủ 10 chữ số");
                        return;
                    }
                    if (!int.TryParse(vals[i], out int res))
                    {
                        MessageBox.Show("Vui lòng nhập MSSV và SĐT dưới định dạng số nguyên");
                        return;
                    }
                }
                else
                {
                    if(!float.TryParse(vals[i], out float res) || res < 0 || res > 10)
                    {
                        MessageBox.Show("Vui lòng nhập điểm các môn học dưới dạng số thực từ 0 đến 10");
                        return;
                    }
                }
            }
            previewTB.Text += nameTB.Text + "\r\n" + mssvTB.Text + "\r\n" + phoneTB.Text + "\r\n" + firstGradeTB.Text + "\r\n" + secondGradeTB.Text + "\r\n" + thirdGradeTB.Text + "\r\n\r\n";
            nameTB.Text = "";
            mssvTB.Text = "";
            phoneTB.Text = "";
            firstGradeTB.Text = "";
            secondGradeTB.Text = "";
            thirdGradeTB.Text = "";
        }
    }
}
