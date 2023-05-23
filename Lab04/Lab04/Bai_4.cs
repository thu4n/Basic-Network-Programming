using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }
        
        public class page_detail
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<Data> data { get; set; }
        }
        public class Data
        {
            public int id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string avatar { get; set; }
        }
        private string getHTML(string szURL)
        {

            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
        public void page1()
        {
            ProgressBar.Value = 1;
            flowLayoutPanel1.Controls.Clear();
            page_detail page_Detail = JsonConvert.DeserializeObject<page_detail>(getHTML("https://reqres.in/api/users?page=1"));
            UserForm[] userForms = new UserForm[6];
            ProgressBar.Minimum = 1;
            ProgressBar.Maximum = userForms.Length;
            ProgressBar.Step = 1;
            Page.Text = "Page : " + page_Detail.page.ToString();
            UserPpage.Text = "User/page : " + page_Detail.per_page.ToString();
            TotalUser.Text = "Total user : " + page_Detail.total.ToString();
            TotalPage.Text = "Total page : " + page_Detail.total_pages.ToString();
            for (int i = 0; i < userForms.Length; i++)
            {
                userForms[i] = new UserForm();
                userForms[i].fullname = page_Detail.data[i].first_name + " " + page_Detail.data[i].last_name;
                userForms[i].email = page_Detail.data[i].email;
                var request = WebRequest.Create(page_Detail.data[i].avatar);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    userForms[i].Avatar = Bitmap.FromStream(stream);
                }
                if (userForms[i].Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else
                    flowLayoutPanel1.Controls.Add(userForms[i]);
                ProgressBar.PerformStep();
            }
        }
        public void page2()
        {
            ProgressBar.Value = 1;
            flowLayoutPanel1.Controls.Clear();
            page_detail page_Detail = JsonConvert.DeserializeObject<page_detail>(getHTML("https://reqres.in/api/users?page=2"));
            UserForm[] userForms = new UserForm[6];
            Page.Text = "Page : " + page_Detail.page.ToString();
            UserPpage.Text = "User/page : " + page_Detail.per_page.ToString();
            TotalUser.Text = "Total user : " + page_Detail.total.ToString();
            TotalPage.Text = "Total page : " + page_Detail.total_pages.ToString();
            for (int i = 0; i < userForms.Length; i++)
            {
                userForms[i] = new UserForm();
                userForms[i].fullname = page_Detail.data[i].first_name + " " + page_Detail.data[i].last_name;
                userForms[i].email = page_Detail.data[i].email;
                var request = WebRequest.Create(page_Detail.data[i].avatar);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    userForms[i].Avatar = Bitmap.FromStream(stream);
                }
                if (userForms[i].Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else
                    flowLayoutPanel1.Controls.Add(userForms[i]);
                ProgressBar.PerformStep();
            }
        }


        private void Bài_4_Load(object sender, EventArgs e)
        {
            
            page1();
            Previous.Enabled = false;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            page2();
            Previous.Enabled = true;
            Forward.Enabled = false;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            page1();
            Previous.Enabled = false;
            Forward.Enabled = true;
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
