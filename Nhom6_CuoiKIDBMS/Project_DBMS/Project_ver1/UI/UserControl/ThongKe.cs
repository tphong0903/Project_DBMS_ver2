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
            DisableCustomDates();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData== true)
            {
                SLDH.Text = model.NumOrder.ToString();
                lbTotalRe.Text = model.TotalRevenue.ToString("N0");
                lbTotalPro.Text = model.TotalProfit.ToString("N0");
                SLKH.Text = model.NumCustommers.ToString();
                SLNCC.Text = model.NumSuppliers.ToString();
                SLSPham.Text = model.NumProduct.ToString();

                chartGross.DataSource = model.GrossRevenueList;
                chartGross.Series[0].XValueMember = "Date";
                chartGross.Series[0].YValueMembers = "TotalAmount";
                chartGross.DataBind();

                chartProduct.DataSource = model.TopProductsList;
                chartProduct.Series[0].XValueMember = "Key";
                chartProduct.Series[0].YValueMembers = "Value";
                chartProduct.DataBind();

                dgvUnderstock.DataSource = model.UnderstocksList;
            }
            else
            {
                MessageBox.Show("Khong load được dữ liệu.");
            }
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            tick.Visible = false;
        }
        #region Event
        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }
        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }
        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }
        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            tick.Visible = true;
        }
        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}
