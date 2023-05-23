using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Bai1_Click(object sender, EventArgs e)
        {
            var b1 = new Bài_1();
            b1.Show();
        }
 
        private void Bai2_Click_1(object sender, EventArgs e)
        {
            var b2 = new Bài_2();
            b2.Show();
        }

        private void Bai3_Click_1(object sender, EventArgs e)
        {
            var b3 = new Bai3();
            b3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            var b5 = new Bai5();
            b5.Show();
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            var b6 = new Bai6();
            b6.Show();
        }
    }
}
