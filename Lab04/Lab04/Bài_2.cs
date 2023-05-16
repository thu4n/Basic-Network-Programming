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
        
        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        private void DownLoad_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(URL.Text);
            myClient.DownloadFile(URL.Text, HTML.Text);
            richTextBox1.Text = getHTML(URL.Text);

            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            string data = richTextBox1.Text;
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(data); ;
            }
            fs.Close();
            saveFileDialog1.ShowDialog();
        }
    }
}
