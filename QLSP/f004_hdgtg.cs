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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QLSP
{
    public partial class f004_hdgtg : Form
    {
        public f004_hdgtg()
        {
            InitializeComponent();
        }

        public void dt_DataSource(Name_product<Product> ip_us_result)
        {
            m_dg_banggia.DataSource = ip_us_result.product;
            
                for(int j =0; j < 9; j++)
                {    
                    if (m_dg_banggia.Rows[1].Cells[j].Value==null)
                    {                     
                        m_dg_banggia.Columns[j].Visible = false;              
                    }
                }  
        }
        public void display(string ip_str_hoten, string ip_str_donvi,string ip_str_diachi , string ip_str_taikhoan , string ip_str_thanhtoan , string ip_str_masothue,double ip_db_tongtien,string ip_str_menhgia)
        {
            DateTime us_UTCNow = DateTime.UtcNow;
            int v_i_year = us_UTCNow.Year;
            int v_i_month = us_UTCNow.Month;
            int v_i_day = us_UTCNow.Day;
            string v_str_json;
            m_lbl_ngay.Text = v_i_day.ToString();
            m_lbl_thang.Text = v_i_month.ToString();
            m_lbl_nam.Text = v_i_year.ToString();
            m_lbl_tenkh.Text = ip_str_hoten;
            m_lbl_tendv.Text = ip_str_donvi;
            m_lbl_tendc.Text = ip_str_diachi;
            m_lbl_sotk.Text = ip_str_taikhoan;
            m_lbl_thanhtoan.Text = ip_str_thanhtoan;
            m_lbl_masothue.Text = ip_str_masothue;
            m_lbl_congtienhang.Text = ip_db_tongtien.ToString()+" "+ ip_str_menhgia;
            m_lbl_thuegtgt.Text = ((ip_db_tongtien * 10) / 100).ToString() + " " + ip_str_menhgia;
            m_lbl_tongtien.Text = (ip_db_tongtien + (ip_db_tongtien * 10) / 100).ToString() + " " + ip_str_menhgia;
        }
       
    }
    

}
