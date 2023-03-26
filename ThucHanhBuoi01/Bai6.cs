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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            Text = "Bài 5 - Tính một số kết quả cho 2 số nguyên dương";
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(num1TB.Text);
                int b = Int32.Parse(num2TB.Text);
                if (a < 0 || b < 0)
                {
                    MessageBox.Show("Nhập số nguyên dương vào");
                    return;
                }
                long aFactorial = factorialCalc(a);
                long bFactorial = factorialCalc(b);
                long s1 = sumCalc(a);
                long s2 = sumCalc(b);
                long s3 = a;
                for(int i = 2; i <= b; i++)
                {
                    s3 += power(a, i);
                }
                aFactorialLabel.Text = "A! = " + aFactorial.ToString();
                bFactorialLabel.Text = "B! = " + bFactorial.ToString();
                if (a > 4)
                {
                    s1Label.Text = "S1 = 1 + 2 + 3 + 4 ... + A = " + s1.ToString();
                }
                else if (a > 1) s1Label.Text = "S1 = 1 + ... A = " + s1.ToString();
                else if (a == 1) s1Label.Text = "S1 = 1";
                if (b > 4)
                {
                    s2Label.Text = "S2 = 1 + 2 + 3 + 4 ... + A = " + s2.ToString();
                    s3Label.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + s3.ToString();
                }
                else if (b > 1)
                {
                    s2Label.Text = "S2 = 1 + ... A = " + s2.ToString();
                    s3Label.Text = "S3 = A^1 + ... A^B = " + s3.ToString();
                }
                else if (b == 1)
                { 
                    s2Label.Text = "S2 = 1";
                    s3Label.Text = "S3 = A^1 = " + s3.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào!!!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Vui lòng nhập số bé hơn, đã xảy ra tràn số");
            }
        }
        private long factorialCalc(int num)
        {
            long res = 1;
            for(int i = 1; i <= num; i++) res *= i;
            return res;
        }
        private long sumCalc(int num)
        {
            long res = 0;
            for(int i = 1; i <= num; i++)
            {
                res += i;
            }
            return res;
        }
        private long power(int num, int time)
        {
            long res = 1;
            for (int i = 0; i < time; i++) res *= num;
            return res;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            num1TB.Text = "";
            num2TB.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
