using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Lab04
{
    public partial class Bai5 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Bai5()
        {
            InitializeComponent();
        }

        private async void postBtn_Click(object sender, EventArgs e)
        {
            string email = usernameTB.Text;
            string password = passwordTB.Text;
            var values = new Dictionary<string, string>
            {
                { "email", email },
                { "password", password }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://reqres.in/api/register", content);
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString); // Chuyển string nhận được thành Json Object
            json.TryGetValue("token", out var token); // Lấy thông tin từ trường token của Json Object
            resultTB.Text = token.ToString();
        }
    }
}
