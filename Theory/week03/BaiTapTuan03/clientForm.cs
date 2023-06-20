using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan03
{
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
            Text = "Client side of Steam Chat";
        }

        private void clientForm_Load(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            
            clientChatForm chat = new clientChatForm(ipTextBox.Text, Int32.Parse(serverPortTB.Text), nameTextBox.Text);
            chat.Show();
            Close();
        }


    }
}
