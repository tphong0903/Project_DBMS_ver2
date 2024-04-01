﻿using BusinessAccessLayer;
using Project_ver1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_ver1.UI
{
    public partial class SPDetail : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        int Check;
        string Product_Id;
        Image img=  null;
        string selectedFilePath = null;
        public SPDetail(int check, string Product_ID)
        {
            Check = check;
            Product_Id = Product_ID;

            InitializeComponent();
            MaSP.ReadOnly = true;
            TenSP.ReadOnly = true;
            Gia.ReadOnly = true;
            ThuongHieu.ReadOnly = true;
            DanhMuc.ReadOnly = true;
            SoLuong.ReadOnly = true;
            SaveButton.Visible = false;
            imgBtn.Visible = false;
            SaveButton.Visible = false;
            this.Text = "Chi tiết sản phẩm";
        
            if (Check == 1)
            {
                PicProduct.Image = GetImageByName("AdidasXCrazyfastMessi.jpg");
                this.Text = "Chi tiết sản phẩm";
                MaSP.ReadOnly = false;
                TenSP.ReadOnly = false;
                Gia.ReadOnly = false;
                ThuongHieu.ReadOnly = true;
                DanhMuc.ReadOnly = true;
                SaveButton.Visible = true;
            }
            else if (Check == 2)
            {
                this.Text = "Thêm sản phẩm";
                MaSP.ReadOnly = false;
                TenSP.ReadOnly = false;
                Gia.ReadOnly = false;
                ThuongHieu.ReadOnly = true;
                DanhMuc.ReadOnly = true;
                SoLuong.ReadOnly = false;
                SaveButton.Visible = true;
                Gia.ReadOnly = false;
                imgBtn.Visible = true;
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
                ThuongHieu.Text = a.Rows[0].Cells[4].Value.ToString();
                DanhMuc.Text = a.Rows[0].Cells[5].Value.ToString();
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
            else if (Check == 1 || Check == 0)
                LoadData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (img != null && !string.IsNullOrEmpty(selectedFilePath))
            {
                // Đường dẫn tới thư mục IMG trong thư mục Image của project_ver1
                string imgFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Project_ver1/UI/Image");

                // Tạo thư mục IMG nếu nó không tồn tại
                if (!Directory.Exists(imgFolderPath))
                {
                    Directory.CreateDirectory(imgFolderPath);
                }
                // Tạo tên file từ đường dẫn đã chọn
                string imgFileName = Path.GetFileName(selectedFilePath);
                // Đường dẫn đến tệp tin ảnh trong thư mục IMG
                string imgFilePath = Path.Combine(imgFolderPath, imgFileName);
                // Lưu ảnh vào thư mục IMG
                img.Save(imgFilePath);
                // Hiển thị thông báo thành công
                MessageBox.Show("Ảnh đã được lưu vào thư mục IMG trong project_ver1 của solution1 thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi lưu!");
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Hình ảnh";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(selectedFilePath);
                PicProduct.Image = selectedImage;
                img = selectedImage;
               
            }
        }
        private Image GetImageByName(string imageName)
        {
            // Đường dẫn tới thư mục IMG trong thư mục Image của project_ver1
            string imgFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Project_ver1/UI/Image");
            try
            {
                // Đường dẫn đến tệp tin ảnh bằng tên hình ảnh
                string imgFilePath = Path.Combine(imgFolderPath, imageName);
                // Kiểm tra xem tệp tin ảnh có tồn tại không
                if (File.Exists(imgFilePath))
                {
                    // Tạo một đối tượng Image từ tệp tin ảnh
                    Image image = Image.FromFile(imgFilePath);
                    return image;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình ảnh có tên: " + imageName);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
    }
}
