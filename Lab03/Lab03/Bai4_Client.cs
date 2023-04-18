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
        private TcpClient client;
        private NetworkStream nwStream;
        private string username;
        private int portNum;
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
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 16000);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = usernameTB.Text;
                usernameTB.ReadOnly = true;
                nwStream = client.GetStream();
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
                    int byte_count = await nwStream.ReadAsync(received, 0, received.Length);
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
            string msg = username + "#" + portNum.ToString() + ": " + textBox.Text;
            byte[] test = Encoding.ASCII.GetBytes(msg);
            nwStream.Write(test, 0, test.Length);
            textBox.Clear();
        }
    }
}
