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
using Project_ver1.UI.Detail;
namespace Project_ver1.UI
{
    public partial class BienLaiUI : Form
    {
        DBBienLai dbbl;
        DataTable dtBienLai = null;
        BLDetail a = null;
        TaoBLForm b = null;
        public BienLaiUI()
        {
            InitializeComponent();
            dbbl = new DBBienLai();
        }
        private void LoadData()
        {
            try
            {
                dtBienLai = new DataTable();
                dtBienLai.Clear();
                dtBienLai = dbbl.LayThanhPho().Tables[0];
                dgvBienLai.DataSource = dtBienLai;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }
        private void BienLaiUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BienLaiUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtBienLai.Dispose();
            dtBienLai = null;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            a= new BLDetail();
            a.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            a = new BLDetail();
            a.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            b = new TaoBLForm();
            b.ShowDialog();
        }
    }
}
