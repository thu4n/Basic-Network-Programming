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
    public partial class Bai4 : Form
    {
        public static bool serverOpen;
        public Bai4()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Bai4_Client client = new Bai4_Client();
            client.Show();
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            if(!serverOpen) 
            {
                Bai4_Server server = new Bai4_Server();
                server.Show();
                serverOpen = true;
            }
            else
            {
                MessageBox.Show("There is already one server running");
                return;
            }
        }
    }
}
