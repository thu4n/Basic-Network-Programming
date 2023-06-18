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
    public partial class Bai_3 : Form
    {
        public Bai_3() 
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
            webBrowser1.ScriptErrorsSuppressed = true; // bỏ qua kiểm tra lỗi script
        }
        private void GoFoward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            webView21.GoForward();
        }
        private void GoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();  
        }
        private void DownFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog Sfd = new SaveFileDialog();
                Sfd.ShowDialog();
                string filename = Sfd.FileName + ".html";
                WebClient myClient = new WebClient();
                Stream response = myClient.OpenRead(URL.Text);
                myClient.DownloadFile(URL.Text,filename);
                MessageBox.Show("Download thành công");
            }
            catch (Exception) { MessageBox.Show("Download thất bại"); }
        }

        private void DownResource_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();
            Sfd.ShowDialog();
            var DownResouce = new Bai_3_1(URL.Text,Sfd.FileName);
            DownResouce.Show();
        }
    }
}
