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
            var b3 = new Bài_3();
            b3.Show();
        }
    }
}
