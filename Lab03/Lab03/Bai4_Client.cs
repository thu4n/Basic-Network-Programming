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

namespace Lab03
{
    public partial class Bai4_Client : Form
    {

        public class Bai4_TcpClient
        {
            public TcpClient client;
            public NetworkStream nwStream;
            public string username;
            public int portNum;
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
                nwStream = client.GetStream();
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
                getMsg();
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
                while (true)
                {                    
                    int byte_count = await tcpClient.nwStream.ReadAsync(received, 0, received.Length);
                    byte[] formatted = new byte[byte_count];
                    Array.Copy(received, formatted, byte_count);
                    string msg = Encoding.ASCII.GetString(formatted);
                    Invoke(new MethodInvoker(delegate ()
                    {
                        chatBox.Text += msg + "\r\n";
                    }));
                }
            });
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "") return;
            string msg = tcpClient.username + "#" + tcpClient.portNum.ToString() + ": " + textBox.Text;
            byte[] test = Encoding.ASCII.GetBytes(msg);
            tcpClient.nwStream.Write(test, 0, test.Length);
            textBox.Clear();
        }
    }
}
