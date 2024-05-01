
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
        SPDetail detailForm = null;
        string Product_ID = null;
        string DMName =null;
        string THName =null;

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
                dtSanPham = dbsp.LaySanPham().Tables[0];
                dgvSanPham.DataSource = dtSanPham;

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
        #region Event
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
            }
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                THName = THCombox.Text;
                Name = NameText.Text.ToLower();
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.TimSanPham(THName,DMName,Name).Tables[0];
                dgvSanPham.DataSource = dtSanPham;
                int r = dgvSanPham.RowCount;
                if (r > 1)
                {
                    Product_ID = dgvSanPham.Rows[0].Cells[0].Value.ToString();
                    SLSP.Text = (dgvSanPham.RowCount - 1).ToString();
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

        private void ReadButton_Click(object sender, EventArgs e)
        {
            int r = dgvSanPham.RowCount;
            if (r > 1)
            {
                SPDetail detailForm = new SPDetail(0, Product_ID);
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
                detailForm = new SPDetail(1, Product_ID);
                detailForm.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            detailForm = new SPDetail(2, Product_ID);
            detailForm.Show();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            NameText.Text = null;
            DMName = null;
            THName = null;
            LoadData();
        }
        #endregion
    }
}
