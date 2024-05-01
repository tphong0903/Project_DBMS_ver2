using BusinessAccessLayer;
using Project_ver1.UI.Detail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_ver1.UI.Detail;
namespace Project_ver1.UI
{
    public partial class NhaCungCapUI : Form
    {
        DBNhaCungCap dbncc;
        DataTable dtCungCap=null;
        NCCDetail a = null;
        TaoNCCForm b = null;
        string ID = null;
        public NhaCungCapUI()
        {
            InitializeComponent();
            dbncc = new DBNhaCungCap();
        }
        private void LoadData()
        {
            try
            {
                dtCungCap = new DataTable();
                dtCungCap.Clear();
                dtCungCap = dbncc.LayNhaCungCap().Tables[0];
                dgvNCC.DataSource = dtCungCap;

                ID = dgvNCC.Rows[0].Cells[0].Value.ToString().ToLower();
                LabelSNCC.Text = (dgvNCC.RowCount - 1).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }
        #region Event
        private void NhaCungCapUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtCungCap.Dispose();
            dtCungCap = null;
        }

        private void NhaCungCapUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = new NCCDetail(1, ID);
                a.ShowDialog();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = new NCCDetail(2 ,ID);
                a.ShowDialog();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\nLỗi: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            b = new TaoNCCForm();
            b.ShowDialog();
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNCC.CurrentCell.RowIndex;
            ID = dgvNCC.Rows[r].Cells[0].Value.ToString().ToLower();
            txtMaNCC.Text = dgvNCC.Rows[r].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[r].Cells[1].Value.ToString();
            txtEmail.Text = dgvNCC.Rows[r].Cells[4].Value.ToString();
            txtSDT.Text = dgvNCC.Rows[r].Cells[2].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvNCC.Rows[r].Cells[5].Value.ToString()) ? "0" : dgvNCC.Rows[r].Cells[5].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            txtTotal.Text = value.ToString("N0");
            txtDiaChi.Text = dgvNCC.Rows[r].Cells[3].Value.ToString();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {

                string hd = MaNhaCungCap.Text;
                string name = NameNCC.Text;
                DataTable dtHoaDon = new DataTable();
                dtHoaDon.Clear();

                dtHoaDon = dbncc.TimNhaCungCap(hd, name).Tables[0];
                dgvNCC.DataSource = dtHoaDon;
                int r = dgvNCC.RowCount;
                if (r > 1)
                {
                    ID = dgvNCC.Rows[0].Cells[0].Value.ToString();
                    LabelSNCC.Text = (dgvNCC.RowCount - 1).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}
