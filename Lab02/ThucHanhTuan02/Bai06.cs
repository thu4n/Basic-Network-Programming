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


namespace ThucHanhTuan02
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
            FillTreeView();
        }
        private void FillTreeView()
        {
            string[] drives = Environment.GetLogicalDrives();
            TreeNode root;
            foreach(string drive in drives) 
            { 
                root = new TreeNode(drive);
                root.Tag = drive;
                root.ImageKey = "folder.png";
                root.SelectedImageKey = "folder.png";
                treeView1.Nodes.Add(root);
                GetDir(drive, root);
            }
        }
        private void GetDir(string subDir, TreeNode parent)
        {
            TreeNode node = new TreeNode();
            try
            {
                string[] folders = Directory.GetDirectories(subDir, "*", SearchOption.TopDirectoryOnly).ToArray();
                foreach (var folder in folders)
                {
                     if (!folder.Contains("$Recycle.Bin"))
                     {
                        DirectoryInfo dirInfo = new DirectoryInfo(folder);
                        node = new TreeNode(dirInfo.Name);
                        node.Name = folder;
                        node.ImageKey = "folder.png";
                        node.SelectedImageKey = "folder.png";
                        parent.Nodes.Add(node);
                     }
                }
                string[] files = Directory.GetFiles(subDir);
                foreach(var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    node = new TreeNode(fileInfo.Name);
                    node.Name = file;
                    if(fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                    {
                        node.ImageKey = "image.png";
                        node.SelectedImageKey = "image.png";
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        node.ImageKey = "doc.png";
                        node.SelectedImageKey = "doc.png";
                    }
                    parent.Nodes.Add(node);
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GetDir(e.Node.Name, e.Node);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FileInfo fileInfo = new FileInfo(e.Node.Name);
            if(fileInfo.Extension == ".txt")
            {
                TextBox textBox = new TextBox();
                try
                {
                    using (FileStream fs = new FileStream(fileInfo.FullName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            textBox.Multiline = true;
                            textBox.Dock = DockStyle.Fill;
                            textBox.BackColor = ColorTranslator.FromHtml("#1b2839");
                            textBox.ForeColor = Color.White;
                            textBox.BorderStyle = BorderStyle.None;
                            textBox.Text = sr.ReadToEnd();
                            splitContainer1.Panel2.Controls.Add(textBox);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if(fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
            {
                PictureBox pictureBox = new PictureBox();
                try
                {
                    using (FileStream fs = new FileStream(fileInfo.FullName, FileMode.Open))
                    {
                        pictureBox.Image = new Bitmap(fs);
                        pictureBox.Dock = DockStyle.Fill;
                        splitContainer1.Panel2.Controls.Add(pictureBox);
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Bai06_Load(object sender, EventArgs e)
        {

        }
    }

}
