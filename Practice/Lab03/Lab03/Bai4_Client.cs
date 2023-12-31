﻿using System;
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
using System.Net.NetworkInformation;

namespace Lab03
{
    public partial class Bai4_Client : Form
    {
        private NetworkStream nwStream;
        private static List<string> clients = new List<string>(); //Sử dụng ConcurrentDictionary vì dữ liệu của type này là thread-safe
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
            public Bai4_TcpClient(string name, IPAddress ip)
            {
                client = new TcpClient();
                client.Connect(ip, 80);
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
                    string str = ipTB.Text;
                    IPAddress localIP = IPAddress.Parse(str);
                    tcpClient = new Bai4_TcpClient(usernameTB.Text, localIP);
                    nwStream = tcpClient.client.GetStream();
                    //clients.TryAdd(tcpClient.portNum, tcpClient.username);
                    sendMsg("$" + tcpClient.nameTag() + " has joined the chat");
                    getMsg();
                    //displayClients();
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
                ipTB.ReadOnly = true;
                connectBtn.BackColor = Color.Red;
                usernameTB.ReadOnly = true;
            }
            else
            {
                //clients.TryRemove(tcpClient.portNum, out string temp);
                sendMsg("!" + tcpClient.nameTag() + " has left the chat !");
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
                    string portString = "";
                    string nameString = "";
                    Invoke(new MethodInvoker(delegate ()
                    {
                        if (currentCount != clients.Count) // Cập nhật số client ở thread hiện tại
                        {
                            //displayClients();
                        }
                        displayFile();
                        if (msg[0] == '^')
                        {
                            string newUser = msg.Substring(1, msg.Length - 1);
                            displayClients(newUser);
                        }
                        if (msg[0] == '<')
                        {
                            msg = msg.TrimStart('<');
                            string[] packets = msg.Split(':');
                            int start = msg.IndexOf('#') + 1;
                            int end = msg.IndexOf(':') - start;
                            int name = msg.IndexOf(':') - 1;
                            int data1 = msg.IndexOf(':') + 2;
                            portString = msg.Substring(start, end);
                            nameString = msg.Substring(1, name);
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
                                if (!dmOpen)
                                {
                                    dm = new Bai4_Client_DM(tcpClient.nameTag(), nwStream, packets[0]);
                                    dm.Show();
                                    dmOpen = true;
                                }
                                dm.getMsg(msg);
                            }
                        }
                        else if (check == 1)
                        {
                            check = 0;
                            // lưu dữ liệu vào FilesData
                            FilesData[fileCount - 1] = new FileData(formatted);
                            
                        }
                        else chatBox.Text += msg + "\r\n";

                    }));
                    int data2 = msg.IndexOf(':') + 2;
                    try
                    { data = msg.Substring(data2); }
                    catch { };

                    if (msg[0] == '-')
                    {
                        disconnect();
                    }
                    else if (msg[0] == '+')
                    {
                        files[fileCount] = data;
                        fileCount += 1;
                        check = 1;
                    }
                }
                //clients.TryRemove(tcpClient.portNum, out string temp);
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
        private void displayClients(string clientList)
        {
            listBox1.Items.Clear();
            string[] arr = clientList.Split(',');
            foreach (var client in arr)
            {
                listBox1.Items.Add(client);
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
            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() != tcpClient.nameTag())
            {
                string recptInfo = listBox1.SelectedItem.ToString();
                dm = new Bai4_Client_DM(tcpClient.nameTag(), nwStream, recptInfo);
                dm.Show();
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
            ipTB.ReadOnly = false;
            usernameTB.ReadOnly = false;
            nwStream.Close();
            tcpClient.client.Close();
        }

        private void Bai4_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connected)
            {
                if (dmOpen) dm.Close();
                //clients.TryRemove(tcpClient.portNum, out string temp);
                sendMsg("!" + tcpClient.nameTag() + " has left the chat !!");
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
                      stream.Close();
                    }
                    else
                    {
                        Stream stream = new MemoryStream(FilesData[a].getData());
                        var img = Bitmap.FromStream(stream);
                        pictureBox1.Image = img;
                        stream.Close();
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
