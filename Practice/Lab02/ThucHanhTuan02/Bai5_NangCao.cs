using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.IO.Compression;
using Ionic.Zip;

namespace ThucHanhTuan02
{
    // Chịu thua, rồi một ngày ta sẽ báo thù bài này :((
    public partial class Bai5_NangCao : Form
    {
        BackgroundWorker backgroundWorker;
        private OpenFileDialog ofd;
        private FileStream fs;
        private FileInfo fi;
        private string zipPath = @"..\..\Test Case Files\output5_advance.zip";
        public Bai5_NangCao()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                fileNameTB.Text = ofd.SafeFileName;
                //fs.Close();
            }
        }

        private async void compressBtn_Click(object sender, EventArgs e)
        {
            await Task.Run(() => {
                try
                {
                    fi = new FileInfo(ofd.FileName);
                    
                    long totalBytes = fi.Length;
                    long currentBytes = 0;

                    using (ZipFile zipFile = new ZipFile())
                    {
                        ZipEntry entry = zipFile.AddEntry(fi.Name, fs);
                        //zipFile.AddFile(fi.FullName,"");
                        //zipFile.Ad
                        /*zipFile.SaveProgress += (o, args) =>
                        {
                            var percentage = (int)((1.0d / args.TotalBytesToTransfer) * args.BytesTransferred * 100.0d);
                            //progressBar1.Value = percentage;
                            MessageBox.Show(args.TotalBytesToTransfer.ToString());
                            //progressBar1.Parent.Invoke(new MethodInvoker ( delegate { progressBar1.Value += 2; } ));
                        };*/
                        zipFile.Save(zipPath);
                        fs.Close();
                    }
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs = new FileStream(zipPath, FileMode.Open);
                        //ms.Seek
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
            
        }

        private void decompressBtn_Click(object sender, EventArgs e)
        {
            /*try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    ZipArchiveEntry entry = archive.Entries[0];
                    entry.ExtractToFile(Path.Combine(@"..\..\Test Case Files", "output5.txt"), true);
                    MessageBox.Show("Đã nén file thành công, file được tạo ở: " + fi.FullName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }
    }
}
