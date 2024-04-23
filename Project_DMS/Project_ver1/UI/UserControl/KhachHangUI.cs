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
namespace Project_ver1
{
    public partial class KhachHangUI : Form
    {
        DBKhachHang dbkh;
        DataTable dtKhachHang = null;
        KHDetail ChiTietKhachHang = null;
        TaoKHForm TaoKhachHang = null;
        string Phone = null;
        public KhachHangUI()
        {
            InitializeComponent();
            dbkh = new DBKhachHang();
        }
        private void KhachHangUI_Load(object sender, EventArgs e)
        {
  
            LoadData();
        }
       
        public void LoadData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbkh.LayKhachHang().Tables[0];
                dgvKhachHang.DataSource = dtKhachHang;

                Phone = dgvKhachHang.Rows[0].Cells[0].Value.ToString();
                LabelSLKH.Text = (dgvKhachHang.RowCount - 1).ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }
        #region Event

        private void KhachHangUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachHang.Dispose();
            dtKhachHang = null;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            ChiTietKhachHang = new KHDetail(1,Phone);
            ChiTietKhachHang.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ChiTietKhachHang = new KHDetail(2, Phone);
            ChiTietKhachHang.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TaoKhachHang = new TaoKHForm();
            TaoKhachHang.ShowDialog(); 
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            Phone = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            SDT.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            Ten.Text= dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            GT.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            NS.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            Diem.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvKhachHang.Rows[r].Cells[5].Value.ToString()) ? "0" : dgvKhachHang.Rows[r].Cells[5].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            Total.Text = value.ToString("N0");
        }
        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                string SoDienThoai = txtSoDT.Text;
                string Name = txtName.Text.ToLower();
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbkh.TimKhachHang(SoDienThoai, Name).Tables[0];
                dgvKhachHang.DataSource = dtKhachHang;
                int r = dgvKhachHang.RowCount;
                if (r > 1)
                {
                    Phone = dgvKhachHang.Rows[0].Cells[0].Value.ToString();
                    LabelSLKH.Text = (dgvKhachHang.RowCount - 1).ToString();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            txtSoDT.Text = null;
            txtName.Text = null;
            LoadData();
        }
        #endregion
    }
}
