
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
using Project_ver1.UI;

namespace Project_ver1
{
    public partial class SanPhamUi : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        string Product_ID = null;
        public SanPhamUi()
        {
            InitializeComponent();
            dbsp = new DBSanPham();
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

                DataTable dtDM = new DataTable();
                dtDM.Clear();
                dtDM = dbsp.LayDanhMuc().Tables[0];
                dtDM.Rows.InsertAt(dtDM.NewRow(), 0);
                DMCombox.DataSource = dtDM;
                DMCombox.DisplayMember = "CategoryName";

                DataTable dtTT = new DataTable();
                dtTT.Clear();
                dtTT = dbsp.LayThuongHieu().Tables[0];
                dtTT.Rows.InsertAt(dtTT.NewRow(), 0);
                THCombox.DataSource = dtTT;
                THCombox.DisplayMember = "BrandName";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void SanPhamUi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.sanpham' table. You can move, or remove it, as needed.
            LoadData();

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string DMName = DMCombox.Text;
            string THName = THCombox.Text;
            string Name = NameText.Text;
            
            string err = "";
            try
            {
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.TimSanPham(THName,DMName,Name).Tables[0];
                dgvSanPham.DataSource = dtSanPham;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void SanPhamUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtSanPham.Dispose();
            dtSanPham = null;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm(0,Product_ID);
            detailForm.ShowDialog();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            Product_ID = dgvSanPham.Rows[r].Cells[0].Value.ToString();
        }
    }
}
