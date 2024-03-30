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
namespace Project_ver1.UI
{
    public partial class HoaDonUI : Form
    {
        DBHoaDon dbhd;
        DataTable dtHoaDon = null;
        public HoaDonUI()
        {
            InitializeComponent();
            dbhd = new DBHoaDon();
        }
        public void LoadData()
        {
            try
            {

                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                dtHoaDon = dbhd.LayThanhPho().Tables[0];
                // Đưa dữ liệu lên DataGridView  
                dgvHoaDon.DataSource = dtHoaDon;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }

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
            TaoHDForm a = new TaoHDForm();
            a.ShowDialog();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            HDDetail hd = new HDDetail();
            hd.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            HDDetail hd = new HDDetail();
            hd.ShowDialog();
        }
    }
}
