using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_ver1
{
    public partial class KhachHangUI : Form
    {
        string strConnectionString = "Data Source= MSI\\CSDL;Initial " +
       "Catalog=Test;Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang= null;
        public KhachHangUI()
        {

            InitializeComponent();
        }
        private void KhachHangUI_Load(object sender, EventArgs e)
        {
  
            LoadData();

        }
        public void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                conn.Open();

                daKhachHang = new SqlDataAdapter("SELECT * FROM khachhang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                // Đưa dữ liệu lên DataGridView
                dgvSanPham.DataSource = dtKhachHang;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }

        private void KhachHangUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachHang.Dispose();
            dtKhachHang = null;
            conn = null;
        }


    }
}
