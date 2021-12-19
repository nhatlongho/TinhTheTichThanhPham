using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinhTheTichThanhPham.Entity;

namespace TinhTheTichThanhPham
{
    public partial class frm_TinhTheTich : DevExpress.XtraEditors.XtraForm
    {
        public frm_TinhTheTich()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        string _BaseUrl = @"http://192.1.1.3:3561/bitis/getdetailoutbound?outBound=";
        const string APIKey = "NQXVNBsWjJOoa4@Ognbbd623H";

        private List<IT_VBEL> _IT_VBEL = new List<IT_VBEL>();
        class IT_VBEL_RETURN
        {
            public List<IT_VBEL> VBEL_RETURN { get; set; }
        }
        private void txtOutBound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //Xử lý dữ liệu đầu vào.
                string outbound = txtOutBound.Text.Trim();
                if(string.IsNullOrEmpty(outbound))
                {
                    MessageBox.Show("Vui lòng nhập số outbound cần tính thể tích", "Thông báo");
                    return;
                }
                //Lấy dữ liệu từ api
                foreach (string item in outbound.Split(';'))
                {
                    _IT_VBEL.AddRange(GetDataFromAPI(item).Result.VBEL_RETURN);
                }
                gridDataRaw.RefreshDataSource();
            }
        }

        private async  Task<IT_VBEL_RETURN> GetDataFromAPI(string outbound)
        {
            IT_VBEL_RETURN result = new IT_VBEL_RETURN();
            StringContent dataContent = new StringContent("", System.Text.Encoding.UTF8, "application/json");
            var reponse = client.PostAsync(_BaseUrl + outbound, dataContent).Result;
            string jsonReponse = await reponse.Content.ReadAsStringAsync();
            result = JsonConvert.DeserializeObject<IT_VBEL_RETURN>(jsonReponse);
            return result;
        }

        private void frm_TinhTheTich_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("ApiKey", APIKey);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            gridDataRaw.DataSource = _IT_VBEL;
        }
    }
}