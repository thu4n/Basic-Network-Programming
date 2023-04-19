using System;
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

namespace Lab03
{
    public partial class Bai4_Client_DM : Form
    {
        private int destPort;
        private NetworkStream nwStream;
        public Bai4_Client_DM()
        {
            InitializeComponent();
        }
        public Bai4_Client_DM(int port, NetworkStream stream)
        {
            InitializeComponent();
            destPort = port;
            nwStream = stream;
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {

        }

        private void Bai4_Client_DM_Load(object sender, EventArgs e)
        {
            string msg = "yup yup";
            byte[] buffer = Encoding.ASCII.GetBytes(msg);
            nwStream.Write(buffer, 0, buffer.Length);
        }
    }
}
