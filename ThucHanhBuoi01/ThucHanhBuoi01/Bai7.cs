using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhBuoi01
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = dateTB.Text;
                DateTime date = DateTime.ParseExact(str,"dd/MM/yyyy", CultureInfo.InvariantCulture);
                int day = date.Date.Day;
                int month = date.Date.Month;
                int year = date.Date.Year;
                Bai7_Result res = new Bai7_Result(day, month, year);
                res.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập ngày tháng năm sinh đúng định dạng dd/mm/yyyy");
            }
        }
    }
}
