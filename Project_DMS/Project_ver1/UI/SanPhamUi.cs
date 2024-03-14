
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
    public partial class SanPhamUi : Form
    {
        string strConnectionString = "Data Source= MSI\\CSDL;Initial " +
       "Catalog=Test;Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daSanPham = null;
        DataTable dtSanPham = null;
        public SanPhamUi()
        {
            InitializeComponent();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                conn.Open();

                daSanPham = new SqlDataAdapter("SELECT * FROM sanpham", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);
                // Đưa dữ liệu lên DataGridView
                dgvSanPham.DataSource = dtSanPham;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }
        private void SanPhamUi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.sanpham' table. You can move, or remove it, as needed.
            LoadData();

        }

        private void FindButton_Click(object sender, EventArgs e)
        {

        }

        private void SanPhamUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtSanPham.Dispose();
            dtSanPham = null;
            conn = null;
        }
    }
}
