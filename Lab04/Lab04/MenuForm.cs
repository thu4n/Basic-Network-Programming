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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Bai1Btn_Click(object sender, EventArgs e)
        {
            var form = new Bai_1();
            form.Show();
        }

        private void Bai2Btn_Click(object sender, EventArgs e)
        {
            var form = new Bai_2();
            form.Show();
        }

        private void Bai3Btn_Click(object sender, EventArgs e)
        {
            var form = new Bai_3();
            form.Show();
        }

        private void Bai4Btn_Click(object sender, EventArgs e)
        {
            var form = new Bai_4();
            form.Show();
        }

        private void Bai5Btn_Click(object sender, EventArgs e)
        {
            var form = new Bai5();
            form.Show();
        }

        private void Bai6Btn_Click(object sender, EventArgs e)
        {
            var form = new Bai6();
            form.Show();
        }
    }
}
