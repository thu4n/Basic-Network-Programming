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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ftp_client
{
    public partial class FTPClientForm : Form
    {
        private string IPServer;
        private string username;
        private string password;
        private Dictionary<string,string> aryProp = new Dictionary<string, string>();
        private int cntFiles = 0;
        public FTPClientForm()
        {
            InitializeComponent();
            cntFiles = 0;
            IPServer = string.Empty;
            username = string.Empty;
            password = string.Empty;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmptyProfileUser() == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông báo");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(localFilePath);

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

                    MessageBox.Show("Upload file thành công!");
                    RefreshFileList();
                }
                catch (WebException ex)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        MessageBox.Show("Không tìm thấy trên Server");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            RefreshFileList();
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmptyProfileUser() == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông báo");
                return;
            }
            if (aryProp.Count > 0)
            {
                if(fileDownloadTB.Text == string.Empty)
                {
                    MessageBox.Show("Hãy chọn file để download", "Thông báo");
                    return;
                }
                string selectedFileName = fileDownloadTB.Text;

                try
                {
                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + IPServer + "/" + selectedFileName);
                    ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    ftpRequest.Credentials = new NetworkCredential(username, password);
                    ftpRequest.UsePassive = true; // Add this line if you're behind a firewall

                    using (FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse())
                    using (Stream ftpStream = ftpResponse.GetResponseStream())
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = selectedFileName;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string localFilePath = saveFileDialog.FileName;

                            using (FileStream fileStream = File.Create(localFilePath))
                            {
                                byte[] buffer = new byte[1024];
                                int bytesRead;
                                while ((bytesRead = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fileStream.Write(buffer, 0, bytesRead);
                                }
                            }

                            MessageBox.Show("Download File thành công!");
                        }
                    }
                }
                catch (WebException ex)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        MessageBox.Show("Không tìm thấy file trên server");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file download","Thông báo");
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmptyProfileUser() == false)
            {
                MessageBox.Show("Vui lòng đăng nhập", "Thông báo");
                return;
            }
            RefreshFileList();
        }
        private void RefreshFileList()
        {
            cntFiles = 0;
            try
            {
                this.aryProp = new Dictionary<string, string>();
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
                            ListViewItem item = new ListViewItem((i + 1).ToString());
                            item.SubItems.Add(fileName);
                            ++cntFiles;
                            this.aryProp.Add(fileName,cntFiles.ToString());
                            fileListLV.Items.Add(fileName);
                        }
                        
                    }

                    // Đặt tên cho các cột
                    if (fileListLV.Columns.Count == 0)
                    {
                        fileListLV.Columns.Add("FileName");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            

        }

        private void FTPClientForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            IPServer = IPServerTB.Text;
            username = UsernameTB.Text;
            password = PasswordTB.Text;
        }

        public bool CheckEmptyProfileUser()
        {
            if(IPServer == string.Empty)
            {
                return false;
            }
            if (username == string.Empty)
            {
                return false;
            }
            if (password == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void fileListLV_DoubleClick(object sender, EventArgs e)
        {
            fileDownloadTB.Text = fileListLV.SelectedItems[0].Text;
        }
    }
}
