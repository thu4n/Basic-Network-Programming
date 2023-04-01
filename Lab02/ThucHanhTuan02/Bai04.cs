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
            previewTB.Text += nameTB.Text + "\r\n" + mssvTB.Text + "\r\n" + phoneTB.Text + "\r\n" + firstGradeTB.Text + "\r\n" + secondGradeTB.Text + "\r\n" + thirdGradeTB.Text + "\r\n\r\n";
        }
    }
}
