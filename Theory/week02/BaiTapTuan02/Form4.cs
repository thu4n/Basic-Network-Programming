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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Text = "Update record of a student";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlParameter idTxt = new SqlParameter("@idTxt", SqlDbType.Int);
            idTxt.Value = searchBox.Text;
            SqlCommand select = new SqlCommand("SELECT * FROM Student WHERE Id = @idTxt", Form1.cnn);
            select.Parameters.Add(idTxt);
            select.CommandType = CommandType.Text;
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(select))
                {
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds, "Student");
                        textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                        textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
                        textBox3.Text = ds.Tables[0].Rows[0][3].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SqlParameter idTxt = new SqlParameter("@idTxt", SqlDbType.Int);
            idTxt.Value = searchBox.Text;
            SqlParameter nameTxt = new SqlParameter("@nameTxt", SqlDbType.NVarChar,50);
            nameTxt.Value = textBox1.Text;
            SqlParameter birthTxt = new SqlParameter("@birthTxt", SqlDbType.Date);
            birthTxt.Value = textBox2.Text;
            SqlParameter addressTxt = new SqlParameter("@addressTxt", SqlDbType.NVarChar,50);
            addressTxt.Value = textBox3.Text;
            SqlCommand update = new SqlCommand("UPDATE Student SET Name = @nameTxt, Birth = @birthTxt, Address = @addressTxt WHERE Id = @idTxt", Form1.cnn);
            update.Parameters.Add(idTxt);
            update.Parameters.Add(nameTxt);
            update.Parameters.Add(birthTxt);
            update.Parameters.Add(addressTxt);
            try
            {
                update.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
