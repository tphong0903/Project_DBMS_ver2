
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
using BusinessAccessLayer;

namespace Project_ver1
{
    public partial class SanPhamUi : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        public SanPhamUi()
        {
            InitializeComponent();
            dbsp = new DBSanPham();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadData()
        {
            try
            {

                dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.LayThanhPho().Tables[0];
                // Đưa dữ liệu lên DataGridView  
                dgvSanPham.DataSource = dtSanPham;
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
        }
    }
}
