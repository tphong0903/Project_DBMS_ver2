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
using System.Xml.Linq;

namespace Project_ver1.UI.Detail
{
    public partial class TaoHDForm : Form
    {
        DBSanPham dbsp= null;
        DBHoaDon dbhd;
        string hd;
        int r=0;
        int x = 0;
        int Tong = 0;
        public TaoHDForm(string s)
        {
            InitializeComponent();
            dbsp= new DBSanPham();
            dbhd = new DBHoaDon();
            txtMaNV.Text = s;
        }
     
        private void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = dbsp.LaySanPham().Tables[0];
                dgvSanPham.DataSource = dt;

                dt = new DataTable();
                dt = dbhd.LayHoaDon().Tables[0];

                int s = dt.Rows.Count+1;
                string hd = "HD";
                if (s < 10)
                    hd = hd + "0000";
                else if(s<100)
                    hd = hd + "000";
                else if (s < 1000)
                    hd = hd + "00";
                else if (s < 10000)
                    hd = hd + "0";
                txtMaHD.Text= hd+s;
                txtMaHD.ReadOnly= true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được nội dung trong.Lỗi rồi!!! \n\n Lỗi: "+ ex.Message);
            }
        }
        #region Event
        //nut Them San Pham
        private void ThemSPButton_Click(object sender, EventArgs e)
        {
            r = dgvSanPham.CurrentCell.RowIndex;
            string MaSP = dgvSanPham.Rows[r].Cells[0].Value.ToString();
            string TenSP = dgvSanPham.Rows[r].Cells[1].Value.ToString();
            string GiaBan = dgvSanPham.Rows[r].Cells[2].Value.ToString();
            string SLCon = dgvSanPham.Rows[r].Cells[3].Value.ToString();
            string SL = SLmua.Text;
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dbhd.LayGiamGia(txtGiamGia.Text).Tables[0];
            double PhanTram = dt.Rows[0].Field<int>(1);
            if (SL == "" || Int32.Parse(SL) > Int32.Parse(SLCon))
            {
                MessageBox.Show("Khong du san pham");
            }
            else
            {
                Tong = Tong + Int32.Parse(SL) * Int32.Parse(GiaBan);
                txtTongTien.Text = (Tong*(1- PhanTram/100)).ToString();
                dgvSPMua.Rows.Add(new Object[] { MaSP, TenSP, GiaBan, SL });
                dgvSanPham.Rows[r].Cells[3].Value = (Int32.Parse(SLCon) - Int32.Parse(SL)).ToString();
            }
        }
        private void TaoHDForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                Name = NameText.Text.ToLower();
                DataTable dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.TimSanPham( "","",Name).Tables[0];
                dgvSanPham.DataSource = dtSanPham;
            

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            x = dgvSPMua.CurrentCell.RowIndex;
            dgvSPMua.Rows.RemoveAt(x);
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {

                bool f = dbhd.ThemHoaDon(ref err, txtMaHD.Text, txtSDT.Text, txtMaNV.Text, txtDate.Value, 0,txtGiamGia.Text) ;
                if (f)
                {
                    foreach (DataGridViewRow row in dgvSPMua.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string maSP = row.Cells[0].Value.ToString();
                            int soLuong = Convert.ToInt32(row.Cells[3].Value);
                            bool success = dbhd.ThemChiTietHoaDon(ref err, txtMaHD.Text, maSP, soLuong);
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
        #endregion
    }

}
