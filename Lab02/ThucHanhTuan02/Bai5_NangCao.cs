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
using System.IO.Compression;

namespace ThucHanhTuan02
{
    public partial class Bai5_NangCao : Form
    {
        BackgroundWorker backgroundWorker;
        private OpenFileDialog ofd;
        private FileStream fs;
        private FileInfo fi;
        private string zipPath = @"..\..\Test Case Files\";
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
                fs.Close();
            }
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (fs = new FileStream(zipPath, FileMode.Create))
                {
                    using (ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Create))
                    {
                        archive.CreateEntryFromFile(ofd.FileName, ofd.SafeFileName);
                        fi = new FileInfo(zipPath);
                        MessageBox.Show("Đã nén file thành công, file được tạo ở: " + fi.FullName);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void decompressBtn_Click(object sender, EventArgs e)
        {
            try
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
            }
        }
    }
}
