using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace ftp_client
{
    public partial class FTPClientForm : Form
    {
        private string IPServer;
        private string username;
        private string password;
        public FTPClientForm()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(localFilePath);

                IPServer = IPServerTB.Text;
                username = UsernameTB.Text;
                password = PasswordTB.Text;

                try
                {
                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + IPServer + "/" + fileName);
                    ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                    ftpRequest.Credentials = new NetworkCredential(username, password);
                    ftpRequest.UsePassive = true; // Thêm dòng này

                    using (Stream ftpStream = ftpRequest.GetRequestStream())
                    using (FileStream fileStream = File.OpenRead(localFilePath))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = 0;
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ftpStream.Write(buffer, 0, bytesRead);
                        }
                    }

                    MessageBox.Show("File uploaded successfully!");
                    RefreshFileList();
                }
                catch (WebException ex)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        MessageBox.Show("File not found on the server.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            RefreshFileList();
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (fileListLV.SelectedItems.Count > 0)
            {
                string selectedFile = fileListLV.SelectedItems[0].Text;
                string ftpFilePath = "ftp://" + IPServer + "/" + selectedFile;
                string localFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), selectedFile);

                try
                {
                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpFilePath);
                    ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    ftpRequest.Credentials = new NetworkCredential(username, password);

                    using (FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse())
                    using (Stream ftpStream = ftpResponse.GetResponseStream())
                    using (FileStream fileStream = File.Create(localFilePath))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = 0;
                        while ((bytesRead = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                    }

                    MessageBox.Show("File downloaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshFileList();
        }
        private void RefreshFileList()
        {
            try
            {
                IPServer = IPServerTB.Text;
                username = UsernameTB.Text;
                password = PasswordTB.Text;

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + IPServer);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.Credentials = new NetworkCredential(username, password);

                using (FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse())
                using (Stream ftpStream = ftpResponse.GetResponseStream())
                using (StreamReader reader = new StreamReader(ftpStream))
                {
                    fileListLV.Items.Clear();

                    string[] fileNames = reader.ReadToEnd().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        string fileName = fileNames[i];

                        FtpWebRequest fileInfoRequest = (FtpWebRequest)WebRequest.Create("ftp://" + IPServer + "/" + fileName);
                        fileInfoRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                        fileInfoRequest.Credentials = new NetworkCredential(username, password);

                        using (FtpWebResponse fileInfoResponse = (FtpWebResponse)fileInfoRequest.GetResponse())
                        {
                            long fileSize = fileInfoResponse.ContentLength;
                            DateTime creationDate = DateTime.Now;
                            ListViewItem item = new ListViewItem((i + 1).ToString());
                            item.SubItems.Add(fileName);
                            item.SubItems.Add(creationDate.ToString());
                            item.SubItems.Add(fileSize.ToString() + " bytes");

                            fileListLV.Items.Add(item);
                        }
                    }

                    // Đặt tên cho các cột
                    if (fileListLV.Columns.Count == 0)
                    {
                        fileListLV.Columns.Add("Number");
                        fileListLV.Columns.Add("FileName");
                        fileListLV.Columns.Add("Date");
                        fileListLV.Columns.Add("Size");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }
    }
}
