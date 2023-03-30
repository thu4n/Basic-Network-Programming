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

namespace ThucHanhTuan02
{
    public partial class Bai02 : Form
    {
        private StreamReader sr;
        public Bai02()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            sr = new StreamReader(fs);
            textBox.Text = sr.ReadToEnd();
            fileNameTB.Text = ofd.SafeFileName;
            urlTB.Text = ofd.FileName;
            long length = sr.BaseStream.Length;
            sizeTB.Text = length.ToString() + " bytes";
            string[] str1 = textBox.Text.Split('\n');
            lineCountTB.Text = str1.Length.ToString();
            char[] chars = new char[] { ' ', '\r', '\n' };
            string[] str2 = textBox.Text.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            wordCountTB.Text = str2.Length.ToString();
            characterCountTB.Text = textBox.Text.Length.ToString();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
