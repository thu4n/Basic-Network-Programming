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
using System.IO;
using System.Numerics;
using System.IO.Pipes;

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
        private string[] files = new string[10];
        private int fileCount = 0;
        private int check = 0;
        private bool dmOpen = false;
        FileData[] FilesData = new FileData[10]; // tạo class lưu dữ liệu
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
            if (usernameTB.Text == "")
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
                    displayFile();
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
            byte[] received = new byte[10000000]; // chỉnh độ dài
            Task.Run(async () =>
            {
                while (tcpClient.client.Connected)
                {
                    int byte_count = await nwStream.ReadAsync(received, 0, received.Length);
                    byte[] formatted = new byte[byte_count];
                    Array.Copy(received, formatted, byte_count);
                    string msg = Encoding.Unicode.GetString(formatted);
                    string data = "";
                    Invoke(new MethodInvoker(delegate ()
                    {
                        if (currentCount != clients.Count) // Cập nhật số client ở thread hiện tại
                        {
                            displayClients();
                        }
                        displayFile();
                        if (msg[0] == '>')
                        {
                            int start = msg.IndexOf('#') + 1;
                            int end = msg.IndexOf(':') - start;
                            int name = msg.IndexOf(':') - 1;
                            int data1 = msg.IndexOf(':') + 2;
                            string portString = msg.Substring(start, end);
                            string nameString = msg.Substring(1, name);
                            int port = int.Parse(portString);
                            try
                            { data = msg.Substring(data1); }
                            catch { };
                            // kiểm tra xem đã đóng form room chat chưa, nếu rồi thì ta xóa nó khỏi cái dmClients
                            if (data == "@has left the room chat@")
                            {
                                dmClients.Remove(port);
                                dm.Close();
                                chatBox.Text += msg + "\r\n";
                                return;
                            }
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
                        }
                        else if (check == 1)
                        {
                            check = 0;
                            // lưu dữ liệu vào FilesData
                            FilesData[fileCount - 1] = new FileData(formatted);
                        }
                        else
                            chatBox.Text += msg + "\r\n";
                    }));
                    int data2 = msg.IndexOf(':') + 2;
                    try
                    { data = msg.Substring(data2); }
                    catch { };

                    if (msg[0] == '-')
                    {
                        disconnect();
                    }
                    else if (msg[0] == '!')
                    {
                        displayClients();
                    }
                    else if (msg[0] == '+')
                    {
                        files[fileCount] = data;
                        fileCount += 1;
                        check = 1;
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
            foreach (var client in clients)
            {
                listBox1.Items.Add(client.Value + "#" + client.Key.ToString());
            }
            currentCount = clients.Count;
        }
        private void displayFile()
        {
            listBox2.Items.Clear();
            if (fileCount > 0)
            {
                for (int i = 0; i < fileCount; i++)
                {
                    listBox2.Items.Add(files[i]);
                }
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] tags = listBox1.SelectedItem.ToString().Split('#');
                string recptInfo = listBox1.SelectedItem.ToString();
                int port = int.Parse(tags[1]);
                if (port == tcpClient.portNum) return;
                dm = new Bai4_Client_DM(tcpClient.nameTag(), port, nwStream, recptInfo);
                dm.Show();
                try
                {
                    dmClients.Add(port, recptInfo);
                }
                catch
                {
                    dmClients.Remove(port);
                }
                dmOpen = true;
            }
        }
        private void disconnect()
        {
            if (dmOpen) dm.Close();
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
            if (connected)
            {
                if (dmOpen) dm.Close();
                clients.TryRemove(tcpClient.portNum, out string temp);
                sendMsg("!! " + tcpClient.nameTag() + " has left the chat !!");
                disconnect();
            }
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
                sendMsg("++ " + tcpClient.nameTag() + " has send file: " + name);
                nwStream.Write(data, 0, data.Length);
            }
            catch (Exception) { MessageBox.Show(" File Send Fail pls try again "); }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                int a = listBox2.SelectedIndex;
                try
                {
                    if (listBox2.Items[listBox2.SelectedIndex].ToString().Contains(".txt"))
                    {
                     // tạo luồng với dữ liệu file đã lưu
                       Stream stream = new MemoryStream(FilesData[a].getData());
                    // đọc dữ liệu trong  MemoryStream sử dụng StreamReader.
                      using (StreamReader memReader = new StreamReader(stream))
                      {
                        string memContents = memReader.ReadToEnd();
                        richTextBox1.Text = memContents.ToString();
                        richTextBox1.Visible = true;
                        chatBox.Visible = false;
                        pictureBox1.Visible = false;
                        ExitFile.Visible = true;
                      }
                    }
                    else
                    {
                        Stream stream = new MemoryStream(FilesData[a].getData());
                        var img = Bitmap.FromStream(stream);
                        pictureBox1.Image = img;
                        richTextBox1.Visible = false;
                        chatBox.Visible = false;
                        pictureBox1.Visible = true;
                        ExitFile.Visible = true;
                    }
               }
               catch { MessageBox.Show("lỗi file"); }
            }
        }
        private void ExitFile_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            richTextBox1.Visible = false;
            chatBox.Visible = true;
            richTextBox1.Clear();
            ExitFile.Visible = false;
        }
    }
    public class FileData
    {
        public byte[] data;
        public FileData(byte[] data1)
        {
            data = new byte[data1.Length];
            data = data1;
        }
        public byte[] getData()
        {
            return data;
        }
    }
}
