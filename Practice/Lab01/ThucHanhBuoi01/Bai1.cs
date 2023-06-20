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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            Text = "Bài 01 – Tính tổng 2 số nguyên (Có điều kiện)";
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                int numOne = Int32.Parse(num1.Text);
                int numTwo = Int32.Parse(num2.Text);
                long res = numOne + numTwo;
                result.Text = res.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào!");
                return;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Xảy ra tràn số, vui lòng nhập lại só khác!");
                return;
            }
        }
        
    }
}
