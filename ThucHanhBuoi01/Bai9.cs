using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhBuoi01
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
            Text = "Bài 08 – Xử lý mảng & Tổng hợp";
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            string[] infos = infoTB.Text.Split(',');
            double[] grades = new double[infos.Length];
            string name = infos[0];
            foreach(char c in name)
            {
                if (c == ' ') continue;
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Vui lòng nhập tên đúng định dạng, không chứa kí tự đặc biệt");
                    return;
                }
            }
            try
            {
                for(int i = 1; i < infos.Length; i++)
                {
                    grades[i] = double.Parse(infos[i]);
                    if(grades[i] > 10 || grades[i] < 0)
                    {
                        MessageBox.Show("Vui lòng nhập điểm theo thang điểm 10");
                        return;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;

            }
            Bai9_Result res = new Bai9_Result(name, grades,grades.Length);
            res.Show();
        }
    }
}
