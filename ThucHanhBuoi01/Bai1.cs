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
                int res = numOne + numTwo;
                result.Text = res.ToString();
            }
            catch(FormatException f)
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào!");
                return;
            }
            catch(OverflowException o)
            {
                MessageBox.Show("Xảy ra tràn số, vui lòng nhập lại só khác!");
                return;
            }
            
        }
        
    }
}
