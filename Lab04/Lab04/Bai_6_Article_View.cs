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
    public partial class Bai_6_Article_View : Form
    {
        private string link;
        public Bai_6_Article_View()
        {
            InitializeComponent();
        }

        public Bai_6_Article_View(string linkParam)
        {
            InitializeComponent();
            link = linkParam;
        }

        private void Bai_6_Article_View_Load(object sender, EventArgs e)
        {
            Uri uri = new Uri(link, UriKind.Absolute);
            webView21.Source = uri;
        }
    }
}
