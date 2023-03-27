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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            Text = "Bài 02 – Số lớn nhất, nhỏ nhất";
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double numOne = Convert.ToDouble(num1.Text);
                double numTwo = Convert.ToDouble(num2.Text);
                double numThree = Convert.ToDouble(num3.Text);
                double maxNum = 0.0, minNum = 0.0;
                if (numOne > numTwo)
                {
                    maxNum = numOne;
                    minNum = numTwo;
                }
                else
                {
                    minNum = numOne;
                    maxNum = numTwo;
                }
                if (numThree > maxNum)  maxNum = numThree;
                else if (numThree < minNum) minNum = numThree;
                maxRes.Text = maxNum.ToString();
                minRes.Text = minNum.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số thực vào!");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Xảy ra tràn số, vui lòng nhập lại só khác!");
                return;
            }
        }

        private void maxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            num3.Clear();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numOneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
