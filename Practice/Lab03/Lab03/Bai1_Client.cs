using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai1_Client : Form
    {

        public Bai1_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                if (Mess_txt.Text == "") return;
                Byte[] sendBytes = Encoding.UTF8.GetBytes(Mess_txt.Text);
                udpClient.Send(sendBytes, sendBytes.Length, Ip_txt.Text, int.Parse(Port_txt.Text));
                MessageBox.Show("Gửi thành công");
                Mess_txt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
