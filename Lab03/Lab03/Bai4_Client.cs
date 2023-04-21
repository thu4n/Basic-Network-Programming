using System;
using System.Collections.Concurrent;
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
using System.Text.Json;

namespace Lab03
{
    public partial class Bai4_Client : Form
    {
        private NetworkStream nwStream;
        private static ConcurrentDictionary<int, string> clients = new ConcurrentDictionary<int, string>(); //Sử dụng ConcurrentDictionary vì dữ liệu của type này là thread-safe
        private Dictionary<int, string> dmClients = new Dictionary<int, string>();
        private int currentCount = 0;
        private bool connected = false;
        private Bai4_Client_DM dm;
        public class Bai4_TcpClient
        {
            public TcpClient client { get; set; }
            public string username { get; set; }
            public int portNum { get; set; }
            public Bai4_TcpClient() { }
            public Bai4_TcpClient(string name)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 16000);
                portNum = ((IPEndPoint)client.Client.LocalEndPoint).Port;
                username = name;
            }
            public string nameTag()
            {
                if (username != "" && portNum > 0)
                    return username + "#" + portNum;
                return "";
            }

        }
        Bai4_TcpClient tcpClient;
        public Bai4_Client()
        {
            InitializeComponent();
        }

        private void Bai4_Client_Load(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }
            if (!connected)
            {
                try
                {
                    tcpClient = new Bai4_TcpClient(usernameTB.Text);
                    nwStream = tcpClient.client.GetStream();
                    clients.TryAdd(tcpClient.portNum, tcpClient.username);
                    sendMsg(tcpClient.nameTag() + " has joined the chat");
                    getMsg();
                    displayClients();
                }
                catch(SocketException se)
                {
                    if(se.SocketErrorCode == SocketError.ConnectionRefused)
                    {
                        MessageBox.Show("There is no server listening at the moment");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                titleLabel0.Text = "You are connected to the server";
                titleLabel0.ForeColor = ColorTranslator.FromHtml("#457ad0");
                connected = true;
                connectBtn.Text = "Disconnect";
                connectBtn.BackColor = Color.Red;
                usernameTB.ReadOnly = true;
            }
            else
            {
                clients.TryRemove(tcpClient.portNum, out string temp);
                sendMsg("!! " + tcpClient.nameTag() + " has left the chat !!");
                disconnect();
            }
        }
        private void getMsg()
        {
            byte[] received = new byte[1024];
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
                        if (currentCount != clients.Count) // Cập nhật số client ở thread hiện tại
                        {
                            displayClients();
                        }
                        
                        if (msg[0] == '>')
                        {
                            int start = msg.IndexOf('#') + 1;
                            int end = msg.IndexOf(':') - start;
                            int name = msg.IndexOf(':') - 1;
                            string portString = msg.Substring(start,end);
                            string nameString = msg.Substring(1,name);
                            int port = int.Parse(portString);
                            if (dmClients.TryGetValue(port, out string rcv))
                            {
                                dm.getMsg(msg);
                                return;
                            }
                            else
                            {
                                dmClients.Add(port, nameString);
                                dm = new Bai4_Client_DM(tcpClient.nameTag(), port, nwStream, nameString);
                                dm.Show();
                                dm.openForm = true;
                                dm.getMsg(msg);
                            }
                            //MessageBox.Show(portString);
                        }
                        else chatBox.Text += msg + "\r\n";
                    }));
                    if (msg[0] == '-') 
                    { 
                        disconnect();
                    }
                    else if (msg[0] == '!')
                    { 
                        displayClients();
                        if(dm.openForm)
                        {
                            /* Dự định là check coi form nào đang mở khi nhận đc thông báo có người out
                             nhưng mà quên tính trường hợp có nhiều form đang mở khi ib với nhiều thằng, nhờ anh Phát cả nhé
                             */
                        }
                    }
                }
                clients.TryRemove(tcpClient.portNum, out string temp);
                nwStream.Close();
                tcpClient.client.Close();
            });
        }
        private void sendMsg(string msg)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
            nwStream.Write(buffer, 0, buffer.Length);
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "") return;
            if (!connected)
            {
                textBox.Clear();
                return;
            }
            string msg = tcpClient.nameTag() + ": " + textBox.Text;
            sendMsg(msg);
            textBox.Clear();
        }
        private void displayClients()
        {
            listBox1.Items.Clear();
            foreach(var client in clients)
            {
                listBox1.Items.Add(client.Value + "#" + client.Key.ToString());
            }
            currentCount = clients.Count;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string[] tags = listBox1.SelectedItem.ToString().Split('#');
                string recptInfo = listBox1.SelectedItem.ToString();
                int port = int.Parse(tags[1]);
                if (port == tcpClient.portNum) return;
                dm = new Bai4_Client_DM(tcpClient.nameTag(),port, nwStream, recptInfo);
                dm.Show();
                dmClients.Add(port, recptInfo);
                dm.openForm = true;
            }
        }
        private void disconnect()
        {
            dm.Close();
            titleLabel0.Text = "You are not connected to the server";
            titleLabel0.ForeColor = Color.Black;
            connected = false;
            connectBtn.Text = "Connect";
            connectBtn.BackColor = ColorTranslator.FromHtml("#457ad0");
            usernameTB.ReadOnly = false;
            nwStream.Close();
            tcpClient.client.Close();
        }

        private void Bai4_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(connected)
            {
                dm.Close();
                clients.TryRemove(tcpClient.portNum, out string temp);
                sendMsg("!! " + tcpClient.nameTag() + " has left the chat !!");
                disconnect();
            }
        }
    }
}
