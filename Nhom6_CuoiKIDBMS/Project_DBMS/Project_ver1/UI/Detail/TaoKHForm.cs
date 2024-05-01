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

namespace Project_ver1.UI.Detail
{
    public partial class TaoKHForm : Form
    {
        DBKhachHang dbKHang;
        public TaoKHForm()
        {
            InitializeComponent();
            dbKHang = new DBKhachHang();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Insert
                bool f = dbKHang.ThemKhachHang(ref err,
                txtSdt.Text,
                txtName.Text,
                dtpBirthday.Value,
                ComboGT.Text,
                int.Parse(txtPoint.Text));
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show("Chưa được thêm vào!\n\r" + err);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }
    }
}
