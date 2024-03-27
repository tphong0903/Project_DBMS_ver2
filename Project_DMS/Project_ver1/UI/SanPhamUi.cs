
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
using System.Timers;

namespace Project_ver1
{
    public partial class SanPhamUi : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        string Product_ID = null;
        DetailForm detailForm = null;
        string DMName =null;
        string THName = null;
        string Name = null ;
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
               // DMCombox.DataSource = dtDM;
               // DMCombox.DisplayMember = "CategoryName";

                DataTable dtTT = new DataTable();
                dtTT.Clear();
                dtTT = dbsp.LayThuongHieu().Tables[0];
                dtTT.Rows.InsertAt(dtTT.NewRow(), 0);
                THCombox.DataSource = dtTT;
                THCombox.DisplayMember = "BrandName";

                Product_ID = dgvSanPham.Rows[0].Cells[0].Value.ToString();
                SLSP.Text = (dgvSanPham.RowCount - 1).ToString();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void SanPhamUi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ButtonDM_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;

            if (clickedButton != null)
            {
                DMName= clickedButton.Text;
                FindButton_Click(sender, e);
                DMName = null;
            }
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                THName = THCombox.Text;
                Name = NameText.Text;
                DataTable dtSanPham = dbsp.TimSanPham(THName, DMName,Name).Tables[0];
                dgvSanPham.DataSource = dtSanPham;

                SLSP.Text = (dtSanPham.Rows.Count).ToString();

                if (dtSanPham.Rows.Count > 0)
                {
                    Product_ID = dgvSanPham.Rows[0].Cells[0].Value.ToString();
                }
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
            int r = dgvSanPham.RowCount;
            if (r > 1)
            {
                DetailForm detailForm = new DetailForm(0, Product_ID);
                detailForm.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm");
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            Product_ID = dgvSanPham.Rows[r].Cells[0].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int r = dgvSanPham.RowCount;
            if (r > 1)
            {
                detailForm = new DetailForm(1, Product_ID);
                detailForm.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            detailForm = new DetailForm(2, Product_ID);
            detailForm.Show();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NameText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                THName = THCombox.Text;
                Name = NameText.Text;
                DataTable dtSanPham = dbsp.TimSanPham(THName, DMName, Name).Tables[0];
                dgvSanPham.DataSource = dtSanPham;

                SLSP.Text = (dtSanPham.Rows.Count).ToString();

                if (dtSanPham.Rows.Count > 0)
                {
                    Product_ID = dgvSanPham.Rows[0].Cells[0].Value.ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
