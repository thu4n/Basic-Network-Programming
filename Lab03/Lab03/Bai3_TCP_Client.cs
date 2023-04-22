using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03
{
    public partial class Bai3_TCP_Client : Form
    {
        private NetworkStream nwStream;
        private static ConcurrentDictionary<int, string> clients = new ConcurrentDictionary<int, string>();
        private Dictionary<int, string> dmClients = new Dictionary<int, string>();
        private int currentCount = 0;
        private bool connected = false;
        private Bai3_TCP_Client cl;
        public class Bai3_Client
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public int portNum { get; set; }
            public Bai3_Client() { }
            public Bai3_Client(string name)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 80);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = name;
            }
        }
        Bai3_Client tcpClient;
        public Bai3_TCP_Client()
        {
            InitializeComponent();
        }
        private void Connect()
        {
            string user = "Client";
            tcpClient = new Bai3_Client(user);
            nwStream = tcpClient.client.GetStream();
            clients.TryAdd(tcpClient.portNum, tcpClient.username);
            sendMsg(user + " has joined the chat");
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
            btn_Connect.Enabled = false;
            
        }
            private void sendMsg(string msg)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            nwStream.Write(buffer, 0, buffer.Length);
        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
          
        }
    }
}
