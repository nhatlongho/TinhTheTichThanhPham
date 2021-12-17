using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using TinhTheTichThanhPham.Entity;

namespace TinhTheTichThanhPham
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        class IT_VBEL_RETURN
        {
            public List<IT_VBEL> VBEL_RETURN { get; set; }
        }
        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            string baseURL = @"http://192.1.1.3:3561/bitis/getdetailoutbound?outBound=8723931668";

            client.BaseAddress = new Uri(baseURL);
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("ApiKey", "NQXVNBsWjJOoa4@Ognbbd623H");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent dataLogin = new StringContent("", System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync(baseURL, dataLogin).Result;
            string jsonResponse = await response.Content.ReadAsStringAsync();
            IT_VBEL_RETURN listtt = JsonConvert.DeserializeObject<IT_VBEL_RETURN>(jsonResponse);
        }
    }
}
