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
    public partial class bai01 : Form
    {
        private StreamReader sr;
        private FileStream fs;
        public bai01()
        {
            InitializeComponent();
        }

        private void bai01_Load(object sender, EventArgs e)
        {

        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                using (fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    using (sr = new StreamReader(fs))
                    {
                        textBox.Text = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (fs = new FileStream(@"..\..\Test Case Files\output1.txt", FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(textBox.Text.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
