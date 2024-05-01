using BusinessAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_ver1.UI.Detail
{
    public partial class TaoBLForm : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        DBBienLai dbbl;
        string hd;
        int r = 0;

        public TaoBLForm()
        {
            InitializeComponent();
            dbsp = new DBSanPham();
            dbbl = new DBBienLai();
        }

        public void LoadData()
        {
            try
            {
                dtSanPham = dbsp.LaySanPhamChoFormBienLai().Tables[0];
                dgvSanPham.DataSource = dtSanPham;

                dtSanPham = dbbl.LayBienLai().Tables[0];
                int s= dtSanPham.Rows.Count +1;
                string bl = "NH";
                if (s < 10)
                    bl = bl + "0000";
                else if (s < 100)
                    bl = bl + "000";
                else if (s < 1000)
                    bl = bl + "00";
                else if (s < 10000)
                    bl = bl + "0";
                textBoxMaBienLai.Text = bl+s;
                textBoxMaBienLai.Enabled = false;

            }
            catch (SqlException ex)
            {
                this.Close();
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }
        #region Event
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = e.RowIndex;
        }

        private void TaoBLForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBoxTenSanPhamFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hd = FindNameText.Text;
                dtSanPham = dbsp.TimSanPham("", "", hd).Tables[0];
                dgvSanPham.DataSource = dtSanPham;

                if (dgvSanPham.RowCount > 1)
                {
                    hd = dgvSanPham.Rows[0].Cells[0].Value.ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error searching for product: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null && !string.IsNullOrEmpty(textBoxSoLuong.Text) && !string.IsNullOrEmpty(textBoxGiaNhap.Text))
            {
                r = dgvSanPham.CurrentCell.RowIndex;
                string MaSP = dgvSanPham.Rows[r].Cells[1].Value.ToString();
                string TenSP = dgvSanPham.Rows[r].Cells[2].Value.ToString();
                string GN = textBoxGiaNhap.Text;
                string SL = textBoxSoLuong.Text;
                SoLuong.Text = (Int32.Parse(SoLuong.Text) + Int32.Parse(SL)).ToString();
                textBoxThanhTien.Text = (Int32.Parse(textBoxThanhTien.Text) + Int32.Parse(SL) * Int32.Parse(GN)).ToString();
                insertGridView.Rows.Add(new object[] { MaSP, TenSP, GN, SL });
            }
            else
            {
                MessageBox.Show("Please select a product and fill in quantity and cost.");
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool f = dbbl.ThemBienLai(ref err, textBoxMaBienLai.Text, textBoxMaNhaCungCap.Text, dateTimePickerNgayThanhToan.Value, 0);
                if (f)
                {
                    foreach (DataGridViewRow row in insertGridView.Rows)
                    {
                        if (row.Cells["Product_ID"].Value != null)
                        {
                            string maSP = row.Cells["Product_ID"].Value.ToString();
                            int soLuong = Convert.ToInt32(row.Cells["Quantity"].Value);
                            int giaNhap = Convert.ToInt32(row.Cells["UnitCost"].Value);

                            bool success = dbbl.ThemChiTietBienLai(ref err, textBoxMaBienLai.Text, maSP, soLuong, giaNhap);
                        }
                    }
                    MessageBox.Show("Successfully added!");
                }
                else
                {
                    MessageBox.Show("Failed to add!\n\r" + "Error:" + err);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding invoice: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (insertGridView.CurrentRow != null)
            {
                int x = insertGridView.CurrentRow.Index;
                insertGridView.Rows.RemoveAt(x);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        #endregion
    }
}


