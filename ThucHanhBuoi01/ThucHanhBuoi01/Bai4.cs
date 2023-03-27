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
    public partial class Bai4 : Form
    {
        string[] units = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        string[] tens = { "","Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };
        public Bai4()
        {
            InitializeComponent();
            Text = "Bài 3.1 – Đọc số nâng cao";
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            string str = numTB.Text;

            if(str.Length > 13)
            {
                MessageBox.Show("Vui lòng nhập số có ít hơn hoặc bằng 12 chữ số");
                return;
            }
            if (str.Length == 13 && str[0] != '-')
            {
                 MessageBox.Show("Vui lòng nhập số có ít hơn hoặc bằng 12 chữ số");
                 return;
            }
            if (str.IndexOf(',') != -1 || str.IndexOf('.') != -1)
            {
                MessageBox.Show("Số thập phân tạm thời chưa được hỗ trợ, vui lòng nhập số nguyên");
                return;
            }
            try
            {
                bool neg = false;
                Int64 num = long.Parse(str);
                if(num < 0)
                {
                    num *= -1;
                    neg = true;
                }
                string res = "";
                if (!neg) res = convertString(num);
                else res = "Âm " + convertString(num);
                resTB.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string convertString(Int64 num)
        {
            try
            {
                if (num < 10) return units[num];
                if (num < 100 && num % 10 == 0) return tens[num / 10];
                if (num < 100 && num % 10 != 0)
                {
                    if (num % 10 == 5) return tens[num / 10] + " Lăm";
                    if (num % 10 == 1) return tens[num / 10] + " Mốt";
                    return tens[num / 10] + " " + units[num % 10];
                }
                if (num < 1000)
                {
                    if (num % 100 < 10 && num % 100 > 0) return units[num / 100] + " Trăm Lẻ " + units[num % 100];
                    if (num % 100 > 10) return units[num / 100] + " Trăm " + convertString(num % 100);
                    if (num % 100 == 0) return units[num / 100] + " Trăm";

                }
                if (num < 1000000)
                {
                    if (num % 1000 == 0) return convertString(num / 1000) + " Ngàn";
                    if (num % 1000 > 0)
                    {
                        if (num % 1000 < 10)
                            return convertString(num / 1000) + " Ngàn Lẻ " + convertString(num % 1000);
                        if (num % 1000 < 100) return convertString(num / 1000) + " Ngàn Không Trăm " + convertString(num % 1000);
                        return convertString(num / 1000) + " Ngàn " + convertString(num % 1000);
                    }
                }
                if (num < 1000000000)
                {
                    if (num % 1000000 == 0) return convertString(num / 1000000) + " Triệu";
                    if (num % 1000000 > 0)
                    {
                        if (num % 1000000 < 10)
                            return convertString(num / 1000000) + " Triệu Lẻ " + convertString(num % 1000000);
                        if (num % 1000000 < 10000) return convertString(num / 1000000) + " Triệu Không Trăm Lẻ " + convertString(num % 1000000);
                        if (num % 1000000 < 100000) return convertString(num / 1000000) + " Triệu Không Trăm " + convertString(num % 1000000);
                        return convertString(num / 1000000) + " Triệu " + convertString(num % 1000000);
                    }
                }
                if (num % 1000000000 == 0) return convertString(num / 1000000000) + " Tỉ";
                if (num % 1000000000 > 0)
                {
                    if (num % 1000000000 < 10)
                        return convertString(num / 1000000000) + " Tỉ Lẻ " + convertString(num % 1000000000);
                    if (num % 1000000000 < 10000000) return convertString(num / 1000000000) + " Tỉ Không Trăm Lẻ " + convertString(num % 1000000000);
                    if (num % 1000000000 < 100000000) return convertString(num / 1000000000) + " Tỉ Không Trăm " + convertString(num % 1000000000);
                    return convertString(num / 1000000000) + " Tỉ " + convertString(num % 1000000000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
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
