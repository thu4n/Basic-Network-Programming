using HtmlAgilityPack;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void Bai1_Click(object sender, EventArgs e)
        {
            var b1 = new Bài_1();
            b1.Show();
        }
 
        private void Bai2_Click_1(object sender, EventArgs e)
        {
            var b2 = new Bài_2();
            b2.Show();
        }

        private void Bai3_Click_1(object sender, EventArgs e)
        {
            var b3 = new Bai3();
            b3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };

            //Load trang web, nạp html vào document
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("http://www.webtretho.com/forum/f26/");

            //Load các tag li trong tag ul
                var threadItems = document.DocumentNode.SelectNodes("").ToList();

            var items = new List<object>();
            foreach (var item in threadItems)
            {
                //Extract các giá trị từ các tag con của tag li
                var linkNode = item.SelectSingleNode(".//a[contains(@class,'title')]");
                var link = linkNode.Attributes["href"].Value;
                var text = linkNode.InnerText;
                var readCount = item.SelectSingleNode(".//div[@class='folTypPost']/ul/li/b").InnerText;

                items.Add(new { text, readCount, link });
            }
        }
    }
}
