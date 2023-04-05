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
        private void listenBtn_Click(object sender, EventArgs e)
        {
            
            chatBox.AppendText("Đang lắng nghe các kết nối...\r\n");

            try
            {

                if (!isListening)
                {
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
                    chatBox.Text += "Start listening for connections... \r\n";
                }
                else
                {
                    // Code thêm đóng kết nối TCP tại đây

                    listenBtn.Text = "Connect";
                    isListening = false;
                    serverIPTB.ReadOnly = false;
                    serverIPTB.ForeColor = Color.White;
                    chatBox.Text += "Stopped listening. \r\n";
                }

            }
            catch (Exception)
            {
                // Code xử lý exception ở đây
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
            chatBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
