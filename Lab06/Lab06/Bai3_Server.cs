using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Bai3_Server : Form
    {
        private bool isListening;
        private TcpListener listener;
        private TcpClient client;
        private Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();
        public Bai3_Server()
        {
            InitializeComponent();
        }

        private void Bai3_Server_Load(object sender, EventArgs e)
        {

        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                listenBtn.Text = "Stop listening";
                listenBtn.BackColor = Color.Red;
                isListening = true;
                MonitorConnection();
            }
            else
            {
                listenBtn.Text = "Start Listening";
                listenBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
                string msg = "-- Server has stopped listening --";
                //broadcastMsg(clients, msg);
                chatBox.Text += msg + "\r\n";
                isListening = false;
                listener.Stop();
            }
        }
        private void MonitorConnection()
        {
            string str = GetLocalIPAddress();
            IPAddress localIP = IPAddress.Parse(str);
            listener = new TcpListener(localIP, 16000);
            listener.Start();
            ipTB.Text = str;
            Task.Run(async () =>
            {
                while (isListening)
                {
                    client = await listener.AcceptTcpClientAsync();
                    Thread thread = new Thread(() => OpenSession(client)) // Mở một session cho mỗi client
                    {
                        IsBackground = true
                    };
                    thread.Start();
                }
            });
        }
        public static string GetLocalIPAddress()
        {
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in interfaces.Where(x => x.OperationalStatus == OperationalStatus.Up)) // Dam bao trang thai interface la Up
            {
                if (adapter.Name.ToLower() == "wi-fi")
                {
                    var props = adapter.GetIPProperties();
                    var result = props.UnicastAddresses.FirstOrDefault(x => x.Address.AddressFamily == AddressFamily.InterNetwork);
                    if (result != null)
                    {
                        var ip = result.Address.ToString();
                        return ip;
                    }
                }
            }
            return null;
        }
        private void OpenSession(TcpClient client)
        {
            int portNum = ((IPEndPoint)client.Client.RemoteEndPoint).Port;
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[1000];
            while (client.Connected && isListening)
            {
                try
                {
                    if (nwStream.DataAvailable) // Có data trên stream thì mới đọc
                    {
                        int byteCount = nwStream.Read(buffer, 0, buffer.Length);
                        byte[] formatted = new byte[byteCount];
                        Array.Copy(buffer, formatted, byteCount);
                        string msg = Encoding.Unicode.GetString(formatted);
                        if (msg[0] == '!')
                        {
                            RemoveClient(msg);
                        }
                        else if (msg[0] == '$')
                        {
                            AddClient(client, msg);
                        }
                        BroadcastMsg(clients, msg);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            chatBox.Text += msg + "\r\n";
                        }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            nwStream.Close();
            client.Close();
        }
        private void AddClient(TcpClient client, string msg)
        {
            // Tách tên người dùng ra trong đây
            int end = msg.IndexOf(' ');
            string userName = msg.Substring(1, end - 1);
            clients.Add(userName, client);
        }
        private void RemoveClient(string msg)
        {
            int end = msg.IndexOf(' ');
            string userName = msg.Substring(1, end);
            clients.Remove(userName);
        }
        private void BroadcastMsg(Dictionary<string, TcpClient> clients, string msg)
        {
            foreach (var client in clients)
            {
                NetworkStream nwStream = client.Value.GetStream();
                byte[] buffer = Encoding.Unicode.GetBytes(msg);
                nwStream.Write(buffer, 0, buffer.Length);
                //IPEndPoint remote = client.Value.Client.RemoteEndPoint as IPEndPoint;
                //MessageBox.Show("remote address is: " + remote.Address.ToString()); // Luu dia chi nay vo dau do
            }
        }
    }
}
