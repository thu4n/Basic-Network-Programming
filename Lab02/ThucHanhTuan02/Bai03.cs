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
    public partial class Bai03 : Form
    {
        private StreamReader sr;
        public Bai03()
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
            sr.Close();
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBox.Text.ToUpper());
            sw.Close();
            sr.Close();*/
            //textBox.Text = "12 – 7 – 5 + 2 – 3";
            /*string str = "12 - 7 - 5 + 2 - 3";
            float res = stackProcessing(str);
            textBox.Text += str + " = " + res.ToString() + "\r\n";*/
            string[] expressions = textBox.Text.Split('\n');
            textBox.Text += "\r\n";
            for (int i = 0; i < expressions.Length; i++)
            {
                float res = stackProcessing(expressions[i]); ;
                textBox.Text += expressions[i] + " = " + res.ToString() + "\r\n";
            }
        }
        private float stackProcessing(string str)
        {   
            Stack<float> nums = new Stack<float>();
            Stack<char> sign = new Stack<char>();
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    float num = 0;
                    while (Char.IsDigit(str[i]))
                    {
                        num = num * 10 + (str[i] - '0');
                        i++;
                        if (i >= str.Length) break;
                    }
                    nums.Push(num);
                    i--;
                }
                else if(checkChar(str[i]) != -1 && sign.Count == 0)
                {
                    sign.Push(str[i]);
                }
                else if (checkChar(str[i]) != -1)
                {
                    while (sign.Count > 0 && checkChar(str[i]) <= checkChar(sign.Peek()))
                    {
                        float result = calculate(nums, sign);
                        nums.Push(result);
                    }
                    sign.Push(str[i]);
                }
                else if (str[i] == '(') sign.Push(str[i]);
                else if(str[i] == ')')
                {
                    while (sign.Peek() != '(')
                    {
                        float result = calculate(nums, sign);
                        nums.Push(result);
                    }
                    sign.Pop();
                }
            }
            int j = 0;
            while (sign.Count > 0) 
            {
                float result = calculate(nums, sign);
                nums.Push(result);
                j++;

            }
            return nums.Peek();
        }
        private int checkChar(char c)
        {
            switch (c)
            {
                case '+':
                    {
                        return 1;
                    }
                case '-':
                    {
                        return 1;
                    }

                case '*':
                    {
                        return 2;
                    }
                case '/':
                    {
                        return 2;
                    }
            }
            return -1;
        }
        private float calculate(Stack<float> nums, Stack<char> sign)
        {
            float a = nums.Pop();
            float b = nums.Pop();
            char c = sign.Pop();
            switch (c)
            {
                case '+':
                    {
                        return a + b;
                    }
                case '-':
                    {
                        return b - a;
                    }
                case '*':
                    {
                        return a * b;
                    }
                case '/':
                    {
                        if (a == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return 0;
                        }
                        return b / a;
                    }
            }
            return 0;
        }
    }
}
