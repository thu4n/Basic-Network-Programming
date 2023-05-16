using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai4_Server : Form
    {
        private bool isListening;
        private TcpListener listener;
        private TcpClient client;
        private Dictionary<int,TcpClient> tempClients = new Dictionary<int,TcpClient>();
        public Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();
        public Bai4_Server()
        {
            InitializeComponent();
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                listenBtn.Text = "Stop listening";
                listenBtn.BackColor = Color.Red;
                isListening = true;
                monitorConnection();
            }
            else
            {
                listenBtn.Text = "Start Listening";
                listenBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
                string msg = "-- Server has stopped listening --";
                broadcastMsg(clients, msg);
                chatBox.Text += msg + "\r\n";
                isListening = false;
                listener.Stop();
            }
            
        }
        private void monitorConnection()
        {
            string str = GetLocalIPAddress();
            IPAddress localIP = IPAddress.Parse(str);
            listener = new TcpListener(localIP, 16000);
            listener.Start();
            MessageBox.Show("Server's IP address is " + str);
            Task.Run(async () =>
            {
                    while (isListening)
                    {
                        client = await listener.AcceptTcpClientAsync();
                        Thread thread = new Thread(() => openSession(client)) // Mở một session cho mỗi client
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
        private void openSession(TcpClient client)
        {
            int check = 2; // biến xét điều kiện gửi file
            int portNum = ((IPEndPoint)client.Client.RemoteEndPoint).Port;
            tempClients.Add(portNum, client);
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[10000000];
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
                        
                        if (msg[0] == '<')
                        {
                            directMsg(msg);
                        }
                        else
                        {
                            
                            if (msg[0] == '!')
                            {
                                tempClients.Remove(portNum);
                                removeClient(msg);
                            }
                            // tạo điều kiện gửi file 
                            else if (check == -1)
                            {
                                //broadcastMsgFile(clients, formatted);         
                                check = 0;
                                continue;
                            }
                            else if (msg[0] == '$')
                            {
                                addClient(client, msg);
                            }
                            broadcastMsg(clients, msg);
                            if (msg[0] == '+')
                            {
                                check = -1;
                            }
                        }
                        Invoke(new MethodInvoker(delegate ()
                        {
                            // xét điều kiện nếu như gửi data từ file thì sẽ bỏ qua bước thêm msg vào chatbox
                            if (check == 0)
                            {
                                check = 2;

                            }
                            else
                            {
                                chatBox.Text += msg + "\r\n";
                            }
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
        private void addClient(TcpClient client, string msg)
        {
            // Tách tên người dùng ra trong đây
            int end = msg.IndexOf(' ');
            string userName = msg.Substring(1, end - 1);
            clients.Add(userName, client);
            updateClient();
        }
        private void removeClient(string msg)
        {
            int end = msg.IndexOf(' ');
            string userName = msg.Substring(1, end);
            MessageBox.Show(userName);
            clients.Remove(userName);
            updateClient();
        }
        private void updateClient()
        {
            string clientList = "^";
            // Cap nhat roi broadcast cai string nay cho ben client
            foreach(var client in clients)
            {
                clientList += client.Key + ",";
            }
            clientList = clientList.TrimEnd(',');
            MessageBox.Show(clientList);
            broadcastMsg(clients, clientList);
        }

        // gửi data file
        private void broadcastMsgFile(List<TcpClient> clients, byte[] data)
        {
            foreach (var client in clients)
            {
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = data;
                nwStream.Write(buffer, 0, buffer.Length);
            }
        }
        private void broadcastMsg(Dictionary<string,TcpClient> clients ,string msg)
        {
            foreach(var client in clients)
            {
                NetworkStream nwStream = client.Value.GetStream();
                byte[] buffer = Encoding.Unicode.GetBytes(msg);
                nwStream.Write(buffer, 0, buffer.Length);
                IPEndPoint remote = client.Value.Client.RemoteEndPoint as IPEndPoint;
                //MessageBox.Show("remote address is: " + remote.Address.ToString()); // Luu dia chi nay vo dau do

            }
        }
        private void directMsg(string packet)
        {
            packet = packet.TrimStart('<');
            MessageBox.Show($"{packet}");
            string[] packets = packet.Split(',');
            string rcpt = packets[1];
            TcpClient recpt = clients[rcpt];
            NetworkStream nwStream = recpt.GetStream();
            string msg = "<" + packets[0] + ": " + packets[2];    
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
            nwStream.Write(buffer, 0, buffer.Length);
        }

        private void Bai4_Server_Load(object sender, EventArgs e)
        {
            chatBox.Text = "";
            isListening = false;
            tempClients.Clear();
        }

        private void Bai4_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isListening)
            {
                string msg = "-- Server has stopped listening --";
                broadcastMsg(clients, msg);
                isListening = false;
                listener.Stop();
            }
            Bai4.serverOpen = false;
        }
    }
}
