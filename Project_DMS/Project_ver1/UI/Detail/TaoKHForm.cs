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
                    DateTime.Parse(dtpBirthday.Text),
                    txtGender.Text,
                    int.Parse(txtPoint.Text));
                    if (f)
                    {
                        MessageBox.Show("Đã thêm xong!");
                }
                    else
                    {
                        MessageBox.Show("Chưa được thêm vào!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
        }
    }
}
