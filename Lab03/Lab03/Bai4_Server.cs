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
    public partial class Bai4_Server : Form
    {
        private bool isListening;
        private TcpListener listener;
        private TcpClient client;
        private List<TcpClient> clients = new List<TcpClient>();
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
                monitorConnection();
                isListening = true;
            }
            else
            {
                listenBtn.Text = "Start Listening";
                listenBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
                MessageBox.Show("Server stopped listening");
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
                while (true)
                {
                    client = await listener.AcceptTcpClientAsync();
                    if (client.Connected)
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            //chatBox.Text += client.
                        }));
                    }
                    Thread thread = new Thread(() => openSession(client)) 
                    {
                        IsBackground = true
                    };
                    thread.Start();
                }
            });
            
        }
        private void openSession(TcpClient client)
        {
            clients.Add(client);
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[1024];
            while (client.Connected)
            {
                int byteCount = nwStream.Read(buffer, 0, buffer.Length);
                byte[] formatted = new byte[byteCount];
                Array.Copy(buffer, formatted, byteCount);
                string msg = Encoding.ASCII.GetString(formatted);
                Invoke(new MethodInvoker(delegate ()
                {
                    chatBox.Text += msg + "\r\n";
                }));
                broadcastMsg(clients, msg);
            }
        }
        private void broadcastMsg(List<TcpClient> clients ,string msg)
        {
            foreach(var client in clients)
            {
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = Encoding.ASCII.GetBytes(msg);
                nwStream.Write(buffer, 0, buffer.Length);
            }
        }

        private void Bai4_Server_Load(object sender, EventArgs e)
        {
            chatBox.Text = "";
            isListening = false;
        }
    }
}
