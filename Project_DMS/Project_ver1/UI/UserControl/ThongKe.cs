using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace Project_ver1.UI.UserControl
{
    public partial class ThongKe : Form
    {
        private DBThongKe model;

        public ThongKe()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            Btn7Date.Select();

            model = new DBThongKe();
            LoadData();
        }

        private void LoadData()
        {
            bool refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            //if (refreshData)
            //{
            //    SLDH.Text = model.NumOrder.ToString();
            //    lbTotalRe.Text = model.TotalRevenue.ToString();
            //    lbTotalPro.Text = model.TotalProfit.ToString();
            //    SLKH.Text = model.NumCustommers.ToString();
            //    SLNCC.Text = model.NumSuppliers.ToString();
            //    SLSPham.Text = model.NumProduct.ToString();

            //    chartGross.DataSource = model.GrossRevenueList;
            //    chartGross.Series[0].XValueMember = "Date";
            //    chartGross.Series[0].YValueMembers = "TotalAmount";
            //    chartGross.DataBind();

            //    chartProduct.DataSource = model.TopProductList;
            //    chartProduct.Series[0].XValueMember = "Key";
            //    chartProduct.Series[0].YValueMembers = "Value";
            //    chartProduct.DataBind();

            //    dgvUnderstock.DataSource = model.UnderstockList;
            //}
            //else
            //{
            //    MessageBox.Show("Khong load được dữ liệu.");
            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Your button click event handler code goes here
        }
    }
}
