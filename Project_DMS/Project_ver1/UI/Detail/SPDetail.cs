using BusinessAccessLayer;
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
        Image img = null;
        string selectedFilePath = null;
        string maPic_ID = null;
        bool checkChangeImg = false;
        public SPDetail(int check, string Product_ID)
        {
            Check = check;
            Product_Id = Product_ID;

            InitializeComponent();
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtGia.ReadOnly = true;
            SoLuong.ReadOnly = true;
            SaveButton.Visible = false;
            imgBtn.Visible = false;
            SaveButton.Visible = false;

            DataTable dtTT = new DataTable();
            dbsp = new DBSanPham();

            dtTT.Clear();
            dtTT = dbsp.LayThuongHieu().Tables[0];
            dtTT.Rows.InsertAt(dtTT.NewRow(), 0);
            ComboThuongHieu.DataSource = dtTT;
            ComboThuongHieu.DisplayMember = "BrandName";

            dtTT = new DataTable();
            dtTT = dbsp.LayDanhMuc().Tables[0];
            dtTT.Rows.InsertAt(dtTT.NewRow(), 0);
            ComboDanhMuc.DataSource = dtTT;
            ComboDanhMuc.DisplayMember = "CategoryName";
            this.Text = "Chi tiết sản phẩm";

            if (Check == 1)
            {
                this.Text = "Chi tiết sản phẩm";
                txtMaSP.ReadOnly = false;
                txtTenSP.ReadOnly = false;
                txtGia.ReadOnly = false;
                imgBtn.Visible = true;
                SaveButton.Visible = true;
            }
            else if (Check == 2)
            {
                this.Text = "Thêm sản phẩm";
                txtMaSP.ReadOnly = false;
                txtTenSP.ReadOnly = false;
                txtGia.ReadOnly = false;
                SoLuong.ReadOnly = false;
                SaveButton.Visible = true;
                txtGia.ReadOnly = false;
                imgBtn.Visible = true;
            }
            

        }
        public void LoadData()
        {
            try
            {
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.ChiTietSanPham(Product_Id).Tables[0];
                a.DataSource = dtSanPham;

                txtMaSP.Text = a.Rows[0].Cells[0].Value.ToString();
                txtTenSP.Text = a.Rows[0].Cells[1].Value.ToString();
                txtGia.Text = a.Rows[0].Cells[2].Value.ToString();
                ComboThuongHieu.Text = a.Rows[0].Cells[4].Value.ToString();
                ComboDanhMuc.Text = a.Rows[0].Cells[5].Value.ToString();
                SoLuong.Text = a.Rows[0].Cells[3].Value.ToString();

                PicProduct.Image = GetImageByName(a.Rows[0].Cells[6].Value.ToString());
                maPic_ID = a.Rows[0].Cells[7].Value.ToString();
                img = PicProduct.Image;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
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
        #region Event
        private void DetailForm_Load(object sender, EventArgs e)
        {
            if (Product_Id == "")
            {
                MessageBox.Show("Vui lòng chọn một hàng");
                this.Close();
            }
            else if (Check == 1 || Check == 0)
                LoadData();
            else
            {

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool f = false;
            string err = "";
            if(Check==2 && img == null)
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi lưu!");
                return;
            }
            if (checkChangeImg)
            {
                string imgFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Project_ver1/UI/Image");
                string imgFileName = Path.GetFileName(selectedFilePath);
                string imgFilePath = Path.Combine(imgFolderPath, imgFileName);
                if (Check == 2)
                {
                    img.Save(imgFilePath);
                    f = dbsp.ThemHinhAnh(imgFileName, err);
                }
                else if (Check == 1)
                {
                    string present = a.Rows[0].Cells[6].Value.ToString();
                    if (present != imgFileName)
                    {
                        img.Save(imgFilePath);
                        f = dbsp.SuaHinhAnh(imgFileName, int.Parse(maPic_ID), err);
                    }
                }
                if (f)
                {
                    UpateOrAddProduct(imgFileName);
                }
                else
                {
                    Console.WriteLine(err);
                }
            }
            else
            {
                UpateOrAddProduct("");
            }
        }

        private void UpateOrAddProduct(string imgFileName)
        {
            string err = "";

            if (Check == 1)
            {
                try
                {
                    bool f = dbsp.CapNhatSanPham(ref err,
                        txtMaSP.Text,
                        txtTenSP.Text,
                        int.Parse(txtGia.Text),
                        ComboThuongHieu.Text,
                        ComboDanhMuc.Text,
                        int.Parse(SoLuong.Text),
                        int.Parse(maPic_ID));
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
            else
            {
                try
                {
                    bool f;
                    if (txtGia.Text!="")
                    {
                       f = dbsp.TaoSanPham(ref err,
                       txtMaSP.Text,
                       txtTenSP.Text,
                       int.Parse(txtGia.Text),
                       ComboThuongHieu.Text,
                       ComboDanhMuc.Text,
                       0,
                       imgFileName);
                       if (f)
                       {
                            LoadData();
                            MessageBox.Show("Đã thêm mới xong!");
                       }
                       else
                       {
                            MessageBox.Show(err);
                       }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập giá!");
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm mới được. Lỗi rồi!");
                }
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
                checkChangeImg = true;
            }
        }
        #endregion
        
    }
}
