using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab03
{
    public partial class Bai1_Server : Form
    {
        
        public Bai1_Server()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            UdpClient server = new UdpClient(int.Parse(Port_txt.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = server.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" +
                returnData.ToString();
                InfoMessage(mess);
            }
        }
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
        private void InfoMessage(string mess)
        {
            Received_Mess.Text += mess + Environment.NewLine;
        }

        private void Bai1_Server_Load(object sender, EventArgs e)
        {

            
        }
    }
}
