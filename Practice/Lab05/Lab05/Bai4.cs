﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Net.Imap;

namespace Lab05
{
    public partial class Bai4 : Form
    {
        SmtpClient smtpClient;
        ImapClient imapClient;
        int smtpPort = 0, imapPort = 0;
        string smtpHost, imapHost;
        string account, password;
        IMailFolder inbox = null;
        public Bai4()
        {
            InitializeComponent();
        }
        public static bool CheckEmail(string email)
        {

            if (MailboxAddress.TryParse(email, out MailboxAddress mailboxAddress))
            {
                return true;
            }
            return false;

        }

        private async void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && inbox != null)
            {
                var message = await inbox.GetMessageAsync(e.RowIndex);
                Bai4_ViewMail viewMail = new Bai4_ViewMail(message,smtpClient, account);
                viewMail.Show();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Bai4_SendMail sendView = new Bai4_SendMail(smtpClient, account);
            sendView.Show();
        }

        // jughocgapaqbyiqh
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            if(loginBtn.Text == "Đăng xuất")
            {
                await imapClient.DisconnectAsync(true);
                await smtpClient.DisconnectAsync(true);
                SetState(false);
                loginBtn.Text = "Đăng nhập";
                return;
            }
            if(emailTB.Text.Length == 0 || passwordTB.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if(!CheckEmail(emailTB.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }
            int.TryParse(smtpPortNum.Value.ToString(), out smtpPort);
            int.TryParse(imapPortNum.Value.ToString(), out imapPort);
            imapHost = imapTB.Text;
            smtpHost = smtpTB.Text;
            account = emailTB.Text;
            password = passwordTB.Text;
            smtpClient = new SmtpClient();
            imapClient = new ImapClient();
            await imapClient.ConnectAsync(imapHost, imapPort);
            await imapClient.AuthenticateAsync(account, password);
            await smtpClient.ConnectAsync(smtpHost, smtpPort);
            await smtpClient.AuthenticateAsync(emailTB.Text, passwordTB.Text);
            if (imapClient.IsAuthenticated && smtpClient.IsAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công");
                loginBtn.Text = "Đăng xuất";
                SetState(true);
            }
            DisplayMail();

        }

        private void SetState(bool state)
        {
            imapTB.ReadOnly = state;
            smtpTB.ReadOnly = state;
            smtpPortNum.ReadOnly = state;
            imapPortNum.ReadOnly = state;
            emailTB.ReadOnly = state;
            passwordTB.ReadOnly = state;

            sendBtn.Visible = state;
            refreshBtn.Visible = state;
        }
        private async void DisplayMail()
        {
            inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i=0; i < 25;i++)
            {
                var message = await inbox.GetMessageAsync(i);
                dataGridView1.Rows.Add(i+1, message.From.ToString(), message.Subject, message.Date.ToString());
            }
        }
    }
}
