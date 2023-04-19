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
        private static ConcurrentDictionary<int, string> clients = new ConcurrentDictionary<int, string>(); //Sử dụng ConcurrentDictionary vì dữ liệu của type này là thread-safe
        private int currentCount = 0;
        private bool connected = false;
        public class Bai4_TcpClient
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public int portNum { get; set; }
            public Bai4_TcpClient() { }
            public Bai4_TcpClient(string str)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 16000);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = str;
            }
            public string nameTag()
            {
                if (username != "" && portNum > 0)
                    return username + "#" + portNum;
                return "";
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
            if (!connected)
            {
                try
                {
                    titleLabel0.Text = "You are connected to the server";
                    titleLabel0.ForeColor = ColorTranslator.FromHtml("#457ad0");
                    connected = true;
                    connectBtn.Text = "Disconnect";
                    connectBtn.BackColor = Color.Red;
                    tcpClient = new Bai4_TcpClient(usernameTB.Text);
                    usernameTB.ReadOnly = true;
                    nwStream = tcpClient.client.GetStream();
                    clients.TryAdd(tcpClient.portNum, tcpClient.username);
                    sendMsg(tcpClient.nameTag() + " has joined the chat");
                    getMsg();
                    displayClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                connected = false;
                connectBtn.Text = "Connect";
                connectBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
                sendMsg(tcpClient.nameTag() + " has left the chat");
                nwStream.Close();
                tcpClient.client.Close();
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
                        if (currentCount != clients.Count) // Cập nhật số client ở thread hiện tại
                        {
                            displayClients();
                        }
                        chatBox.Text += msg + "\r\n";
                    }));
                }
                nwStream.Close();
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
            string msg = tcpClient.nameTag() + ": " + textBox.Text;
            sendMsg(msg);
            textBox.Clear();
        }
        private void displayClients()
        {
            listBox1.Items.Clear();
            foreach(var client in clients)
            {
                listBox1.Items.Add(client.Value + "#" + client.Key.ToString());
            }
            currentCount = clients.Count;
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
