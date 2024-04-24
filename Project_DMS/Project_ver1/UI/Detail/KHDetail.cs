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
    public partial class KHDetail : Form
    {
        int Check;
        string Phone = null;
        DataTable dtKhachHang = null;
        DBKhachHang dbkh = null;
        public KHDetail(int check, string phone)
        {
            Check = check;
            Phone = phone;
            InitializeComponent();
            dbkh = new DBKhachHang();
            txtSDT.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtDiem.ReadOnly = true;
            txtTotal.ReadOnly = true;
            SaveButton.Visible = false;
            if (Check == 2)
            {
                txtTen.ReadOnly = false;
                SaveButton.Visible = true;
            }
        }
        private void LoadData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbkh.SPcuaKhachHang(Phone).Tables[0];
                dgvSP.DataSource = dtKhachHang;

                DataTable dt = new DataTable();
                dt.Clear();
                dt = dbkh.TimKhachHang(Phone, "").Tables[0];

                txtSDT.Text = dt.Rows[0].Field<string>(0);
                txtTen.Text = dt.Rows[0].Field<string>(1);
                txtNgaySinh.Text = dt.Rows[0].Field<DateTime>(2).ToString();
                ComboGioiTinh.Text = dt.Rows[0].Field<string>(3).ToString();
                txtDiem.Text = dt.Rows[0].Field<int>(4).ToString();
                txtTotal.Text = dt.Rows[0].Field<int?>(5).ToString() == "" ? "0" : dt.Rows[0].Field<int?>(5).ToString();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        private void Form_load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool f = dbkh.CapNhatKhachHang(ref err,
                    txtSDT.Text,
                    txtTen.Text,
                    txtNgaySinh.Value,
                    ComboGioiTinh.Text,
                    int.Parse(txtDiem.Text));
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Đã cập nhật xong!");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được. Lỗi rồi!");
            }
        }

    }
}
