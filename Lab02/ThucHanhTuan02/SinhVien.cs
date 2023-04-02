using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan02
{
    [Serializable]
    class SinhVien
    {
        public string name { get; set; }
        public int mssv { get; set; }
        public string phone { get; set; }
        public float firstGrade { get; set; }
        public float secondGrade { get; set; }
        public float thirdGrade { get; set; }

        public SinhVien()
        {
            name = "";
            mssv = 0;
            phone = "";
            firstGrade = 0;
            secondGrade = 0;
            thirdGrade = 0;
        }
        public SinhVien(string nameStr, string mssvStr, string phoneStr, string firstStr, string secondStr, string thirdStr)
        {
            name = nameStr;
            mssv = int.Parse(mssvStr);
            phone = phoneStr;
            firstGrade = float.Parse(firstStr);
            secondGrade = float.Parse(secondStr);
            thirdGrade = float.Parse(thirdStr);
        }
        public float avgGrade()
        {
            return (firstGrade + secondGrade + thirdGrade) / 3;
        }

    }
}
