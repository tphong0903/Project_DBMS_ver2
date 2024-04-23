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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_ver1.UI.Detail
{
    public partial class HDDetail : Form
    {
        int Check;
        string ID;
        DBHoaDon dbhd=null;
        public HDDetail(int check , string id)
        {
            Check = check;
            ID = id;
            InitializeComponent();
            dbhd = new DBHoaDon();
        }
        public void LoadData()
        {
            try
            {
                DataTable dtsp = new DataTable();
                dtsp.Clear();
                dtsp = dbhd.SPCuaHoaDon(ID).Tables[0];
                dgvSP.DataSource = dtsp;

                DataTable dt = new DataTable();
                dt.Clear();
                dt = dbhd.TimHoaDon(ID, "").Tables[0];
                textBoxMaHoaDon.Text = dt.Rows[0].Field<string>(0);
                textBoxSoDienThoai.Text = dt.Rows[0].Field<string>(6);
                textBoxTenKhachHang.Text = dt.Rows[0].Field<string>(1);
                dateTimePickerNgayThanhToan.Text = dt.Rows[0].Field<DateTime>(3).ToString();
                textBoxThanhTien.Text = dt.Rows[0].Field<int>(4).ToString();
                textBoxGiamGia.Text = dt.Rows[0].Field<int?>(5).ToString();
                textBoxTenNhanVien.Text = dt.Rows[0].Field<string>(2).ToString();
            }
            catch(SqlException ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void HDDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
