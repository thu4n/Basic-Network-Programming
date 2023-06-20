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
    public partial class Bai9_Result : Form
    {
        string studentName;
        double[] studentGrades = { };
        public Bai9_Result()
        {
            InitializeComponent();
            Text = "Result form";
        }
        public Bai9_Result(string name, double[] grades, int len)
        {
            InitializeComponent();
            Text = "Result form";
            studentName = name;
            studentGrades = new double[len];
            for(int i = 0; i < grades.Length; i++) studentGrades[i] = grades[i];
            
        }

        private void Bai9_Result_Load(object sender, EventArgs e)
        {
            showNameLabel.Text = studentName;
            for(int i = 1; i < studentGrades.Length; i++)
            {
                string str = "Môn " + i.ToString() + ": " + studentGrades[i].ToString();
                gradesTable.Columns.Add("Diem mon hoc", str);
            }
            double maxG = 0, minG = 10,sum=0;
            int maxIndex=0, minIndex=0, failCount=0;
            int rankFlag, finalRankFlag = 0;
            for (int i = 1; i < studentGrades.Length; i++)
            {
                rankFlag = 0;
                if (studentGrades[i] > maxG) 
                { 
                    maxG = studentGrades[i];
                    maxIndex = i;
                }
                if (studentGrades[i] < minG)
                {
                    minG = studentGrades[i];
                    minIndex = i;
                }
                if (studentGrades[i] < 6.5) rankFlag++;
                if (studentGrades[i] < 5)
                {
                    failCount++;
                    rankFlag++;
                }
                if (studentGrades[i] < 3.5) rankFlag++;
                if (studentGrades[i] < 2) rankFlag++;
                if (rankFlag > finalRankFlag) finalRankFlag = rankFlag;
                sum += studentGrades[i];
            }
            double avg = Math.Round(sum /(studentGrades.Length - 1),2);
            showAvgLabel.Text = avg.ToString();
            showMaxLabel.Text = "Môn " + maxIndex.ToString() + " (" + maxG.ToString() + ")";
            showMinLabel.Text = "Môn " + minIndex.ToString() + " (" + minG.ToString() + ")";
            showPassLabel.Text = (studentGrades.Length - 1 - failCount).ToString();
            showNoPassLabel.Text = failCount.ToString();
            if (avg >= 8 && finalRankFlag == 0) showRankLabel.Text = "Giỏi";
            else if (avg >= 8 && finalRankFlag != 0) showRankLabel.Text = "Khá";
            else if (avg >= 6.5 && finalRankFlag <= 1) showRankLabel.Text = "Khá";
            else if (avg >= 6.5 && finalRankFlag > 1) showRankLabel.Text = "Trung bình";
            else if (avg >= 5 && finalRankFlag <= 2) showRankLabel.Text = "Trung bình";
            else if (avg >= 5 && finalRankFlag > 2) showRankLabel.Text = "Yếu";
            else if (avg >= 3.5 && finalRankFlag <= 3) showRankLabel.Text = "Yếu";
            else showRankLabel.Text = "Kém";
        }
    }
}
