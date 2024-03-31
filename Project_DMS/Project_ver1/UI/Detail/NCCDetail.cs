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

namespace Project_ver1.UI.Detail
{
    public partial class NCCDetail : Form
    {
        DBNhaCungCap DBNhaCungCap = null;
        int Check;
        string ID = null;
        public NCCDetail(int check, string iD)
        {
            Check = check;
            ID = iD;
            InitializeComponent();
            DBNhaCungCap = new DBNhaCungCap();
            if(Check==1) 
            {
                AddButton.Visible=false;
            }
        }
        private void LoadData()
        {
            try
            {
                DataTable dtNCC = new DataTable();
                dtNCC.Clear();
                dtNCC = DBNhaCungCap.SPCuaNhaCungCap(ID).Tables[0];
                dgvSanPham.DataSource = dtNCC;

                DataTable dt = new DataTable();
                dt.Clear();
                dt = DBNhaCungCap.TimNhaCungCap(ID, "").Tables[0];
                MaSP.Text = dt.Rows[0].Field<string>(0);
                TenSP.Text = dt.Rows[0].Field<string>(1);
                ThuongHieu.Text = dt.Rows[0].Field<string>(2);
                DanhMuc.Text = dt.Rows[0].Field<string>(3);
                SoLuong.Text= dt.Rows[0].Field<string>(4);
                Tong.Text= dt.Rows[0].Field<int>(5).ToString();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void NCCDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
