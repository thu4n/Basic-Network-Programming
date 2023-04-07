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
            
            chatBox.AppendText("Start listening for connections... \r\n");

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
                MessageBox.Show("Không thể tạo server");
            }
        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // gọi hàm update form
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            // cập nhật thông tin gói tin vào chatbox
            chatBox.AppendText(strMessage + "\r\n");
        }

        private void Server_Load(object sender, EventArgs e)
        {
            chatBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
