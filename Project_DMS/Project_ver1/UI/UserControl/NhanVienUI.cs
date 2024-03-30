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
namespace Project_ver1.UI
{
    public partial class NhanVienUI : Form
    {
        DBNhanVien dbnv;
        DataTable dtNhanVien = null;
        NVDetail a = null;
        public NhanVienUI()
        {
            InitializeComponent();
            dbnv = new DBNhanVien();
        }
        public void LoadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbnv.LayThanhPho().Tables[0]; 
                dgvNhanVien.DataSource = dtNhanVien;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }

        private void NhanVienUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NhanVienUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            a=new NVDetail();
            a.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail();
            a.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail();
            a.ShowDialog();
        }

    }
}
