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
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace BaiTapTuan03
{
    public partial class serverForm : Form
    {
        private UdpClient server = null;
        private IPEndPoint client = null;
        private HashSet<int> clientList = new HashSet<int>();
        public serverForm()
        {
            InitializeComponent();
            Text = "Server side of Steam Chat";
        }

        private void serverForm_Load(object sender, EventArgs e)
        {
            chatBox.ScrollBars = ScrollBars.Vertical;
            chatBox.WordWrap = true;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(startBtn.Text == "Stop listening")
            {
                server.Close();
                startBtn.Text = "Start listening";
                startBtn.ForeColor = ColorTranslator.FromHtml("#66bff3");
                startBtn.BackColor = ColorTranslator.FromHtml("#2a475e");
                return;
            }
            startBtn.Text = "Stop listening";
            startBtn.ForeColor = ColorTranslator.FromHtml("#f54c18");
            startBtn.BackColor = ColorTranslator.FromHtml("#3f2420");
            server = new UdpClient(Int32.Parse(serverPortTB.Text));
            client = new IPEndPoint(IPAddress.Any, Int32.Parse(serverPortTB.Text));
            byte[] data = new byte[1024];
            Task.Factory.StartNew(async () =>
            {
                try
                {
                    while (true)
                    {
                        data = server.Receive(ref client);
                        Invoke(new MethodInvoker(delegate ()
                        {
                            string msg = Encoding.Unicode.GetString(data, 0, data.Length);
                            chatBox.Text += msg + "\r\n \r\n";
                            data = Encoding.Unicode.GetBytes(msg);
                            clientList.Add(client.Port);
                            foreach(var port in clientList)
                            {
                                server.Send(data, data.Length, client.Address.ToString(),port);
                            }
                        }));
                    }
                }
                catch (SocketException se)
                {
                    if (se.ErrorCode == 10004) MessageBox.Show("Server has stopped listening");
                    else MessageBox.Show(se.ErrorCode.ToString());  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            });

        }
        private void serverPortTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chatBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
