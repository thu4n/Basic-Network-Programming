using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Week04_TCP_Chatroom
{
    public partial class Server : Form
    {
        private bool isListening = false;
        public Server()
        {
            InitializeComponent();
        }
        private delegate void UpdateStatusCallback(string strMessage);

        bool check = false;

        private void listenBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (check)
                    this.Close();
                if (!isListening)
                {
                    chatBox.Text += "start listening for connections... \r\n";
                    // Chuyển đổi dạng dữ liệu của IP
                    IPAddress ipAddr = IPAddress.Parse(serverIPTB.Text);
                    ChatServer1 mainServer = new ChatServer1(ipAddr);
                    // Hook the StatusChanged event handler to mainServer_StatusChanged
                    ChatServer1.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);
                    // Bắt đầu quá trình lắng nghe kết nối
                    mainServer.StartListening();
                    listenBtn.Text = "Stop listening";
                    isListening = true;
                    serverIPTB.ReadOnly = true;
                    serverIPTB.ForeColor = Color.Gray;

                }
                else
                {

                    listenBtn.Text = "Close";
                    isListening = false;
                    serverIPTB.ReadOnly = false;
                    serverIPTB.ForeColor = Color.White;
                    chatBox.Text += "Stopped listening. \r\n";
                    check = true;
                }
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Call the method that updates the form
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            // Updates the log with the message
            chatBox.AppendText(strMessage + "\r\n");
        }

        private void Server_Load(object sender, EventArgs e)
        {
            chatBox.Text += "Waiting for connection... \r\n";
            chatBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
