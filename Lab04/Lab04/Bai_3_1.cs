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
    public partial class Bai_3_1 : Form
    {
        public string urls = "";
        public string location = "";
        public Bai_3_1()
        {
            InitializeComponent();
        }
       //
        public Bai_3_1(string url, string location)
        {
            InitializeComponent();
            urls = url;
            this.location = location;
        }
        //
        public List<string> FetchImages(string Url)
        {
            List<string> imageList = new List<string>();
            var htmlDoc = new HtmlAgilityPack.HtmlWeb().Load(Url);
            var htmlData = htmlDoc.DocumentNode.OuterHtml;
            string imageHtmlCode = "<img";
            string imageSrcCode = @"src=""";

            int index = htmlData.IndexOf(imageHtmlCode);
            while (index != -1)
            {
                //Xóa dữ liệu trước đó
                htmlData = htmlData.Substring(index);
                //TÌm vị trí đánh dấu của ảnh
                int brackedEnd = htmlData.IndexOf('>'); //kiểm tra dữ liệu ở trong tag image
                int start = htmlData.IndexOf(imageSrcCode) + imageSrcCode.Length;
                int end = htmlData.IndexOf('"', start + 1);
                //lưu đường dẫn  .
                if (end > start && start < brackedEnd)
                {
                    string loc = htmlData.Substring(start, end - start);
                    if (loc.Contains("https") || loc.Contains("http"))
                        imageList.Add(loc);
                }
                // kiểm tra xem đã duyệt hết dữ liệu hay chưa.
                if (imageHtmlCode.Length < htmlData.Length)
                    index = htmlData.IndexOf(imageHtmlCode, imageHtmlCode.Length);
                else
                    index = -1;
            }
            return imageList;
        }
        private void ListFile_SelectedValueChanged(object sender, EventArgs e)
        {
            string curItem = ListFile.SelectedItem.ToString();
            picImages.Load(curItem);
        }
        private void Bài_3_1_Load(object sender, EventArgs e)
        {
            foreach (string image in FetchImages(urls))
            {
                ListFile.Items.Add(image);
            }
            foreach (var item in ListFile.Items)
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        string fileName = Path.GetFileName(new UriBuilder(item.ToString()).Path);
                        webClient.DownloadFile(item.ToString(), location + fileName);
                    }
                    catch {}
                }
            }
        }
    }
}
