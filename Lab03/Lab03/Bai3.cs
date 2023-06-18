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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void TCP_Client_Click(object sender, EventArgs e)
        {
            Bai3_TCP_Client client = new Bai3_TCP_Client();
            client.Show();
        }

        private void TCP_Server_Click(object sender, EventArgs e)
        {
            Bai3_TCP_Server server = new Bai3_TCP_Server();
            server.Show();
        }
    }
}
