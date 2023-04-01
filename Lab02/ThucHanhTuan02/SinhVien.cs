using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan02
{
    class SinhVien
    {
        private string name { get; set; }
        private int mssv { get; set; }
        private string phone { get; set; }
        private float firstGrade { get; set; }
        private float secondGrade { get; set; }
        private float thirdGrade { get; set; }

        public SinhVien()
        {
            name = "";
            mssv = 0;
            phone = "";
            firstGrade = 0;
            secondGrade = 0;
            thirdGrade = 0;
        }
        public float avgGrade()
        {
            return (firstGrade + secondGrade + thirdGrade) / 3;
        }

    }
}
