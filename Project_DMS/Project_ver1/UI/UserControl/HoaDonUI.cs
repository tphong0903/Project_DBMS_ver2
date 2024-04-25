using BusinessAccessLayer;
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
using System.Xml.Linq;
using System.Globalization;

namespace Project_ver1.UI
{
    public partial class HoaDonUI : Form
    {
        DBHoaDon dbhd;
        DataTable dtHoaDon = null;
        string HD = null;
        string date = null;
        string hd = null;
        string strMaNV=null;
        public HoaDonUI(string s)
        {
            this.strMaNV = s;
            InitializeComponent();
            if (strMaNV.Contains("BH"))
                DeleButton.Visible = false;
            dbhd = new DBHoaDon();
        }
        public void LoadData()
        {
            try
            {

                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                dtHoaDon = dbhd.LayHoaDon().Tables[0];
                dgvHoaDon.DataSource = dtHoaDon;

                HD = dgvHoaDon.Rows[0].Cells[0].Value.ToString().ToLower();
                LabelSoHoaDon.Text = (dgvHoaDon.RowCount - 1).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }
        #region Event
        private void HoaDonUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void HoaDonUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtHoaDon.Dispose();
            dtHoaDon = null;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TaoHDForm a = new TaoHDForm(strMaNV);
            a.ShowDialog();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            HDDetail hd = new HDDetail(1,HD);
            hd.ShowDialog();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            HD = dgvHoaDon.Rows[r].Cells[0].Value.ToString().ToLower();
            MaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            TenKhachHang.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            TenNhanVien.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            Ngay.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvHoaDon.Rows[r].Cells[4].Value.ToString()) ? "0" : dgvHoaDon.Rows[r].Cells[4].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            Total.Text = value.ToString("N0");
            ChietKhau.Text = dgvHoaDon.Rows[r].Cells[5].Value.ToString()+"%";
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tick.Checked==true) 
                {
                    DateTime a = DateTime.Parse(Date.Text);
                    if(a.Month <10)
                        date = a.Year+"-0"+a.Month+"-"+a.Day;
                    else
                        date = a.Year + "-" + a.Month + "-" + a.Day;
                }
                else
                {
                    date = null;
                }
                hd = MHD.Text;
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
            
                dtHoaDon = dbhd.TimHoaDon(hd, date).Tables[0];
                dgvHoaDon.DataSource = dtHoaDon;
                int r = dgvHoaDon.RowCount;
                if (r > 1)
                {
                    HD = dgvHoaDon.Rows[0].Cells[0].Value.ToString();
                    LabelSoHoaDon.Text = (dgvHoaDon.RowCount - 1).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                bool f = dbhd.XoaHoaDon(ref err, dgvHoaDon.Rows[r].Cells[0].Value.ToString());
                if (f)
                {
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    if(err != "Maximum stored procedure, function, trigger, or view nesting level exceeded (limit 32).")
                        MessageBox.Show("Đã xóa chưa xong!\n\r" + "Lỗi:" + err);
                    else
                        MessageBox.Show("Đã xóa xong!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }
        #endregion
    }
}
