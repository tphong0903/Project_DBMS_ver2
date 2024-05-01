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
            SaveButton.Visible = false;
            if(Check ==1)
                LoadData();
            else if (Check ==2)
            {
                SaveButton.Visible = true;
                this.Text = "Cập nhật thông tin nhân viên";
                LoadData();
            }   
            else 
            {
                SaveButton.Visible = true;
                textBoxTrangThai.Text = "1";
                textBoxTrangThai.Enabled = false;
                textBoxTotal.Visible = false;
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
                
                textBoxMaNV.Text=dt.Rows[0].Field<string>(0);
                textBoxTenNV.Text = dt.Rows[0].Field<string>(1);
                dateTimePicker.Text = dt.Rows[0].Field<DateTime>(2).ToString();
                comboBoxGioiTinh.Text =dt.Rows[0].Field<string>(3).ToString();
                textBoxDiaChi.Text = dt.Rows[0].Field<string>(4);
                textBoxSDT.Text = dt.Rows[0].Field<string>(5);
                comboBoxChucVu.Text = dt.Rows[0].Field<string>(6);
                textBoxTrangThai.Text = dt.Rows[0].Field<string>(7);
                textBoxMK.Text = dt.Rows[0].Field<string>(8);
                textBoxTotal.Text = dt.Rows[0].Field<int?>(9).ToString();
            }
            catch (SqlException x)
            {
                this.Close();
                MessageBox.Show(" Lỗi rồi! \n"+x.Message);
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
                    textBoxMaNV.Text,
                    textBoxTenNV.Text,
                    dateTimePicker.Value,
                    comboBoxGioiTinh.Text,
                    textBoxDiaChi.Text,
                    textBoxSDT.Text,
                    comboBoxChucVu.Text,
                    int.Parse(textBoxTrangThai.Text),
                    textBoxMK.Text);
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
                    textBoxMaNV.Text,
                    textBoxTenNV.Text,
                    dateTimePicker.Value,
                    comboBoxGioiTinh.Text,
                    textBoxDiaChi.Text,
                    textBoxSDT.Text,
                    comboBoxChucVu.Text,
                    1,
                    textBoxMK.Text);
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
