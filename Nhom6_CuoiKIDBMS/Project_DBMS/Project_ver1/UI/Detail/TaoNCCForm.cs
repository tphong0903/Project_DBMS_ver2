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
    public partial class TaoNCCForm : Form
    {
        DBNhaCungCap dbncc = null;
        public TaoNCCForm()
        {
            InitializeComponent();
            dbncc = new DBNhaCungCap();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Lệnh Insert InTo 
                bool f = dbncc.ThemNhaCungCap(ref err,
                this.textBoxMaNhaCungCap.Text.ToString(),
                this.textBoxTenNhaCungCap.Text.ToString(),
                this.textBoxSoDienThoai.Text.ToString(),
                this.textBoxDiaChi.Text.ToString(),
                this.textBoxEmail.Text.ToString());
                if (f)
                {
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Đã thêm chưa xong!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }

    }
}
