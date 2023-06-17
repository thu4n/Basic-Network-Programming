using System;
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
using static Lab06.Bai3_Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab06
{
    public partial class Bai3_Client : Form
    {
        private NetworkStream nwStream;
        private int currentCount = 0;
        private bool connected = false;
        public class Bai3_TcpClient
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public int portNum { get; set; }
            public Bai3_TcpClient() { }
            public Bai3_TcpClient(string name, IPAddress ip)
            {
                client = new TcpClient();
                client.Connect(ip, 16000);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = name;
            }
            public string nameTag()
            {
                if (username != "" && portNum > 0)
                    return username + "#" + portNum;
                return "";
            }

        }
        Bai3_TcpClient tcpClient;
        public Bai3_Client()
        {
            InitializeComponent();
        }

        private void Bai3_Client_Load(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }
            if (!connected)
            {
                try
                {
                    string str = ipTB.Text;
                    IPAddress localIP = IPAddress.Parse(str);
                    tcpClient = new Bai3_TcpClient(usernameTB.Text, localIP);
                    nwStream = tcpClient.client.GetStream();
                    //clients.TryAdd(tcpClient.portNum, tcpClient.username);
                    SendMsg("$" + tcpClient.nameTag() + " has joined the chat");
                    GetMsg();
                    //displayClients();
                }
                catch (SocketException se)
                {
                    if (se.SocketErrorCode == SocketError.ConnectionRefused)
                    {
                        MessageBox.Show("There is no server listening at the moment");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                /*titleLabel0.Text = "You are connected to the server";
                titleLabel0.ForeColor = ColorTranslator.FromHtml("#457ad0");*/
                connected = true;
                connectBtn.Text = "Disconnect";
                ipTB.ReadOnly = true;
                connectBtn.BackColor = Color.Red;
                usernameTB.ReadOnly = true;
            }
            else
            {
                //clients.TryRemove(tcpClient.portNum, out string temp);
                SendMsg("!" + tcpClient.nameTag() + " has left the chat !");
                Disconnect();
            }
        }
        private void GetMsg()
        {
            byte[] received = new byte[1000]; // chỉnh độ dài
            Task.Run(async () =>
            {
                while (tcpClient.client.Connected)
                {
                    int byte_count = await nwStream.ReadAsync(received, 0, received.Length);
                    byte[] formatted = new byte[byte_count];
                    Array.Copy(received, formatted, byte_count);
                    string msg = Encoding.Unicode.GetString(formatted);
                    Invoke(new MethodInvoker(delegate ()
                    {
                       chatBox.Text += msg + "\r\n";
                    }));
                    /*if (msg[0] == '-')
                    {
                        disconnect();
                    }*/
                }
                nwStream.Close();
                tcpClient.client.Close();
            });
        }
        private void SendMsg(string msg)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
            nwStream.Write(buffer, 0, buffer.Length);
        }
        private void Disconnect()
        {
            /*titleLabel0.Text = "You are not connected to the server";
            titleLabel0.ForeColor = Color.Black;*/
            connected = false;
            connectBtn.Text = "Connect";
            connectBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
            ipTB.ReadOnly = false;
            usernameTB.ReadOnly = false;
            nwStream.Close();
            tcpClient.client.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (typeTB.Text.Length == 0) return;
            SendMsg(typeTB.Text);
            typeTB.Clear();
        }
    }
}
