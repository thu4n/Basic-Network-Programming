using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week04_TCP_Chatroom
{
    public partial class Client : Form
    {
        // Tạo socket cho client và stream cho sever
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        private bool isConnected = false;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            chatBox.Text += "Waiting for connection... \r\n";
            chatBox.ScrollBars = ScrollBars.Vertical;
            typeBox.ScrollBars = ScrollBars.Vertical;
        }
        private void getMessage()
        {
            try
            {
                while (true)
                {
                    serverStream = clientSocket.GetStream();
                    //  StreamReader Doc;
                    // Doc = new StreamReader(serverStream);

                    byte[] inStream = new byte[4096];
                    serverStream.Read(inStream, 0, inStream.Length);
                    string returndata = Encoding.UTF8.GetString(inStream);
                    readData = "" + returndata;
                    msg();
                }
            }
            catch (Exception) { }

        }
        //invokerequired để kiểm tra trạng thái sẵn sàng của control mặc định
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                chatBox.Text = chatBox.Text + Environment.NewLine + " >> " + readData;
        }
        bool check = false;
        private void connectBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (check)
                    this.Close();
                if (!isConnected)
                {

                    IPAddress iPAddress = IPAddress.Parse(serverIPTB.Text);
                    IPEndPoint iPEndPointCLient = new IPEndPoint(iPAddress, 8888);
                    clientSocket.Connect(iPEndPointCLient);
                    serverStream = clientSocket.GetStream();

                    StreamWriter ghi = new StreamWriter(serverStream);
                    ghi.WriteLine(usernameTB.Text);
                    ghi.Flush();

                    Thread ctThread = new Thread(getMessage);
                    ctThread.Start();

                    connectBtn.Text = "Disconnect";
                    isConnected = true;
                    serverIPTB.ReadOnly = true;
                    usernameTB.ReadOnly = true;
                    serverIPTB.ForeColor = Color.Gray;
                    usernameTB.ForeColor = Color.Gray;
                }
                else
                {
                    serverStream.Close();
                    connectBtn.Text = "Close";
                    isConnected = false;
                    serverIPTB.ReadOnly = false;
                    usernameTB.ReadOnly = false;
                    serverIPTB.ForeColor = Color.White;
                    usernameTB.ForeColor = Color.White;
                    chatBox.Text += "Disconnected from the server. \r\n";
                    check = true;
                }

            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            StreamWriter ghi = new StreamWriter(serverStream);
            ghi.WriteLine(typeBox.Text);
            ghi.Flush();
            typeBox.Text = ""; // Clear tin nhắn sau mỗi lần gửi thành công
        }
    }
}