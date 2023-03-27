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
    public partial class Bai7_Result : Form
    {
        private int day, month, year;
        string[] weekDays = { "Thứ Bảy", "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu" };
        int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Bai7_Result()
        {
            InitializeComponent();
            Text = "Kết quả chiêm tinh học, cực kỳ real";
        }
        public Bai7_Result(int d, int m, int y)
        {
            InitializeComponent();
            Text = "Kết quả chiêm tinh học, cực kỳ real";
            day = d;
            month = m;
            year = y;
        }

        private void Bai7_Result_Load(object sender, EventArgs e)
        {
            weekDayCalc(day, month, year);
            zodiacCalc(day, month);
            if (day == 5 && month == 5)
            {
                personaTB.Text = "Người sinh vào ngày này có ngoại hình của một siêu sao, trí óc siêu việt và là người có tầm ảnh hưởng lớn đến thế giới.";
            }
            else
            {
                personaTB.Text = "Bạn là một người bình thường và có hứng thú với công nghệ thông tin nói chung kèm theo sự tự tin nhất định về kiến thức của mình trong lĩnh vực. Bạn còn có năng khiếu giảng dạy cho người khác";
            }
        }
        private void weekDayCalc(int d,int m,int y)
        {
            int days = 0;
            // Lấy mốc là 01/01/1800 => Thứ Tư
            if (year > 1800)
            {
                for (int i = 1800; i < year; i++)
                {
                    if (i % 4 == 0 && i % 100 != 0) days += 366;
                    else if (i % 100 == 0 && i % 400 == 0) days += 366;
                    else days += 365;
                }
                for (int i = 1; i < month; i++)
                {
                    days += monthDays[i];
                }
            }
            else
            {
                for (int i = year; i < 1800; i++)
                {
                    if (i % 4 == 0 && i % 100 != 0) days += 366;
                    else if (i % 100 == 0 && i % 400 == 0) days += 366;
                    else days += 365;
                }
                for (int i = 1; i < month; i++)
                {
                    days += monthDays[i];
                }
            }
            days += day - 1; // Final gap between two dates
            int weekday = days % 7; // In the year 1800
            int daysGap = weekday + 4; // Wednesday
            dateTB.Text = weekDays[daysGap % 7];
        }
        private void zodiacCalc(int d, int m)
        {
            switch (m)
            {
                case 1:
                    {
                        if (d >= 21) signTB.Text = "Bảo Bình";
                        else signTB.Text = "Ma Kết";
                        break;
                    }
                case 2:
                    {
                        if (d >= 20) signTB.Text = "Song Ngư";
                        else signTB.Text = "Bảo Bình";
                        break;
                    }
                case 3:
                    {
                        if (d >= 21) signTB.Text = "Bạch Dương";
                        else signTB.Text = "Song Ngư";
                        break;
                    }
                case 4:
                    {
                        if (d >= 21) signTB.Text = "Kim Ngưu";
                        else signTB.Text = "Bạch Dương";
                        break;
                    }
                case 5:
                    {
                        if (d >= 22) signTB.Text = "Song Tử";
                        else signTB.Text = "Kim Ngưu";
                        break;
                    }
                case 6:
                    {
                        if (d >= 22) signTB.Text = "Cự Giải";
                        else signTB.Text = "Song Tử";
                        break;
                    }
                case 7:
                    {
                        if (d >= 23) signTB.Text = "Sư Tử";
                        else signTB.Text = "Cự Giải";
                        break;
                    }
                case 8:
                    {
                        if (d >= 23) signTB.Text = "Xử Nử";
                        else signTB.Text = "Sư Tử";
                        break;
                    }
                case 9:
                    {
                        if (d >= 24) signTB.Text = "Thiên Bình";
                        else signTB.Text = "Xử Nữ";
                        break;
                    }
                case 10:
                    {
                        if (d >= 24) signTB.Text = "Thần Nông";
                        else signTB.Text = "Thiên Bình";
                        break;
                    }
                case 11:
                    {
                        if (d >= 23) signTB.Text = "Nhân Mã";
                        else signTB.Text = "Thần Nông";
                        break;
                    }
                case 12:
                    {
                        if (d >= 22) signTB.Text = "Ma Kết";
                        else signTB.Text = "Nhân Mã";
                        break;
                    }
            }
        }
    }
}
