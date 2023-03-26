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
    public partial class Bai8_Result : Form
    {
        private int firstOctet, secondOctet, thirdOctet, lastOctet, subnetNum, subnetMask, hostBit, hostNum;

        private void subnetTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Bai8_Result()
        {
            InitializeComponent();
            Text = "Kết quả chia subnet";
        }
        public Bai8_Result(int first, int second, int third, int last, int num, int mask)
        {
            InitializeComponent();
            Text = "Kết quả chia subnet";
            firstOctet = first;
            secondOctet = second;
            thirdOctet = third;
            lastOctet = last;
            subnetNum = num;
            subnetMask = mask;
        }
        private void Bai8_Result_Load(object sender, EventArgs e)
        {
            int subnetDivided = 1, i;
            for(i = 1; i <= 22; i++)
            {
                subnetDivided = Convert.ToInt32(Math.Pow(2, i));
                if (subnetDivided > subnetNum) break;
            }
            subnetMask += i;
            switch (firstOctet)
            {
                case 10:
                    {
                        hostBit = 24 - i;
                        break;
                    }
                case 172:
                    {
                        hostBit = 16 - i;
                        break;
                    }
                case 192:
                    {
                        hostBit = 8 - i;
                        break;
                    }
            }
            hostNum = Convert.ToInt32(Math.Pow(2, hostBit)) - 2;
            for(i = 1; i <= subnetNum; i++)
            {
                string netAdd = firstOctet.ToString() + "." + secondOctet.ToString() + "." + thirdOctet.ToString() + "." + lastOctet.ToString() + "/" + subnetMask.ToString();
                lastOctet++;
                checkOctet();
                string firstHostAdd = firstOctet.ToString() + "." + secondOctet.ToString() + "." + thirdOctet.ToString() + "." + lastOctet.ToString();
                lastOctet += hostNum;
                checkOctet();
                string broadcastAdd = firstOctet.ToString() + "." + secondOctet.ToString() + "." + thirdOctet.ToString() + "." + lastOctet.ToString();
                lastOctet--;
                checkOctet();
                string lastHostAdd = firstOctet.ToString() + "." + secondOctet.ToString() + "." + thirdOctet.ToString() + "." + lastOctet.ToString();
                subnetTable.Rows.Add(i, netAdd, firstHostAdd, lastHostAdd, broadcastAdd);
                lastOctet += 2;
                checkOctet();
            }
        }
        private void checkOctet()
        {
            if (lastOctet > 255)
            {
                thirdOctet++;
                lastOctet %= 255;
                if (thirdOctet > 255)
                {
                    secondOctet++;
                    thirdOctet %= 255;
                }
            }
            else if (lastOctet < 0)
            {
                thirdOctet--;
                lastOctet = 255;
                if (thirdOctet < 0)
                {
                    secondOctet--;
                    thirdOctet = 255;
                }
            }
        }
    }
}
