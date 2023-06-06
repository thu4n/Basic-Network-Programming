using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit.Net.Pop3;
using MailKit.Security;

namespace Lab05
{
    public partial class Bai2_3 : Form
    {
        public Bai2_3()
        {
            InitializeComponent();
        }

        private void IMAP_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ImapClient();
                client.CheckCertificateRevocation = false;
                client.Connect("imap.gmail.com", 993, true); // smtp host, port, use ssl.
                client.Authenticate(User_txt.Text, Pass_txt.Text); // gmail accout, app password.
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                int limit = 10;
                for (int i = 0; i < limit; i++)
                {
                    var message = inbox.GetMessage(i);
                    string[] arr = new string[3];
                    ListViewItem itm;
                    arr[0] = message.Subject;
                    arr[1] = message.From.ToString();
                    arr[2] = message.Date.ToString();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception) { MessageBox.Show("Read fail"); }
        }

        private void POP_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Pop3Client client = new Pop3Client();
                client.CheckCertificateRevocation = false;
                client.Connect("pop.gmail.com", 995, SecureSocketOptions.Auto);
                client.Authenticate(User_txt.Text, Pass_txt.Text);
                var inbox = client.GetMessageCount().ToString();
                int limit = 10;
                for (int i = 0; i < limit; i++)
                {
                    string[] arr = new string[4];
                    var message = client.GetMessage(i);
                    var item = new ListViewItem(new[]
                    {
                    message.Subject,
                    message.From.ToString(),
                    message.Date.ToString()
                });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception) { MessageBox.Show("Read fail"); }
        }

        private void Bai2_3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Email", 300);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 200);
            listView1.View = View.Details;
        }
    }
}
