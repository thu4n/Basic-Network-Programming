using System;
using System.Linq;
using System.Collections.Generic;


namespace BaiTapTuan01
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static int NbDig(int n, int d)
        // Count the Digit
        {
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                int temp = i * i;
                if (d == 0 && temp == 0) count++;
                while (temp != 0)
                {
                    int temp2 = temp % 10;
                    if (temp2 == d) count++;
                    temp /= 10;
                }
            }
            return count;
        }
        public static char[][] ChessBoard(int row, int columns)
        // draw me a chessboard
        {
            char[][] chessboard = new char[row][];
            for (int i = 0; i < row; i++)
            {
                chessboard[i] = new char[columns];
                if (i % 2 == 0) chessboard[i][0] = 'O';
                else chessboard[i][0] = 'X';
                for (int j = 1; j < columns; j++)
                {
                    if (chessboard[i][j - 1] == 'O') chessboard[i][j] = 'X';
                    else chessboard[i][j] = 'O';
                }
            }
            return chessboard;
        }
        public static string Disemvowel(string str)
        // Disemvowel Trolls
        {
            char[] vowels = { 'a', 'o', 'e', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            foreach (char c in vowels)
            {
                str = str.Replace(c.ToString(), String.Empty);
            }
            return str;
        }
        public static string Capitalize(string s, List<int> idxs)
        // Indexed capitalization
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(s);
            foreach (int i in idxs)
            {
                if (i < s.Length && i >= 0) sb[i] = char.ToUpper(sb[i]);
            }
            s = sb.ToString();
            return s;
        }
        public static string Solve(string s)
        // Fix string case
        {
            int count = 0;
            foreach (char c in s)
            {
                if (char.IsUpper(c)) count++;
                else count--;
            }
            if (count > 0) return s.ToUpper();
            return s.ToLower();
        }
        public static string AddBinary(int a, int b)
        // Binary Addition
        {
            return Convert.ToString(a + b, 2);
        }
        public static int[] TwoSum(int[] numbers, int target)
        // Two Sum
        {
            Dictionary<int, int> result = new();
            for (int i = 0; i < numbers.Length; i++)
            {
                int t1 = numbers[i];
                int t2 = target - t1;
                if (result.TryGetValue(t2, out int j))
                {
                    return new[] { j, i };
                }
                result[t1] = i;
            }
            return Array.Empty<int>();
        }
        public static int Hanoi(int disks)
        // Hanoi record
        {
            return (int)Math.Pow(2.00, (double)disks) - 1;
        }
        public static string Nerdify(string str)
        // Ch4113ng3
        {
            if (str == null) throw new ArgumentNullException("string is null");
            return str.Replace("a", "4").Replace("e", "3").Replace("E", "3").Replace("A", "4").Replace("l", "1");
        }
        public static string BandNameGenerator(string str)
        // Band name generator
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(str);
            sb[0] = char.ToUpper(sb[0]);
            if (str[0] == str[str.Length - 1])
            {
                str = sb.ToString() + str.Substring(1);
            }
            else
            {
                str = "The " + sb.ToString();
            }
            return str;
        }
    }
}