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

namespace Project_ver1.UI
{
    public partial class NVDetail : Form
    {
        int Check;
        string ID;
        DBNhanVien dbnv = null;
        public NVDetail(int check, string iD)
        {
            Check = check;
            ID = iD;
            InitializeComponent();
            dbnv = new DBNhanVien();
            AddButton.Visible = false;
            if(Check ==1)
                LoadData();
            else if (Check ==2)
            {
                AddButton.Visible = true;
                this.Text = "Cập nhật thông tin nhân viên";
                LoadData();
            }   
            else 
            {
                AddButton.Visible = true;
                txtTrangThai.Text = "1";
                txtTrangThai.Enabled = false;
                textTotal.Visible = false;
                gunaLabel4.Visible = false;
                this.Text = "Thêm nhân viên mới";
            }

        }
        private void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = dbnv.TimAllNhanVien(ID).Tables[0];
                
                txtMaNV.Text=dt.Rows[0].Field<string>(0);
                txtTenNV.Text = dt.Rows[0].Field<string>(1);
                Ngay.Text = dt.Rows[0].Field<DateTime>(2).ToString();
                txtGioiTinh.Text =dt.Rows[0].Field<string>(3).ToString();
                textDiaChi.Text = dt.Rows[0].Field<string>(4);
                txtSDT.Text = dt.Rows[0].Field<string>(5);
                txtChucVu.Text = dt.Rows[0].Field<string>(6);
                txtTrangThai.Text = dt.Rows[0].Field<string>(7);
                MK.Text = dt.Rows[0].Field<string>(8);
                textTotal.Text = dt.Rows[0].Field<int?>(9).ToString();
            }
            catch (SqlException x)
            {
                this.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                if (Check ==2)
                {
                    bool f = dbnv.CapNhatNhanVien(ref err,
                    txtMaNV.Text,
                    txtTenNV.Text,
                    Ngay.Value,
                    txtGioiTinh.Text,
                    textDiaChi.Text,
                    txtSDT.Text,
                    txtChucVu.Text,
                    int.Parse(txtTrangThai.Text),
                    MK.Text);
                    if (f)
                    {
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                    }
                } 
                else if (Check ==3)
                {
                    bool f = dbnv.ThemNhanVien(ref err,
                    txtMaNV.Text,
                    txtTenNV.Text,
                    Ngay.Value,
                    txtGioiTinh.Text,
                    textDiaChi.Text,
                    txtSDT.Text,
                    txtChucVu.Text,
                    1,
                    MK.Text);
                    if (f)
                    {
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                    }
                }
                //this.Close();
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được. Lỗi rồi!");
            }
        }
    }
}
