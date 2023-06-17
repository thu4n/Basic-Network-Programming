using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        bool is_Upper = false;
        private void Encrypt_Click(object sender, EventArgs e)
        {
            Encrypted.Clear();
            for (int i = 0; i < Input.Text.Length; i++)
            {
                char letter = Input.Text[i];
                // kiểm tra từng kí tự xem nó có phải là chữ không, nếu không thì sẽ không mã hóa nó
                if (char.IsLetter(letter) == false)
                {
                    Encrypted.Text += letter;
                    continue;
                }

                if (char.IsUpper(letter))
                    is_Upper = true;
                // Lấy chữ cái tương ứng với vị trí dịch mã. Nếu như vị trí của Mã Rõ lớn hơn Key thì sẽ quay lại từ đầu
                char KeyLetter = Key.Text[i % (Key.Text.Length)];
                MessageBox.Show(Key.Text.Length.ToString());
                int index = Array.IndexOf(alphabet, char.ToLower(letter));
                int KeyIndex = Array.IndexOf(alphabet, char.ToLower(KeyLetter));
                MessageBox.Show(KeyIndex.ToString());
                int newIndex = (KeyIndex + index) % 26;
                MessageBox.Show(newIndex.ToString());
                if (is_Upper)
                    {
                        Encrypted.Text += Char.ToUpper(alphabet[newIndex]);
                        is_Upper = false;
                   }
                else
                Encrypted.Text += alphabet[newIndex];
            }
        }
    }
}
