using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04_TCP_Chatroom
{
    public partial class Client : Form
    {
        private bool isConnected = false;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            chatBox.Text += "Waiting for connection... \r\n";
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Xử lý tác vụ lấy địa chỉ IP và username ở đây
                 
                if (!isConnected)
                {
                    // Code thêm mở kết nối TCP tại đây

                    connectBtn.Text = "Disconnect";
                    isConnected = true;
                    serverIPTB.ReadOnly = true;
                    usernameTB.ReadOnly = true;
                    serverIPTB.ForeColor = Color.Gray;
                    usernameTB.ForeColor = Color.Gray;
                    chatBox.Text += "Connected successfully to the server at " + serverIPTB.Text + "! \r\n";
                }
                else
                {
                    // Code thêm đóng kết nối TCP tại đây

                    connectBtn.Text = "Connect";
                    isConnected = false;
                    serverIPTB.ReadOnly = false;
                    usernameTB.ReadOnly = false;
                    serverIPTB.ForeColor = Color.White;
                    usernameTB.ForeColor = Color.White;
                    chatBox.Text += "Disconnected from the server. \r\n";
                }

            }
            catch (Exception)
            {
                // Code xử lý exception ở đây
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {

            // Code xử lý và gửi dữ liệu trong TypeBox ở đây

            typeBox.Text = ""; // Clear tin nhắn sau mỗi lần gửi thành công
        }
    }
}
