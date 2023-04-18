using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab03
{
    public partial class Bai4_Client : Form
    {
        private NetworkStream nwStream;
        private static ConcurrentDictionary<int, string> clients = new ConcurrentDictionary<int, string>();
        private int currentCount = 0;
        public class Bai4_TcpClient
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public int portNum { get; set; }
            public Bai4_TcpClient()
            {
                // Constructor mặc định, không dùng nên để rỗng
            }
            public Bai4_TcpClient(string str)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 16000);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = str;
            }

        }
        Bai4_TcpClient tcpClient;
        public Bai4_Client()
        {
            InitializeComponent();
        }

        private void Bai4_Client_Load(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }
            try
            {
                tcpClient = new Bai4_TcpClient(usernameTB.Text);
                usernameTB.ReadOnly = true;
                nwStream = tcpClient.client.GetStream();
                string str = tcpClient.username + "#" + tcpClient.portNum.ToString();
                clients.TryAdd(tcpClient.portNum, tcpClient.username);
                sendMsg("hello moi vo");
                getMsg();
                displayClients();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void getMsg()
        {
            byte[] received = new byte[1024];
            Task.Run(async () =>
            {
                while (tcpClient.client.Connected)
                {                    
                    int byte_count = await nwStream.ReadAsync(received, 0, received.Length);
                    byte[] formatted = new byte[byte_count];
                    Array.Copy(received, formatted, byte_count);
                    string msg = Encoding.ASCII.GetString(formatted);
                    Invoke(new MethodInvoker(delegate ()
                    {
                        if (currentCount != clients.Count)
                        {
                            displayClients();
                        }
                        chatBox.Text += msg + "\r\n";
                    }));
                }
                tcpClient.client.Close();
                clients.TryRemove(tcpClient.portNum, out string temp);
            });
        }
        private void sendMsg(string msg)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(msg);
            nwStream.Write(buffer, 0, buffer.Length);
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "") return;
            string msg = tcpClient.username + "#" + tcpClient.portNum.ToString() + ": " + textBox.Text;
            sendMsg(msg);
            textBox.Clear();
        }
        private void displayClients()
        {
            currentCount = clients.Count;
            listBox1.Items.Clear();
            foreach(var client in clients)
            {
                listBox1.Items.Add(client.Value + "#" + client.Key.ToString());
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                MessageBox.Show("ok");
            }
        }
    }
}
