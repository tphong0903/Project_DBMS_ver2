﻿using BusinessAccessLayer;
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
    public partial class TaoHDForm : Form
    {
        DBSanPham dbsp= null;
        int r=0;
        int x = 0;
        public TaoHDForm()
        {
            InitializeComponent();
            dbsp= new DBSanPham();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            r = dgvSanPham.CurrentCell.RowIndex;
            string MaSP = dgvSanPham.Rows[r].Cells[0].Value.ToString();
            string TenSP = dgvSanPham.Rows[r].Cells[1].Value.ToString();
            string GiaBan = dgvSanPham.Rows[r].Cells[2].Value.ToString();
            string SLCon = dgvSanPham.Rows[r].Cells[3].Value.ToString();
            string SL = SLmua.Text;
            if(SL == "" || Int32.Parse(SL)> Int32.Parse(SLCon))
            {
                MessageBox.Show("Khong du san pham");
            }
            else
            {
                dgvSPMua.Rows.Add(new Object[] { MaSP, TenSP, GiaBan, SL });
                dgvSanPham.Rows[r].Cells[3].Value=(Int32.Parse(SLCon)- Int32.Parse(SL)).ToString();
            }
        }
        private void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = dbsp.LayThanhPho().Tables[0];
                dgvSanPham.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }
        private void TaoHDForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                Name = NameText.Text.ToLower();
                DataTable dtSanPham = new DataTable();
                dtSanPham.Clear();
                dtSanPham = dbsp.TimSanPham( "","",Name).Tables[0];
                dgvSanPham.DataSource = dtSanPham;
            

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            x = dgvSPMua.CurrentCell.RowIndex;
            dgvSPMua.Rows.RemoveAt(x);
        }
    }

}
