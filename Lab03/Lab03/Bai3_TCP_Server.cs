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
            mess_Txt.Text += "Server started!" + Environment.NewLine;
            btn_Listen.Enabled = false;
            isListening = true;
            monitorConnection();
        }
        private void monitorConnection()
        {
            listener = new TcpListener(IPAddress.Loopback, 8000);
            listener.Start();
            Task.Run(async () =>
            {
                while (isListening)
                {
                    client = await listener.AcceptTcpClientAsync();
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
            int portNum = ((IPEndPoint)client.Client.RemoteEndPoint).Port;
            clients.Add(client);
            tempClients.Add(portNum, client);
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[1024];
            while (client.Connected && isListening)
            {
                try
                {
                    if (nwStream.DataAvailable)
                    {
                        int byteCount = nwStream.Read(buffer, 0, buffer.Length);
                        byte[] formatted = new byte[byteCount];
                        Array.Copy(buffer, formatted, byteCount);
                        string msg = Encoding.Unicode.GetString(formatted);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            mess_Txt.Text +=  msg + Environment.NewLine;
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
    }
}
