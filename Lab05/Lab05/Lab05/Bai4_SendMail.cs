using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai4_SendMail : Form
    {
        SmtpClient smtpClient;
        string email;
        OpenFileDialog ofd;
        bool imgChosen = false;
        MimeMessage msg = new MimeMessage();
        public Bai4_SendMail()
        {
            InitializeComponent();
        }

        public Bai4_SendMail(SmtpClient smtpClient, string email)
        {
            this.smtpClient = smtpClient;
            this.email = email;
            InitializeComponent();
        }
        public Bai4_SendMail(SmtpClient smtpClient, string email, MimeMessage message)
        {
            this.smtpClient = smtpClient;
            this.email = email;
            this.msg = message;
            InitializeComponent();
        }
        private void Bai4_SendMail_Load(object sender, EventArgs e)
        {
            fromTB.Text = email;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                pathTB.Text = ofd.FileName;
                imgChosen = true;
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Không có file nào được chọn");
                imgChosen = false;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(toTB.Text.Length == 0 || subjectTB.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            //var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(nameTB.Text,fromTB.Text));
            msg.To.Add(new MailboxAddress("", toTB.Text));
            msg.Subject = subjectTB.Text;
            TextPart body;
            if(checkBox1.Checked)
            {
                body = new TextPart("html") {Text = bodyTB.Text };
            }
            else
            {
                body = new TextPart("plain") {Text = bodyTB.Text };
            }
            if (imgChosen)
            {
                var attachment = new MimePart()
                {
                    Content = new MimeContent(File.OpenRead(ofd.FileName)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(ofd.FileName)
                };
                var multipart = new Multipart("mixed")
                {
                    body,
                    attachment
                };
                msg.Body = multipart;
            }
            else
            {
                msg.Body = body;
            }
            smtpClient.Send(msg);
            Close();
        }
    }
}
