using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Steam Chat";
        }

        private void choiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            clientForm client = new clientForm();
            client.Show();
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            serverForm server = new serverForm();
            server.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
