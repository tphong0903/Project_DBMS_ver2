using BusinessAccessLayer;
using Project_ver1.UI.Detail;
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
using Project_ver1.UI.Detail;
namespace Project_ver1.UI
{
    public partial class NhaCungCapUI : Form
    {
        DBNhaCungCap dbncc;
        DataTable dtCungCap=null;
        NCCDetail a = null;
        TaoNCCForm b = null;
        public NhaCungCapUI()
        {
            InitializeComponent();
            dbncc = new DBNhaCungCap();
        }
        private void LoadData()
        {
            try
            {
                dtCungCap = new DataTable();
                dtCungCap.Clear();
                dtCungCap = dbncc.LayThanhPho().Tables[0];
                dgvNCC.DataSource = dtCungCap;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }
        private void NhaCungCapUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtCungCap.Dispose();
            dtCungCap = null;
        }

        private void NhaCungCapUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            a = new NCCDetail();
            a.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            a = new NCCDetail();
            a.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            b = new TaoNCCForm();
            b.ShowDialog();
        }
    }
}
