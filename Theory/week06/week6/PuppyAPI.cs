using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6
{
    public partial class PuppyAPI : Form
    {
        public PuppyAPI()
        {
            InitializeComponent();
        }

        private async void GetDogImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    // Gửi yêu cầu GET lên API
                    HttpResponseMessage response = await httpClient.GetAsync("https://dog.ceo/api/breeds/image/random");

                    // Kiểm tra kết quả trả về từ API
                    if (response.IsSuccessStatusCode)
                    {
                        // Đọc dữ liệu JSON từ response
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                        // Lấy URL hình ảnh từ dữ liệu JSON
                        string imageUrl = data.message;

                        // Gửi yêu cầu GET để tải hình ảnh chó về
                        HttpResponseMessage imageResponse = await httpClient.GetAsync(imageUrl);

                        if (imageResponse.IsSuccessStatusCode)
                        {
                            byte[] imageData = await imageResponse.Content.ReadAsByteArrayAsync();
                            using (var stream = new System.IO.MemoryStream(imageData))
                            {
                                MyDogImage.Image = Image.FromStream(stream);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể tải hình ảnh chó từ API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy dữ liệu từ API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
