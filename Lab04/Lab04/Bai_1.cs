using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }
        private string getHTML(string szURL)
        {
            
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
        
        private void Get_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Content_txt.Text = getHTML(Url_txt.Text);
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Nhập lại url");
            }
        }
    }
}
