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
        private bool connected = false;
        public class Bai3_Client
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public int portNum { get; set; }
            public Bai3_Client() { }
            public Bai3_Client(string name)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 8000);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = name;
            }
        }
        Bai3_Client tcpClient;
        public Bai3_TCP_Client()
        {
            InitializeComponent();
        }
        string user = "Client";
        private bool Connect()
        {
            try
            {
                tcpClient = new Bai3_Client(user);
                nwStream = tcpClient.client.GetStream();
                clients.TryAdd(tcpClient.portNum, tcpClient.username);
                SendMsg("Connection accepted from " + IPAddress.Loopback + ":" + tcpClient.portNum);
            }
            catch (SocketException)
            {
                MessageBox.Show("There is no server listening at the moment");
                return false;
            }
            return true;
        }
        private void Disconnect()
        {
            SendMsg(IPAddress.Loopback + ":" + tcpClient.portNum+" has left");
            nwStream.Close();
            tcpClient.client.Close();
            
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (Connect() == true)
            {
                btn_Connect.Enabled = false;
                connected = true;
                btn_Disconnect.Enabled = true;
            }
        }
            private void SendMsg(string msg)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
             nwStream.Write(buffer, 0, buffer.Length);
        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            connected = false;
            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (Txting.Text == "") return;
            if (connected==true)
            {
                SendMsg("From Client : "+Txting.Text);
                Txting.Clear();
            }
          else
            {
                Txting.Clear();
                return;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai3_TCP_Client_Load(object sender, EventArgs e)
        {
            btn_Disconnect.Enabled = false;
        }
    }
}
