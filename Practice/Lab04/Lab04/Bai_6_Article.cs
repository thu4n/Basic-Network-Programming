using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab04
{
    public partial class Bai_6_Article : UserControl
    {
        string article;
        public Bai_6_Article()
        {
            InitializeComponent();
        }
        public Bai_6_Article(string title, string desc, string imgLink, string articleLink)
        {
            InitializeComponent();
            titleLabel.Text = title;
            descLabel.Text = desc;
            if (imgLink.Contains("https") || imgLink.Contains("http"))
                pictureBox1.Load(imgLink);
            article = articleLink;

        }
        private void Bai_6_Article_Load(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            Bai_6_Article_View view = new Bai_6_Article_View(article);
            view.Show();
        }
    }
}
