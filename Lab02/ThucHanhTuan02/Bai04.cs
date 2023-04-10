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
using System.Runtime.Serialization.Formatters.Binary;

namespace ThucHanhTuan02
{
    public partial class Bai04 : Form
    {
        private FileStream fs;
        private BinaryFormatter bf;
        private SinhVien[] svOutput;
        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            previewTB.ScrollBars = ScrollBars.Vertical;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           string[] vals = { nameTB.Text, mssvTB.Text, phoneTB.Text, firstGradeTB.Text, secondGradeTB.Text, thirdGradeTB.Text };
           for(int i = 0; i < vals.Length; i++)
            {
                if (i == 0)
                {
                    foreach(char c in vals[i])
                    {
                        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                        {
                            MessageBox.Show("Vui lòng nhập tên đúng định dạng");
                            return;
                        }
                    }
                }
                else if (i == 1 || i == 2)
                {
                    if (i == 2 && (vals[i][0] != '0' || vals[i].Length < 1))
                    {
                        MessageBox.Show("SĐT phải có số 0 ở đầu và có đủ 10 chữ số");
                        return;
                    }
                    if (!int.TryParse(vals[i], out int res))
                    {
                        MessageBox.Show("Vui lòng nhập MSSV và SĐT dưới định dạng số nguyên");
                        return;
                    }
                }
                else
                {
                    if(!float.TryParse(vals[i], out float res) || res < 0 || res > 10)
                    {
                        MessageBox.Show("Vui lòng nhập điểm các môn học dưới dạng số thực từ 0 đến 10");
                        return;
                    }
                }
            }
            previewTB.Text += nameTB.Text + "\r\n" + mssvTB.Text + "\r\n" + phoneTB.Text + "\r\n" + firstGradeTB.Text + "\r\n" + secondGradeTB.Text + "\r\n" + thirdGradeTB.Text + "\r\n\r\n";
            nameTB.Text = "";
            mssvTB.Text = "";
            phoneTB.Text = "";
            firstGradeTB.Text = "";
            secondGradeTB.Text = "";
            thirdGradeTB.Text = "";
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            string[] allInfos = previewTB.Text.Split('\n');
            SinhVien[] sinhvien = new SinhVien[allInfos.Length/7]; // Mỗi sinh viên có 7 dòng, bao gồm dòng cách khoảng
            for(int i = 0; i < sinhvien.Length; i++)
            {
                int j = i * 7;
                sinhvien[i] = new SinhVien(allInfos[j], allInfos[j + 1], allInfos[j + 2], allInfos[j + 3], allInfos[j + 4], allInfos[j + 5]);
            }
            try
            {
                using(fs = new FileStream(@"..\..\Test Case Files\input4.txt", FileMode.OpenOrCreate))
                {
                    bf = new BinaryFormatter();
                    bf.Serialize(fs, sinhvien);
                    MessageBox.Show("Đã ghi vào file ở: " + fs.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            using (fs = File.OpenRead(@"..\..\Test Case Files\input4.txt"))
            {
                svOutput = (SinhVien[])bf.Deserialize(fs);
            }
            string str = "";
            for(int i = 0; i < svOutput.Length; i++)
            {
                str += svOutput[i].name + "\r\n" + svOutput[i].mssv.ToString() + "\r\n" + svOutput[i].phone + "\r\n" + svOutput[i].firstGrade.ToString() + "\r\n" + svOutput[i].secondGrade.ToString() + "\r\n" + svOutput[i].thirdGrade.ToString() + "\r\n" + svOutput[i].avgGrade().ToString();
            }
            using (fs = new FileStream(@"..\..\Test Case Files\output4.txt", FileMode.OpenOrCreate))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(str);
                    setInfo(svOutput, 1);
                }
                MessageBox.Show("Đã đọc và ghi file kết quả ở: " + fs.Name);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (pageNumLabel.Text == "1") return;
            int num = int.Parse(pageNumLabel.Text) - 1;
            setInfo(svOutput, num);
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(pageNumLabel.Text) >= svOutput.Length) return;
            int num = int.Parse(pageNumLabel.Text) + 1;
            setInfo(svOutput, num);
        }
        private void setInfo(SinhVien[] sv, int num)
        {
            pageNumLabel.Text = num.ToString();
            num--;
            showNameTB.Text = sv[num].name;
            showMSSVTB.Text = sv[num].mssv.ToString();
            showPhoneTB.Text = sv[num].phone;
            show1stGradeTB.Text = sv[num].firstGrade.ToString();
            show2ndGradeTB.Text = sv[num].secondGrade.ToString();
            show3rdGradeTB.Text = sv[num].thirdGrade.ToString();
            showAvgTB.Text = sv[num].avgGrade().ToString();
        }
    }
}
