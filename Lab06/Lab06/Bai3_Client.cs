using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab06.Bai3_Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab06
{
    /*
     * Chỉ cho tối đa 2 client kết nối vào chatroom của 1 server
     * Trao đổi public key giữa 2 client khi khởi tạo kết nối
     * Server lưu trữ tin nhắn chứa public key rồi broadcast lại khi có client mới vào
     * Khi gửi tin nhắn, mã hóa với public key nhận được từ đối phương
     * Khi nhận tin nhắn, giải mã với private key của mình.
     * Như vậy, dữ liệu sẽ được bảo mật khi private key chưa bao giờ được tiết lộ.
     * 2 bên chỉ biết cách mã hóa (thông qua public key) sao cho bên kia tự giải mã được
     */
    public partial class Bai3_Client : Form
    {
        private NetworkStream nwStream;
        private bool connected = false;
        private string pubKeyString;
        private bool shared = false;
        RSACryptoServiceProvider csp;
        RSAParameters pubKeyReceived;
        public class Bai3_TcpClient
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public Bai3_TcpClient() { }
            public Bai3_TcpClient(string name, IPAddress ip)
            {
                client = new TcpClient();
                client.Connect(ip, 16000);
                username = name;
            }

        }
        Bai3_TcpClient tcpClient;
        public Bai3_Client()
        {
            InitializeComponent();
        }

        private void Bai3_Client_Load(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }
            if (!connected)
            {
                try
                {
                    string str = ipTB.Text;
                    IPAddress localIP = IPAddress.Parse(str);
                    tcpClient = new Bai3_TcpClient(usernameTB.Text, localIP);
                    nwStream = tcpClient.client.GetStream();
                    SendMsg("$" + tcpClient.username + " has joined the chat");
                    GetMsg();
                    GetPublicKey();
                }
                catch (SocketException se)
                {
                    if (se.SocketErrorCode == SocketError.ConnectionRefused)
                    {
                        MessageBox.Show("There is no server listening at the moment");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                /*titleLabel0.Text = "You are connected to the server";
                titleLabel0.ForeColor = ColorTranslator.FromHtml("#457ad0");*/
                connected = true;
                connectBtn.Text = "Disconnect";
                ipTB.ReadOnly = true;
                connectBtn.BackColor = Color.Red;
                usernameTB.ReadOnly = true;
            }
            else
            {
                //clients.TryRemove(tcpClient.portNum, out string temp);
                SendMsg("!" + tcpClient.username + " has left the chat !");
                Disconnect();
            }
        }
        private void GetMsg()
        {
            byte[] received = new byte[1000]; // chỉnh độ dài
            Task.Run(async () =>
            {
                while (tcpClient.client.Connected)
                {
                    int byte_count = await nwStream.ReadAsync(received, 0, received.Length);
                    byte[] formatted = new byte[byte_count];
                    Array.Copy(received, formatted, byte_count);
                    string msg = Encoding.Unicode.GetString(formatted);
                    Invoke(new MethodInvoker(delegate ()
                    {
                       chatBox.Text += msg + "\r\n";
                    }));
                    if (msg[0] == '?' && !shared)
                    {
                        pubKeyString = msg.Substring(1);
                        pubKeyReceived = StringToKey(pubKeyString);
                        shared = false;
                    }
                    else if (msg[0] == '-')
                    {
                        Disconnect();
                    }
                }
                nwStream.Close();
                tcpClient.client.Close();
            });
        }
        private void SendMsg(string msg)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
            //buffer = Encryption(buffer, csp.ExportParameters(f))
            nwStream.Write(buffer, 0, buffer.Length);
        }
        private void Disconnect()
        {
            /*titleLabel0.Text = "You are not connected to the server";
            titleLabel0.ForeColor = Color.Black;*/
            connected = false;
            connectBtn.Text = "Connect";
            connectBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
            ipTB.ReadOnly = false;
            usernameTB.ReadOnly = false;
            nwStream.Close();
            tcpClient.client.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (typeTB.Text.Length == 0) return;
            SendMsg(usernameTB.Text + ": " + typeTB.Text);
            typeTB.Clear();
        }
        private void GetPublicKey()
        {
            csp = new RSACryptoServiceProvider(512); // Khởi tạo cặp key ở đây nhưng chỉ show public key
            var pubKey = csp.ExportParameters(false);
            var stringWriter = new System.IO.StringWriter();
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            serializer.Serialize(stringWriter, pubKey);
            pubKeyTB.Text = stringWriter.ToString();
            shareBtn.Enabled = true;
        }
        private RSAParameters StringToKey(string keyString)
        {
            var sr = new System.IO.StringReader(keyString);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            var key = (RSAParameters)serializer.Deserialize(sr);
            return key;
        }
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes("?"+pubKeyTB.Text);
            nwStream.Write(buffer, 0, buffer.Length);
            shared = true;
            MessageBox.Show("Đã chia sẻ public key");
        }
    }
}
