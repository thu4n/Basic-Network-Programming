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
using MailKit.Net.Smtp;
using System.IO;
using System.Security.Principal;

namespace Lab05
{
    public partial class Bai4_ViewMail : Form
    {
        SmtpClient smtpClient;
        string account;
        MimeMessage message = null;
        public Bai4_ViewMail()
        {
            InitializeComponent();
        }
        
        public Bai4_ViewMail(MimeMessage message, SmtpClient smtpClient, string account)
        {
            this.message = message;
            InitializeComponent();
            Text = message.Subject;
            subjectLabel.Text = message.Subject;
            toLabel.Text = "To:\t" + message.To.ToString();
            fromLabel.Text = "From\t" + message.From.ToString();
            webBrowser1.DocumentText = message.HtmlBody.ToString();
            //MessageBox.Show(message.HtmlBody);
            this.smtpClient = smtpClient;
            this.account = account;
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

        private void ReplyBtn_Click(object sender, EventArgs e)
        {
            message =  Reply(message,false);
            Bai4_SendMail sendMail = new Bai4_SendMail(smtpClient, account,message); 
            sendMail.Show(); 
        }
        public static MimeMessage Reply(MimeMessage message, bool replyToAll)
        {
            var reply = new MimeMessage();
            
            // reply to the sender of the message
            if (message.ReplyTo.Count > 0)
            {
                reply.To.AddRange(message.ReplyTo);
            }
            else if (message.From.Count > 0)
            {
                reply.To.AddRange(message.From);
            }
            else if (message.Sender != null)
            {
                reply.To.Add(message.Sender);
            }

            if (replyToAll)
            {
                // include all of the other original recipients - TODO: remove ourselves from these lists
                reply.To.AddRange(message.To);
                reply.Cc.AddRange(message.Cc);
            }

            // set the reply subject
            if (!message.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
                reply.Subject = "Re:" + message.Subject;
            else
                reply.Subject = message.Subject;

            // construct the In-Reply-To and References headers
            if (!string.IsNullOrEmpty(message.MessageId))
            {
                reply.InReplyTo = message.MessageId;
                foreach (var id in message.References)
                    reply.References.Add(id);
                reply.References.Add(message.MessageId);
            }

            // quote the original message text
            using (var quoted = new StringWriter())
            {
                var sender = message.Sender ?? message.From.Mailboxes.FirstOrDefault();

                quoted.WriteLine("On {0}, {1} wrote:", message.Date.ToString("f"), !string.IsNullOrEmpty(sender.Name) ? sender.Name : sender.Address);
                using (var reader = new StringReader(message.TextBody))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        quoted.Write("> ");
                        quoted.WriteLine(line);
                    }
                }

                reply.Body = new TextPart("plain")
                {
                    Text = quoted.ToString()
                };
            }

            return reply;
        }
    }
}
