using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MailKit.Net.Smtp;
using MimeKit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace Lab05
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate("tinthien2003@gmail.com", "xymnehxlmrupryfn"); // gmail account, app password
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("tinthien2003@gmail.com", From.Text));
                message.To.Add(new MailboxAddress("", To.Text));
                message.Subject = Subject.Text;
                message.Body = new TextPart("plain")
                {
                    Text = Body.Text
                };
                client.Send(message);
            }
            catch (Exception) { MessageBox.Show("error"); }
        }
    }
}