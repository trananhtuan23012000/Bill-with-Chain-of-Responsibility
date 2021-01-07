using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace QLSP
{
    public partial class f001_thanh_toan : Form
    {
        public f001_thanh_toan()
        {
            InitializeComponent();
        }
        int m_i_request;
        
        private void button1_Click(object sender, EventArgs e)
        {                   
            Chandler_101 us_h1 = new Chdt_102();
            Chandler_101 us_h2 = new Chdgtgt_103();
            
            us_h1.SetSuccessor(us_h2);
            if (m_rdb_hdt.Checked)
            {
                m_i_request = 0;
            }
            else if (m_rdb_hdgtgt.Checked)
            {
                m_i_request = 1;
            }
            us_h1.HandleRequest(m_i_request);
            
            
        }
    }
    abstract class Chandler_101

    {
        protected Chandler_101 successor;

        public void SetSuccessor(Chandler_101 successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int ip_i_request);
    }
    class Chdt_102 : Chandler_101
    {
        string m_str_json_product = @"C:\Users\Tuan\source\repos\QLSP\QLSP\Data\sanpham.json";
        public override void HandleRequest(int ip_i_request)
        {
            if (ip_i_request ==0)
            {
                var us_type = new List<string> { };

                using (StreamReader file = File.OpenText(m_str_json_product))
                {
                    JsonSerializer serializer = new JsonSerializer();

                    Name_currency<Currency> us_currency = (Name_currency<Currency>)serializer.Deserialize(file, typeof(Name_currency<Currency>));

                    foreach (var menh_gia in us_currency.currency)
                    {
                        us_type.Add(menh_gia.Type);
                    }
                }
                f003_info_hdt us_hoadonThuong = new f003_info_hdt();
                us_hoadonThuong.display_Combobox(us_type);
                us_hoadonThuong.Show();
            }
            else if (successor != null)
            {
                successor.HandleRequest(ip_i_request);
            }
        }
    }
    class Chdgtgt_103 : Chandler_101
    {
        string m_str_json_product = @"C:\Users\Tuan\source\repos\QLSP\QLSP\Data\sanpham.json";
        public override void HandleRequest(int ip_i_request)
        {
            if (ip_i_request ==1)
            {
                var us_type = new List<string> {};
                
            using (StreamReader file = File.OpenText(m_str_json_product))
            {
                JsonSerializer serializer = new JsonSerializer();
                
                Name_currency<Currency> us_currency = (Name_currency<Currency>)serializer.Deserialize(file, typeof(Name_currency<Currency>));
                
                foreach (var menh_gia in us_currency.currency)
                {
                    us_type.Add(menh_gia.Type);
                }
            }
                f002_info_hdgtgt us_hoadonGTGT = new f002_info_hdgtgt();
                us_hoadonGTGT.display_Combobox(us_type);
                us_hoadonGTGT.Show();
            }
            else if (successor != null)
            {
                successor.HandleRequest(ip_i_request);
            }
        }
    }
}
