using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "Add a new student";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlParameter nameTxt = new SqlParameter("@nameTxt", SqlDbType.NVarChar, 50);
            SqlParameter birthTxt = new SqlParameter("@birthTxt", SqlDbType.Date);
            SqlParameter addressTxt = new SqlParameter("@addressTxt", SqlDbType.NVarChar, 50);
            nameTxt.Value = textBox1.Text;
            birthTxt.Value = textBox2.Text;
            addressTxt.Value = textBox3.Text;
            string sqlInsert = "INSERT INTO Student (Name,Birth,Address) VALUES (@nameTxt,@birthTxt,@addressTxt)";
            SqlCommand insertion = new SqlCommand(sqlInsert, Form1.cnn);
            insertion.Parameters.Add(nameTxt);
            insertion.Parameters.Add(birthTxt);
            insertion.Parameters.Add(addressTxt);
            try { 
                insertion.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to the database is not initialized. Go back and click on 'Connect' first.", "Connection Error");
                Close();
            }

        }
    }
}
