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
        public NhanVienUI()
        {
            InitializeComponent();
            dbnv = new DBNhanVien();
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
                gunaLabel2.Text = (dgvNhanVien.RowCount - 1).ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }

        private void NhanVienUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NhanVienUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            a=new NVDetail(1,ID);
            a.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail(2, ID);
            a.ShowDialog();
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
            MaSP.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            TenSP.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            DanhMuc.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            Ngay.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            SoLuong.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            ThuongHieu.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
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
                    gunaLabel2.Text = (dgvNhanVien.RowCount - 1).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
