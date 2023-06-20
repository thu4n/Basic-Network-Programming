using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BaiTapTuan02
{
    public partial class Form1 : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementConnectionString"].ConnectionString;
        public static SqlConnection cnn;
        public Form1()
        {
            InitializeComponent();
            AutoScaleDimensions = new SizeF(6F, 13F); // for design in 96 DPI
            Text = "Student Management System of Steam university";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            button4.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            updateBtn.Visible = true;
            showBtn.Visible = true;
            awaitTxt.Text = "You are connected to the Student Management database.";
            int X = Width / 2 - awaitTxt.Width / 2;
            awaitTxt.Location = new Point(X, awaitTxt.Location.Y);
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            SqlCommand select = new SqlCommand("SELECT * FROM Student", cnn);
            select.CommandType = CommandType.Text;
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(select))
                {
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds, "Student");
                        dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
                        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Visible = true;
                        awaitTxt.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
        }

        private void awaitTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
