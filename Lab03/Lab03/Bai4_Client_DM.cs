using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai4_Client_DM : Form
    {
        private int destPort;
        public Bai4_Client_DM()
        {
            InitializeComponent();
        }
        public Bai4_Client_DM(int port)
        {
            InitializeComponent();
            destPort = port;
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {

        }

        private void Bai4_Client_DM_Load(object sender, EventArgs e)
        {

        }
    }
}
