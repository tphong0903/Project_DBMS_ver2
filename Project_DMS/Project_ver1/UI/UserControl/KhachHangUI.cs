﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessAccessLayer;
using Project_ver1.UI.Detail;
namespace Project_ver1
{
    public partial class KhachHangUI : Form
    {
        DBKhachHang dbkh;
        DataTable dtKhachHang = null;
        KHDetail a = null;
        TaoKHForm b = null;
        public KhachHangUI()
        {
            InitializeComponent();
            dbkh = new DBKhachHang();
        }
        private void KhachHangUI_Load(object sender, EventArgs e)
        {
  
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                dtKhachHang = dbkh.LayThanhPho().Tables[0];
                // Đưa dữ liệu lên DataGridView  
                dgvKhachHang.DataSource = dtKhachHang;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }

        private void KhachHangUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtKhachHang.Dispose();
            dtKhachHang = null;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            a = new KHDetail();
            a.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            a = new KHDetail();
            a.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            b = new TaoKHForm();
            b.ShowDialog(); 
        }
    }
}
