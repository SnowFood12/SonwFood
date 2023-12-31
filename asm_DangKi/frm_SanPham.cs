﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm_DangKi
{
    public partial class frm_SanPham : Form
    {
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // chuỗi kết nói SQL 
        SqlConnection conn = null;  // khai báo biến kết nói 

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            sp_load();
           
        }
        private void sp_load()
        {
            try
            {
                conn = new SqlConnection(str); // khởi tại biến kết nối SQL 
                conn.Open(); // mở đường dẫn SQL 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex); // bẫy lỗi 
            }
            // khai báo chuỗi câu lệnh thêm giá trị vào SQL 
            string selectQuery = "select * from SanPham";
            SqlCommand cmd = new SqlCommand(selectQuery, conn); // khởi tạo biến SqlCommand 
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(
                    new string[] { rdr["MaSanPham"].ToString(), rdr["TenSanPham"].ToString(), rdr["SoLuong"].ToString(), rdr["GiaBan"].ToString(), rdr["NgayNhapKho"].ToString(), rdr["NgaySanXuat"].ToString(), rdr["HanSuDung"].ToString(), rdr["TinhTrang"].ToString(), rdr["GhiChu"].ToString(), }
                );
                lstv_sanPham.Items.Add(item);
            }
            List<string> list = new List<string>()
            {
                "Tất cả",
                "Còn tốt",
                "Sắp hết hạn",
                "Hết hạn"
            };
            foreach (string s in list)
            {
                cbo_tinhTrang.Items.Add(s);
            }
            cbo_tinhTrang.Text = "Tất cả";
            List<string> giaMin = new List<string>()
            {
                "10000",
                "20000",
                "30000",
                "40000",
                "50000",
                "60000",
                "70000",
                "80000"
            };
            List<string> giaMax = new List<string>()
            {
                "10000",
                "20000",
                "30000",
                "40000",
                "50000",
                "60000",
                "70000",
                "80000"
            };
            foreach (string i in giaMin)
            {
                cbo_giaMin.Items.Add(i);
            }
            foreach (string i in giaMax)
            {
                cbo_giaMax.Items.Add(i);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str); // khởi tại biến kết nối SQL 
                conn.Open(); // mở đường dẫn SQL 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex); // bẫy lỗi 
            }
            if(cbo_tinhTrang.Text != "Tất cả")
            {
                string selectQuery = $@"select * from SanPham where TinhTrang = @tinhTrang";
                SqlCommand cmd = new SqlCommand(selectQuery, conn); // khởi tạo biến SqlCommand 
                cmd.Parameters.AddWithValue("@tinhTrang", cbo_tinhTrang.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                lstv_sanPham.Items.Clear();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(
                        new string[] { rdr["MaSanPham"].ToString(), rdr["TenSanPham"].ToString(), rdr["SoLuong"].ToString(), rdr["GiaBan"].ToString(), rdr["NgayNhapKho"].ToString(), rdr["NgaySanXuat"].ToString(), rdr["HanSuDung"].ToString(), rdr["TinhTrang"].ToString(), rdr["GhiChu"].ToString(), }
                    );
                    lstv_sanPham.Items.Add(item);
                }
            }
            if (cbo_giaMin.SelectedItem != null && cbo_giaMax.SelectedItem != null)
            {
                string selectQuery = $@"select * from SanPham where GiaBan between @GiaMin and @GiaMax";
                SqlCommand cmd = new SqlCommand(selectQuery, conn); // khởi tạo biến SqlCommand 
                cmd.Parameters.AddWithValue("@GiaMin", cbo_giaMin.Text);
                cmd.Parameters.AddWithValue("@GiaMax", cbo_giaMax.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                lstv_sanPham.Items.Clear();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(
                        new string[] { rdr["MaSanPham"].ToString(), rdr["TenSanPham"].ToString(), rdr["SoLuong"].ToString(), rdr["GiaBan"].ToString(), rdr["NgayNhapKho"].ToString(), rdr["NgaySanXuat"].ToString(), rdr["HanSuDung"].ToString(), rdr["TinhTrang"].ToString(), rdr["GhiChu"].ToString(), }
                    );
                    lstv_sanPham.Items.Add(item);
                }
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbo_tinhTrang.Items.Clear();
            cbo_giaMin.Items.Clear();
            cbo_giaMax.Items.Clear();
            lstv_sanPham.Items.Clear();
            sp_load();
        }
    }
}
