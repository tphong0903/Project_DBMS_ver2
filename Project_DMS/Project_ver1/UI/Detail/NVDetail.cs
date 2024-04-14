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
            imgButton.Visible = false;
            AddButton.Visible = false;
            if(Check ==1)
                LoadData();
            else if (Check ==2)
            {
                imgButton.Visible = true;
                AddButton.Visible = true;
                this.Text = "Cập nhật thông tin nhân viên";
                LoadData();
            }   
            else 
            {
                imgButton.Visible = true;
                AddButton.Visible = true;
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
                
                MaSP.Text=dt.Rows[0].Field<string>(0);
                TenSP.Text = dt.Rows[0].Field<string>(1);
                Ngay.Text = dt.Rows[0].Field<DateTime>(2).ToString();
                GT.Text =dt.Rows[0].Field<string>(3).ToString();
                DC.Text = dt.Rows[0].Field<string>(4);
                SDT.Text = dt.Rows[0].Field<string>(5);
                CV.Text = dt.Rows[0].Field<string>(6);
                TT.Text = dt.Rows[0].Field<string>(7);
                MK.Text = dt.Rows[0].Field<string>(8);
                Total.Text = dt.Rows[0].Field<int?>(9).ToString();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void NVDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                if (Check ==2)
                {
                    bool f = dbnv.CapNhatNhanVien(ref err,
                    MaSP.Text,
                    TenSP.Text,
                    Ngay.Value,
                    GT.Text,
                    DC.Text,
                    SDT.Text,
                    CV.Text,
                    int.Parse(TT.Text),
                    MK.Text);
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
                else if (Check ==3)
                {
                    bool f = dbnv.ThemNhanVien(ref err,
                    MaSP.Text,
                    TenSP.Text,
                    Ngay.Value,
                    GT.Text,
                    DC.Text,
                    SDT.Text,
                    CV.Text,
                    int.Parse(TT.Text),
                    MK.Text);
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
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được. Lỗi rồi!");
            }
        }
    }
}
