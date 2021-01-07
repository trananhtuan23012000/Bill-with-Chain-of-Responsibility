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
    public partial class f003_info_hdt : Form
    {
        public f003_info_hdt()
        {
            InitializeComponent();
            m_img_label.Visible = false;
        }
        string m_str_json_bill = @"C:\Users\Tuan\source\repos\QLSP\QLSP\Data\hoadonThuong.json";
        string m_str_json_product = @"C:\Users\Tuan\source\repos\QLSP\QLSP\Data\sanpham.json";
        public void display_Combobox(List<string> ip_us_type)
        {
            foreach (var menh_gia in ip_us_type)
            {
                m_cbo_menhgia.Items.Add(menh_gia);
            }

        }
        private void add_Click(object sender, EventArgs e)
        {
            if (m_txt_tenkh.Text == "" ||  m_txt_tendc.Text == "" || m_txt_sotk.Text == "" || m_cbo_thanhtoan.SelectedItem == null ||  m_cbo_menhgia.SelectedItem == null)
            {
                MessageBox.Show("Các mục (*) không được để trống !");
            }
            else
            {
                string v_str_json;
                DateTime us_UTCNow = DateTime.UtcNow;
                int v_i_year = us_UTCNow.Year;
                int v_i_month = us_UTCNow.Month;
                int v_i_day = us_UTCNow.Day;
                m_lbl_notice1.Text = "Click vào đây để xem hóa đơn";
                m_img_label.Visible = true;

                JsonSerializer serializer = new JsonSerializer();
                Info_bill_add<Bill_Thuong> us_bill_add = JsonConvert.DeserializeObject<Info_bill_add<Bill_Thuong>>(File.ReadAllText(m_str_json_bill));
                us_bill_add.bill.Add(new Bill_Thuong()
                {
                    Date = v_i_day.ToString() + "/" + v_i_month.ToString() + "/" + v_i_year.ToString(),
                    Name = m_txt_tenkh.Text,
                    Address = m_txt_tendc.Text,
                    Account = m_txt_sotk.Text,
                    Pay = m_cbo_thanhtoan.SelectedItem.ToString(),
                    Currency = m_cbo_menhgia.SelectedItem.ToString()
                });
                v_str_json = JsonConvert.SerializeObject(us_bill_add, Formatting.Indented);
                System.IO.File.WriteAllText(m_str_json_bill, v_str_json);
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            m_img_label.Visible = false;
            m_lbl_notice1.Text = null;
            Double v_db_tong_tien = 0;
            f005_hdt us_hdt = new f005_hdt();

            JsonSerializer serializer = new JsonSerializer();
            Name_product<Product> us_product = JsonConvert.DeserializeObject<Name_product<Product>>(File.ReadAllText(m_str_json_product));
            us_hdt.dt_DataSource(us_product);
            foreach (var tien in us_product.product)
            {
                if (m_cbo_menhgia.SelectedItem.ToString() == "VND") v_db_tong_tien += float.Parse(tien.VND);
                else if (m_cbo_menhgia.SelectedItem.ToString() == "USD") v_db_tong_tien += float.Parse(tien.USD);
                else if (m_cbo_menhgia.SelectedItem.ToString() == "EURO") v_db_tong_tien += float.Parse(tien.EURO);
                else if (m_cbo_menhgia.SelectedItem.ToString() == "RMB") v_db_tong_tien += float.Parse(tien.RMB);
                else if (m_cbo_menhgia.SelectedItem.ToString() == "WON") v_db_tong_tien += float.Parse(tien.WON);
            }
            us_hdt.display(m_txt_tenkh.Text, m_txt_tendc.Text, m_txt_sotk.Text, m_cbo_thanhtoan.SelectedItem.ToString(), v_db_tong_tien, m_cbo_menhgia.SelectedItem.ToString());
            us_hdt.Show();
        }

        private void repair_Click(object sender, EventArgs e)
        {
            if (m_txt_name_repair.Text != "")
            {
                m_lbl_notice2.Text = null;
                string v_str_json;
                string v_str_date;
                string v_str_currency;
                m_txt_tenkh.Text = null;
                m_txt_tendc.Text = null;
                m_txt_sotk.Text = null;
                JsonSerializer serializer = new JsonSerializer();
                Info_bill_repair<Bill_Thuong> us_bill_repair = JsonConvert.DeserializeObject<Info_bill_repair<Bill_Thuong>>(File.ReadAllText(m_str_json_bill));
                Info_bill_add<Bill_Thuong> us_bill_add = JsonConvert.DeserializeObject<Info_bill_add<Bill_Thuong>>(File.ReadAllText(m_str_json_bill));
                if (us_bill_repair.bill.Length != 0)
                {
                    foreach (var name_kh in us_bill_repair.bill)
                    {
                        if (name_kh.Name == m_txt_name_repair.Text)
                        {
                            m_txt_tenkh.Text = name_kh.Name;
                            m_txt_tendc.Text = name_kh.Address;
                            m_txt_sotk.Text = name_kh.Account;
                            v_str_date = name_kh.Date;
                            v_str_currency = name_kh.Currency;
                        }
                    }
                    for (int i = 0; i < us_bill_add.bill.Count; i++)
                    {
                        if (us_bill_add.bill[i].Name == m_txt_name_repair.Text)
                        {
                            us_bill_add.bill.RemoveAt(i);
                        }
                    }
                    v_str_json = JsonConvert.SerializeObject(us_bill_add, Formatting.Indented);
                    System.IO.File.WriteAllText(m_str_json_bill, v_str_json);
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống !");
                }
            }
            else
            {
                m_lbl_notice2.Text = "Điền đầy đủ họ và tên vào ô trống !";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (m_txt_name_delete.Text != "")
            {
                m_lbl_notice3.Text = null;
                string v_str_json;
                string v_str_date;
                string v_str_currency;
                m_txt_tenkh.Text = null;
                m_txt_tendc.Text = null;
                m_txt_sotk.Text = null;
                JsonSerializer serializer = new JsonSerializer();
                Info_bill_add<Bill_Thuong> us_bill_add = JsonConvert.DeserializeObject<Info_bill_add<Bill_Thuong>>(File.ReadAllText(m_str_json_bill));
                if (us_bill_add.bill.Count != 0)
                {
                    for (int i = 0; i < us_bill_add.bill.Count; i++)
                    {
                        if (us_bill_add.bill[i].Name == m_txt_name_delete.Text)
                        {
                            us_bill_add.bill.RemoveAt(i);
                        }
                    }

                    v_str_json = JsonConvert.SerializeObject(us_bill_add, Formatting.Indented);
                    System.IO.File.WriteAllText(m_str_json_bill, v_str_json);
                    MessageBox.Show("Xóa Thành Công !");
                }
                else
                {
                    MessageBox.Show("Dữ liệu trống !");
                }
            }
            else
            {
                m_lbl_notice3.Text = "Điền đầy đủ họ và tên vào ô trống !";
            }
        }
    }
    }


