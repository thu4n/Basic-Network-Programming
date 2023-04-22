using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai3_TCP_Server : Form
    {
        private bool isListening;
        private TcpListener listener;
        private TcpClient client;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<int, TcpClient> tempClients = new Dictionary<int, TcpClient>();
        public Bai3_TCP_Server()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
           
           
        }
     

    }
}
