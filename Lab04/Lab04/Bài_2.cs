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

namespace Lab04
{
    public partial class Bài_2 : Form
    {
        public Bài_2()
        {
            InitializeComponent();
        }
        
        private string GetHTML(string URL)
        {
            WebRequest request = WebRequest.Create(URL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void DownLoad_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(URL.Text);
            myClient.DownloadFile(URL.Text, HTML.Text);
            richTextBox1.Text = GetHTML(URL.Text);
        }
    }
}
