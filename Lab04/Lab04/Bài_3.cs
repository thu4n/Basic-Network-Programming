using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai3 : Form
    {
        WebBrowser webBrowser;
        public Bai3() 
        { 
            InitializeComponent(); 
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            webBrowser = new WebBrowser();
            webBrowser.Width = 700;
            webBrowser.Height = 500;
            panelWeb.Controls.Add(webBrowser); 
        }
    }
}
