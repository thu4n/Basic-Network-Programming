using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04_TCP_Chatroom
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
