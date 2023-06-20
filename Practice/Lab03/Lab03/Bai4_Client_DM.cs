using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai4_Client_DM : Form
    {
        private int destPort;
        private NetworkStream nwStream;
        private string senderInfo = "";
        private string recptInfo = "";
        public bool openForm = false;
        public bool newMsg = false;
        public Bai4_Client_DM()
        {
            InitializeComponent();
        }
        public Bai4_Client_DM(string sender, NetworkStream stream, string recpt)
        {
            InitializeComponent();
            nwStream = stream;
            senderInfo = sender;
            recptInfo = recpt;
            titleLabel0.Text = "From " + senderInfo + " to " + recptInfo;
            Text = "From " + senderInfo + " to " + recptInfo;
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "") return;
            string msg = textBox.Text;
            string packet = "<" + senderInfo + "," + recptInfo + "," + msg;
            byte[] buffer = Encoding.Unicode.GetBytes(packet);
            nwStream.Write(buffer, 0, buffer.Length);
            chatBox.Text += senderInfo + ": " + msg + "\r\n";
            textBox.Clear();
        }
        public void getMsg(string msg)
        {
            chatBox.Text += msg + "\r\n";
        }
        private void Bai4_Client_DM_Load(object sender, EventArgs e)
        {

        }
        private void closed()
        {
            string msg = "@has left the room chat@";
            string packet = destPort.ToString() + "<" + senderInfo + ": " + msg;
            byte[] buffer = Encoding.Unicode.GetBytes(packet);
            nwStream.Write(buffer, 0, buffer.Length);
        }
        private void Bai4_Client_DM_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed();
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Files (*.PNG;*.JPG;*.txt)|*.PNG;*.JPG;*.txt|All files (*.*)|*.*";
                ofd.ShowDialog();
                string path = "";
                path = ofd.FileName;
                FileInfo fileInfo = new FileInfo(path);
                string name = fileInfo.Name;
                // khởi tạo mảng byte data 
                byte[] data = new byte[fileInfo.Length];
                // mở dilestream để lưu dữ liệu file được chọn vào data
                using (FileStream fs = fileInfo.OpenRead())
                {
                    fs.Read(data, 0, data.Length);
                }
                // gửi file
                //sendMsg("++ " + tcpClient.nameTag() + " has send file: " + name);
                string msg = "~" + "has send file: " + name;
                string packet = "<" + senderInfo + "," + recptInfo + "," + msg;
                byte[] buffer = Encoding.Unicode.GetBytes(packet);
                nwStream.Write(buffer, 0, buffer.Length);
                chatBox.Text += senderInfo + ": " + msg + "\r\n";

                nwStream.Write(data, 0, data.Length);
            }
            catch (Exception) { MessageBox.Show(" File Send Fail pls try again "); }
        }
    }
}
