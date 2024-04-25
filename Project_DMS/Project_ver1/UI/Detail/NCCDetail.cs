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
                SaveButton.Visible=false;
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
                textBoxMaNhaCungCap.Text = dt.Rows[0].Field<string>(0);
                textBoxTenNhaCungCap.Text = dt.Rows[0].Field<string>(1);
                textBoxSoDienThoai.Text = dt.Rows[0].Field<string>(2);
                textBoxDiaChi.Text = dt.Rows[0].Field<string>(3);
                textBoxEmail.Text= dt.Rows[0].Field<string>(4);
                Tong.Text= dt.Rows[0].Field<int?>(5).ToString()=="" ? "0":dt.Rows[0].Field<int?>(5).ToString();
            }
            catch (SqlException ex)
            {
                this.Close();
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }

        private void NCCDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Lệnh Update
                bool f = DBNhaCungCap.CapNhatNhaCungCap(ref err,
                this.textBoxMaNhaCungCap.Text.ToString(),
                this.textBoxTenNhaCungCap.Text.ToString(),
                this.textBoxSoDienThoai.Text.ToString(),
                this.textBoxDiaChi.Text.ToString(),
                this.textBoxEmail.Text.ToString());
                if (f)
                {
                    MessageBox.Show("Đã cập nhật xong!");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException ex)
            {
                this.Close();
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }
    }

}
