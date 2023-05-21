using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
        public int stt = 0;
        private void DownFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "File"+ stt + ".html";stt++;
                WebClient myClient = new WebClient();
                Stream response = myClient.OpenRead(URL.Text);
                myClient.DownloadFile(URL.Text, "C:\\Users\\ACER\\Downloads\\" + filename);
                MessageBox.Show("Download thành công");
            }
            catch (Exception) { MessageBox.Show("Download thất bại"); }
        }
    }
}
