using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            var form = new Client();
            form.Show();
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            var form = new Server();
            form.Show();
        }
    }
}
