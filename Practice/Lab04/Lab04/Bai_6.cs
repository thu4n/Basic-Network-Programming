using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab04
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            string url = urlTB.Text;
            var htmlDoc = new HtmlAgilityPack.HtmlWeb().Load(url);
            var articleList = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article").ToList();
            DisplayArticles(articleList);
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayArticles(List<HtmlNode> articleList)
        {
            Bai_6_Article[] articlePanels = new Bai_6_Article[articleList.Count];
            progressBar1.Maximum = articlePanels.Length;
            for(int i =0; i < articlePanels.Length; i++)
            {
                try
                {
                    string imgTag = articleList[i].SelectSingleNode($"//*[@id=\"automation_TV0\"]/div[2]/article[{i+1}]/div/a/picture/img").OuterHtml;
                    string title = articleList[i].SelectSingleNode($"//*[@id=\"automation_TV0\"]/div[2]/article[{i + 1}]/h2/a").InnerText;
                    string titleTag = articleList[i].SelectSingleNode($"//*[@id=\"automation_TV0\"]/div[2]/article[{i + 1}]/h2/a").OuterHtml;
                    string desc = articleList[i].SelectSingleNode($"//*[@id=\"automation_TV0\"]/div[2]/article[{i + 1}]/p/a").InnerText;
                    string imgLink = GetImgLink(imgTag);
                    string articleLink = GetArticleLink(titleTag);
                    articlePanels[i] = new Bai_6_Article(title, desc, imgLink, articleLink);
                    flowLayoutPanel1.Controls.Add(articlePanels[i]);
                }
                catch(Exception) {  }
                finally
                {
                    progressBar1.Value = i + 1;
                    Application.DoEvents();
                }
            }
        }

        private string GetImgLink(string imgTag)
        {
            string imgSrc = @"src=""";
            if (imgTag.Contains("base64"))
            {
                imgSrc = @"data-src=""";
            }
            int start = imgTag.IndexOf(imgSrc) + imgSrc.Length;
            int end = imgTag.IndexOf('"', start + 1);
            string link = imgTag.Substring(start, end - start);
            return link;
        }

        private string GetArticleLink(string title)
        {
            string href = @"href=""";
            int start = title.IndexOf(href) + href.Length;
            int end = title.IndexOf('"', start + 1);
            string link = title.Substring(start, end - start);
            return link;
        }
    }
}
