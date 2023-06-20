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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Text = "Delete record of a student";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            SqlParameter idTxt = new SqlParameter("@idTxt", SqlDbType.Int);
            idTxt.Value = textBox1.Text;
            SqlCommand del = new SqlCommand("DELETE FROM Student WHERE Id = @idTxt",Form1.cnn);
            del.Parameters.Add(idTxt);
            try
            {
                del.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
        }
    }
}
