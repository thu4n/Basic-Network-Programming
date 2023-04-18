using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net.Http.Handlers;

namespace week6
{
    public partial class TodosAPI : Form
    {
        private readonly string api = "https://jsonplaceholder.typicode.com/todos";
        public class ListItem
        {
            public int userId {  get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
        }
        public TodosAPI()
        {
            InitializeComponent();
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            GetTodoList();
        }
        private async void GetTodoList()
        {
            List<ListItem> list;
            HttpClient client = new HttpClient();
            infoLabel.Text = "Đang lấy dữ liệu...";
            HttpResponseMessage response = await client.GetAsync(api);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var res = await response.Content.ReadAsStringAsync();
                list = JsonSerializer.Deserialize<List<ListItem>>(res);
                infoLabel.Visible = false;
                DisplayList(list);
            }
        }
        private void DisplayList(List<ListItem> list)
        {
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
