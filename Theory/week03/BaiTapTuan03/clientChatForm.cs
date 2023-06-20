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

namespace BaiTapTuan03
{
    public partial class clientChatForm : Form
    {
        private IPEndPoint server = null;
        private IPEndPoint endPoint = null;
        private Socket socket = null;
        private IPAddress ip = null;
        private int sPort = 0;
        public clientChatForm()
        {
            InitializeComponent();
            Text = "Steam Chat Room";
        }
        public clientChatForm(string ipadd, int serverPort, string username)
        {
            InitializeComponent();
            Text = "Steam Chat Room";
            ip = IPAddress.Parse(ipadd);
            ipTextBox.Text = ipadd;
            nameTextBox.Text = username;
            serverPortTB.Text = serverPort.ToString();
            sPort = serverPort;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server = new IPEndPoint(ip, sPort);
            socket.Connect(server);
            StartSession();
            endPoint = (IPEndPoint)socket.LocalEndPoint;
            clientPortTB.Text = endPoint.Port.ToString();

        }
        private void StartSession()
        {
            byte[] bufferByte = new byte[1024];
            Task.Factory.StartNew(async () =>
            {
                try
                {
                    while (true)
                    {
                        int byteRcv = socket.Receive(bufferByte);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            string msg = Encoding.Unicode.GetString(bufferByte, 0, byteRcv);
                            chatBox.Text += msg + "\r\n \r\n";
                        }));
                    
                    }
                }
                catch (SocketException se)
                {
                    if (se.ErrorCode == 10004) MessageBox.Show("You have disconnected from the server");
                    else MessageBox.Show(se.ErrorCode.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    socket.Dispose();
                    Close();
                }
            });
        }

        private void clientChatForm_Load(object sender, EventArgs e)
        {
            string msg = nameTextBox.Text + "#" + endPoint.Port.ToString() + " has joined the chat!";
            byte[] data = Encoding.Unicode.GetBytes(msg);
            socket.SendTo(data, server);
            typeBox.ScrollBars = ScrollBars.Vertical;
            typeBox.WordWrap = true;
            chatBox.ScrollBars = ScrollBars.Vertical;
            chatBox.WordWrap = true;
        }

        private void discBtn_Click(object sender, EventArgs e)
        {
            socket.Close();   
            Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string msg =  nameTextBox.Text + "#" + endPoint.Port.ToString() + ":\r\n"  + typeBox.Text;
            byte[] data = Encoding.Unicode.GetBytes(msg);
            socket.SendTo(data, server);
            typeBox.Text = "";
        }

        private void typeBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
