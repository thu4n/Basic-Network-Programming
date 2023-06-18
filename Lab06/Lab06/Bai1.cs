using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        bool is_Upper = false;
        private void Encrypt_Click(object sender, EventArgs e)
        {
            Encrypted.Clear();
            for (int i = 0; i < Input.Text.Length; i++)
            {
                char letter = Input.Text[i];
                if (char.IsLetter(letter) == false)
                {
                    Encrypted.Text += letter;
                    continue;

                }
                
                    if (char.IsUpper(letter))
                        is_Upper = true;
                             
                        int index = Array.IndexOf(alphabet, char.ToLower(letter));
                        int newIndex = (Int32.Parse(Shift.Text) + index) % 26;
                        if (is_Upper)
                        {
                            Encrypted.Text += Char.ToUpper(alphabet[newIndex ]);
                            is_Upper = false;
                        }
                        else
                            Encrypted.Text += alphabet[newIndex];
                
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            Decrypted.Clear();
            for (int i = 0; i < Encrypted.Text.Length; i++)
            {
               
                char letter = Encrypted.Text[i];
                if (char.IsLetter(letter) == false)
                {
                    Decrypted.Text += letter;
                    continue;

                }
                if (char.IsUpper(letter))
                    is_Upper = true;
               
               
                    int index = Array.IndexOf(alphabet, char.ToLower(letter));
                    int newIndex = Math.Abs((index - Int32.Parse(Shift.Text) +26)) % 26;
                    if (is_Upper)
                    {
                        Decrypted.Text += Char.ToUpper(alphabet[newIndex ]);
                        is_Upper = false;
                    }
                    else
                    Decrypted.Text += alphabet[newIndex];
                
            }
        }

        private void Encrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypted_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
