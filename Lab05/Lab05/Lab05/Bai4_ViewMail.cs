using MailKit;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai4_ViewMail : Form
    {
        MimeMessage message = null;
        public Bai4_ViewMail()
        {
            InitializeComponent();
        }

        public Bai4_ViewMail(MimeMessage message)
        {
            this.message = message;
            InitializeComponent();
            Text = message.Subject;
            subjectLabel.Text = message.Subject;
            toLabel.Text = "To:\t" + message.To.ToString();
            fromLabel.Text = "From\t" + message.From.ToString();
            webBrowser1.DocumentText = message.HtmlBody.ToString();
            //MessageBox.Show(message.HtmlBody);
        }

        private void Bai4_ViewMail_Load(object sender, EventArgs e)
        {
            /*webBrowser1 = new WebBrowser
            {
                DocumentText = message.HtmlBody
            };
            webBrowser1.Show();
            //webBrowser1.Docu*/
        }
        private void LoadMail()
        {
            HtmlTextPreviewer htmlTextPreviewer = new HtmlTextPreviewer();
            htmlTextPreviewer.GetPreviewText(message.HtmlBody);
        }
    }
}
