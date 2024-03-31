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
    public partial class BLDetail : Form
    {
        int Check;
        string ID;
        DBBienLai dbbl = null;
        public BLDetail(int check,string id)
        {
            Check = check;
            ID = id;
            InitializeComponent();
            dbbl = new DBBienLai();
        }
        public void LoadData()
        {
            try
            {
                DataTable dtsp = new DataTable();
                dtsp.Clear();
                dtsp = dbbl.SPCuaBienLai(ID).Tables[0];
                dgvSanPham.DataSource = dtsp;

                DataTable dt = new DataTable();
                dt.Clear();
                dt = dbbl.TimBienLai(ID, "").Tables[0];
                MaSP.Text = dt.Rows[0].Field<string>(0);
                TenSP.Text = dt.Rows[0].Field<string>(3);
                Gia.Text = dt.Rows[0].Field<string>(4);
                Ngay.Text = dt.Rows[0].Field<DateTime>(1).ToString();
                Tong.Text = dt.Rows[0].Field<int>(2).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BLDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
