using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab06.Bai3_Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab06
{
    public partial class Bai3_Client : Form 
    {
        private NetworkStream nwStream;
        private bool connected = false;
        private string pubKeyString = "<RSAKeyValue><Modulus>1L+WKDCTomMNBv42f5IppEeVZ8hh6QNxgDNSZ7ixa0tw+BmwNLmCbib0BkXkGvtyoWZAlscYtcAojSbvOtSNGQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private string priKeyString = "<RSAKeyValue><Modulus>1L+WKDCTomMNBv42f5IppEeVZ8hh6QNxgDNSZ7ixa0tw+BmwNLmCbib0BkXkGvtyoWZAlscYtcAojSbvOtSNGQ==</Modulus><Exponent>AQAB</Exponent><P>8KyW9pRU3cDB1sm7iTMQtIM9or47GGJyBvgp3ke8/hs=</P><Q>4kvB7m/Qq0ESHV+emsKmriAeqn/Kq7M55SxyoGR4RNs=</Q><DP>4Im0wlI7JzRJ5DELlQIeaLs0ytu92I8oIRZwQWAek9c=</DP><DQ>mhL0hnAxBfi26bLp3Pr8239ZAcMibYcIuyVpIhVl4ZM=</DQ><InverseQ>n+Q6KBJhZnlKYXHd86y7ZtYNigJcSsFocSeq6mLqmGw=</InverseQ><D>jTvewDF3YN8mv9S1cz0h/dgzvCEPtrO9fqETfJ3k0led1zIy8b3aYGo9R3kOJu8nOrt6XBqERn0ImVIGZPgkLQ==</D></RSAKeyValue>";
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
            if (usernameTB.Text == "" || ipTB.Text == "")
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
                connected = true;
                connectBtn.Text = "Disconnect";
                ipTB.ReadOnly = true;
                connectBtn.BackColor = Color.Red;
                usernameTB.ReadOnly = true;
            }
            else
            {
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
                    if (msg[0] != '$')
                    {
                        string[] strings = msg.Split(':');
                        msg = strings[0] + ": " + Decryption(strings[1]);
                    }
                    Invoke(new MethodInvoker(delegate ()
                    {
                       chatBox.Text += msg + "\r\n";

                    }));
                    if (msg[0] == '-')
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
            if (msg[0] != '$')
            {
                msg = tcpClient.username + ": " + Encryption(msg);
            }
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
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
            SendMsg(typeTB.Text);
            typeTB.Clear();
        }
        public string Encryption(string msg)
        {
            var data = Encoding.UTF8.GetBytes(msg);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(pubKeyString.ToString());
                    var encryptedData = rsa.Encrypt(data, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        public string Decryption(string msg)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = msg;
                    rsa.FromXmlString(priKeyString);
                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
    }
}
