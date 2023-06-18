using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }


        private void Udp_C_Click(object sender, EventArgs e)
        {
            Bai1_Client client = new Bai1_Client();
            client.Show();
        }
        private void Udp_S_Click(object sender, EventArgs e)
        {
            Bai1_Server Server = new Bai1_Server();
            Server.Show();
        }
    }
}
