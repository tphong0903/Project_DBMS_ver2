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

namespace Project_ver1.UI
{
    public partial class DetailForm : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        int Check;
        string Product_Id;
        public DetailForm(int check,string Product_ID)
        {
            Check=check;
            Product_Id = Product_ID;
            
            InitializeComponent();
            MaSP.Enabled = false;
            TenSP.Enabled = false;
            Gia.Enabled = false;
            ThuongHieu.Enabled = false;
            DanhMuc.Enabled = false;
            SoLuong.Enabled = false;
            SaveButton.Visible = false;
            if (Check == 1)
            {
                Gia.Enabled = true;
                SaveButton.Visible= true;
            }
            dbsp = new DBSanPham();
         
        }
        public void LoadData()
        {
            try
            {
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.ChiTietSanPham(Product_Id).Tables[0];
                a.DataSource = dtSanPham;
                MaSP.Text = a.Rows[0].Cells[0].Value.ToString();
                TenSP.Text = a.Rows[0].Cells[1].Value.ToString();
                Gia.Text = a.Rows[0].Cells[2].Value.ToString();
                ThuongHieu.Text = a.Rows[0].Cells[6].Value.ToString();
                DanhMuc.Text = a.Rows[0].Cells[7].Value.ToString();
                SoLuong.Text = a.Rows[0].Cells[3].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DetailForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
