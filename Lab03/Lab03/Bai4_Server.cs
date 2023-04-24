using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<int,TcpClient> tempClients = new Dictionary<int,TcpClient>();
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
            listener = new TcpListener(IPAddress.Loopback, 16000);
            listener.Start();
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
        private void openSession(TcpClient client)
        {
            int check = 2; // biến xét điều kiện gửi file
            int portNum = ((IPEndPoint)client.Client.RemoteEndPoint).Port;
            clients.Add(client);
            //MessageBox.Show(portNum.ToString());
            tempClients.Add(portNum, client);
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[1000000000];
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
                        if (Char.IsDigit(msg[0]))
                        {
                            string[] packets = msg.Split('<');
                            directMsg(int.Parse(packets[0]), packets[1]);
                        }
                        else
                        {
                            
                            if (msg[0] == '!')
                            {
                                clients.Remove(client);
                                tempClients.Remove(portNum);
                            }
                            // tạo điều kiện gửi file 
                            if (check == -1)
                            {
                                broadcastMsgFile(clients, formatted);         
                                check = 0;
                                continue;
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
        private void broadcastMsg(List<TcpClient> clients ,string msg)
        {
            foreach(var client in clients)
            {
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = Encoding.Unicode.GetBytes(msg);
                nwStream.Write(buffer, 0, buffer.Length);
            }
        }
        private void directMsg(int num, string msg)
        {
            TcpClient recpt = tempClients[num];
            NetworkStream nwStream = recpt.GetStream();
            msg = ">" + msg;
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
