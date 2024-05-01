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
using Project_ver1.UI.Detail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_ver1.UI
{
    public partial class NhanVienUI : Form
    {
        DBNhanVien dbnv;
        DataTable dtNhanVien = null;
        NVDetail a = null;
        string ID = null;
        public NhanVienUI(string s)
        {
            InitializeComponent();
            dbnv = new DBNhanVien();
            if (s.Contains("BH"))
                DeleBtn.Visible = false;
        }
        public void LoadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbnv.LayNhanVien().Tables[0]; 
                dgvNhanVien.DataSource = dtNhanVien;

                ID = dgvNhanVien.Rows[0].Cells[0].Value.ToString().ToLower();
                LabelSNV.Text = (dgvNhanVien.RowCount - 1).ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung .Lỗi rồi!!!");
            }
        }
        #region Event
        private void NhanVienUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NhanVienUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtNhanVien.Dispose();
            dtNhanVien = null;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = new NVDetail(1, ID);
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = new NVDetail(2, ID);
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail(3,ID);
            a.ShowDialog();
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            ID = dgvNhanVien.Rows[r].Cells[0].Value.ToString().ToLower();
            txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            txtGT.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            Ngay.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvNhanVien.Rows[r].Cells[7].Value.ToString()) ? "0" : dgvNhanVien.Rows[r].Cells[7].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            txtTotal.Text = value.ToString("N0");
            txtChucVu.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {

                string hd = MNV.Text;
                string name =NameText.Text;
                DataTable dtHoaDon = new DataTable();
                dtHoaDon.Clear();

                dtHoaDon = dbnv.TimNhanVien(hd, name).Tables[0];
                dgvNhanVien.DataSource = dtHoaDon;
                int r = dgvNhanVien.RowCount;
                if (r > 1)
                {
                    ID = dgvNhanVien.Rows[0].Cells[0].Value.ToString();
                    LabelSNV.Text = (dgvNhanVien.RowCount - 1).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            MNV.Text = null;
            NameText.Text = null;
            LoadData();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                    bool f = dbnv.XoaNhanVien(ref err,txtMaNV.Text);
                    if (f)
                    {
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã xóa chưa xong!\n\r" + "Lỗi:" + err);
                    }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được. Lỗi rồi!");
            }
        }
        #endregion


    }
}
