using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Lab04
{
    public partial class Bài_3 : Form
    {
        public Bài_3()
        {
            InitializeComponent(); System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
       
        public List<string> FetchImages(string Url)
        {
            List<string> imageList = new List<string>();

            if (!Url.StartsWith("http://") && !Url.StartsWith("https://"))
                Url = "http://" + Url;
          
            var htmlDoc = new HtmlAgilityPack.HtmlWeb().Load(Url);
            var htmlData = htmlDoc.DocumentNode.OuterHtml;
            string imageHtmlCode = "<img";
            string imageSrcCode = @"src=""";

            int index = htmlData.IndexOf(imageHtmlCode);
            while (index != -1)
            {
                //Remove previous data
                htmlData = htmlData.Substring(index);

                //Find the location of the two quotes that mark the image's location
                int brackedEnd = htmlData.IndexOf('>'); //make sure data will be inside img tag
                int start = htmlData.IndexOf(imageSrcCode) + imageSrcCode.Length;
                int end = htmlData.IndexOf('"', start + 1);

                //Extract the line
                if (end > start && start < brackedEnd)
                {
                    string loc = htmlData.Substring(start, end - start);

                    //Store line
                    imageList.Add(loc);
                }

                //Move index to next image location
                if (imageHtmlCode.Length < htmlData.Length)
                    index = htmlData.IndexOf(imageHtmlCode, imageHtmlCode.Length);
                else
                    index = -1;
            }

            //Format the image URLs
            for (int i = 0; i < imageList.Count; i++)
            {
                string img = imageList[i];

                string baseUrl = GetBaseURL(Url);

                if ((!img.StartsWith("http://") && !img.StartsWith("https://"))
                    && baseUrl != string.Empty)
                    img = baseUrl + "/" + img.TrimStart('/');

                imageList[i] = img;
            }
            return imageList;
        }

        private string GetBaseURL(string Url)
        {
            int inx = Url.IndexOf("://") + "://".Length;
            int end = Url.IndexOf('/', inx);

            string baseUrl = string.Empty;
            if (end != -1)
                return Url.Substring(0, end);
            else
                return string.Empty;
        }


        public bool ExploreFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                return false;
            }

            filePath = System.IO.Path.GetFullPath(filePath);
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
            return true;
        }

        private void ListFile_SelectedValueChanged(object sender, EventArgs e)
        {
            string curItem = ListFile.SelectedItem.ToString();
            picImages.LoadAsync(curItem);
        }

        private void Download_Click(object sender, EventArgs e)
        {
            var firstname = "";
            foreach (var item in ListFile.Items)
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        string fileName = Path.GetFileName(new UriBuilder(item.ToString()).Path);
                        webClient.DownloadFile(item.ToString(), "C:\\Users\\ACER\\Downloads\\" + fileName);
                        firstname = fileName;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            ExploreFile(Application.StartupPath + $"\\images\\{firstname}");
        }

        private void GetImage_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            ListFile.Items.Clear();

            foreach (string image in FetchImages(txtURL.Text))
            {
                ListFile.Items.Add(image);
            }

            this.Cursor = Cursors.Default;
        }
    }
}
