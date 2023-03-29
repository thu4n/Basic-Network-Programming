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
    public partial class Server : Form
    {
        private bool isListening = false;
        public Server()
        {
            InitializeComponent();
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            try
            {

                // Xử lý tác vụ lấy địa chỉ IP và username ở đây

                if (!isListening)
                {
                    // Code thêm mở kết nối TCP tại đây

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

        private void Server_Load(object sender, EventArgs e)
        {
            chatBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
