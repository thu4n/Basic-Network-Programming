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
        public Bai3() 
        { 
            InitializeComponent(); 
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string link = URL.Text;
            webBrowser1.Navigate(link);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            URL.Text = webBrowser1.Url.ToString();
        }

        private void GoFoward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();  
        }
    }
}
