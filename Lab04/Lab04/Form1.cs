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
            Bài_1 b1 = new Bài_1();
            b1.Show();
        }


        private void Bai2_Click(object sender, EventArgs e)
        {
            Bài_2 b2 = new Bài_2();
            b2.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bài_3 b3 = new Bài_3();
            b3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Bài_4 b4 = new Bài_4();
            b4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bài_5 b5 = new Bài_5();
            b5.Show();
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            Bài_6 b6 = new Bài_6();
            b6.Show();
        }

    }
}
