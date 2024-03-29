﻿using BusinessAccessLayer;
using Project_ver1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            this.Text = "Chi tiết sản phẩm";
            if (Check == 1)
            {
                this.Text = "Chi tiết sản phẩm";
                Gia.Enabled = true;
                SaveButton.Visible= true;
            }
            else if(Check == 2) 
            {
                this.Text = "Thêm sản phẩm";
                MaSP.Enabled = true;
                TenSP.Enabled = true;
                Gia.Enabled = true;
                ThuongHieu.Enabled = true;
                DanhMuc.Enabled = true;
                SoLuong.Enabled = true;
                SaveButton.Visible = true;
                Gia.Enabled = true;
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
            if (Product_Id == "")
            {
                MessageBox.Show("Vui lòng chọn một hàng");
                this.Close();
            }
            else if (Check == 1 || Check ==0)
                LoadData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Hình ảnh"; 
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(selectedFilePath);
                PicProduct.Image = selectedImage;
            }
            // chưa xong
        }
    }
    
}
