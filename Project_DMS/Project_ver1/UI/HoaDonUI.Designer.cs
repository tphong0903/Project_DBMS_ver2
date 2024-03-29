﻿namespace Project_ver1.UI
{
    partial class HoaDonUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonUI));
            this.dgvHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.FindButton = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.ReadButton = new Guna.UI.WinForms.GunaButton();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.RemoveButton = new Guna.UI.WinForms.GunaButton();
            this.UpdateButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHoaDon.ColumnHeadersHeight = 30;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.PhoneNumber,
            this.MaNV,
            this.NgayThanhToan,
            this.TongTien,
            this.MaKM});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 160);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1011, 467);
            this.dgvHoaDon.StandardTab = true;
            this.dgvHoaDon.TabIndex = 12;
            this.dgvHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvHoaDon.ThemeStyle.ReadOnly = true;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "Order_ID";
            this.OrderID.HeaderText = "Mã hóa đơn";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "EmployeeID";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.DataPropertyName = "OrderDate";
            this.NgayThanhToan.HeaderText = "Ngày thanh toán";
            this.NgayThanhToan.MinimumWidth = 6;
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Total";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // MaKM
            // 
            this.MaKM.DataPropertyName = "DiscountCode";
            this.MaKM.HeaderText = "Mã khuyến mãi";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2DateTimePicker1);
            this.panel1.Controls.Add(this.gunaTextBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gunaTextBox1);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Location = new System.Drawing.Point(247, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 133);
            this.panel1.TabIndex = 14;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(404, 52);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(225, 36);
            this.guna2DateTimePicker1.TabIndex = 24;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 3, 22, 21, 10, 19, 800);
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(13, 57);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(179, 31);
            this.gunaTextBox2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(222, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số Điện thoại";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(198, 57);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(200, 31);
            this.gunaTextBox1.TabIndex = 21;
            // 
            // FindButton
            // 
            this.FindButton.AnimationHoverSpeed = 0.07F;
            this.FindButton.AnimationSpeed = 0.03F;
            this.FindButton.BackColor = System.Drawing.Color.Transparent;
            this.FindButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.FindButton.BorderColor = System.Drawing.Color.Black;
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.FocusedColor = System.Drawing.Color.Empty;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
            this.FindButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindButton.ImageSize = new System.Drawing.Size(30, 30);
            this.FindButton.Location = new System.Drawing.Point(643, 44);
            this.FindButton.Name = "FindButton";
            this.FindButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.FindButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FindButton.OnHoverForeColor = System.Drawing.Color.White;
            this.FindButton.OnHoverImage = null;
            this.FindButton.OnPressedColor = System.Drawing.Color.Black;
            this.FindButton.Radius = 15;
            this.FindButton.Size = new System.Drawing.Size(115, 55);
            this.FindButton.TabIndex = 5;
            this.FindButton.TabStop = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaElipsePanel1.Controls.Add(this.ReadButton);
            this.gunaElipsePanel1.Controls.Add(this.AddButton);
            this.gunaElipsePanel1.Controls.Add(this.RemoveButton);
            this.gunaElipsePanel1.Controls.Add(this.UpdateButton);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(420, 652);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(603, 71);
            this.gunaElipsePanel1.TabIndex = 15;
            // 
            // ReadButton
            // 
            this.ReadButton.AnimationHoverSpeed = 0.07F;
            this.ReadButton.AnimationSpeed = 0.03F;
            this.ReadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ReadButton.BorderColor = System.Drawing.Color.Black;
            this.ReadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReadButton.FocusedColor = System.Drawing.Color.Empty;
            this.ReadButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadButton.ForeColor = System.Drawing.Color.Black;
            this.ReadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReadButton.Image")));
            this.ReadButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ReadButton.Location = new System.Drawing.Point(262, 3);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ReadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReadButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ReadButton.OnHoverImage = null;
            this.ReadButton.OnPressedColor = System.Drawing.Color.Black;
            this.ReadButton.Radius = 15;
            this.ReadButton.Size = new System.Drawing.Size(107, 49);
            this.ReadButton.TabIndex = 11;
            this.ReadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddButton
            // 
            this.AddButton.AnimationHoverSpeed = 0.07F;
            this.AddButton.AnimationSpeed = 0.03F;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.AddButton.BorderColor = System.Drawing.Color.Black;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddButton.Location = new System.Drawing.Point(488, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.AddButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddButton.OnHoverImage = null;
            this.AddButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddButton.Radius = 15;
            this.AddButton.Size = new System.Drawing.Size(107, 49);
            this.AddButton.TabIndex = 6;
            this.AddButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveButton
            // 
            this.RemoveButton.AnimationHoverSpeed = 0.07F;
            this.RemoveButton.AnimationSpeed = 0.03F;
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.RemoveButton.BorderColor = System.Drawing.Color.Black;
            this.RemoveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RemoveButton.FocusedColor = System.Drawing.Color.Empty;
            this.RemoveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemoveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.RemoveButton.Location = new System.Drawing.Point(149, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.RemoveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RemoveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.RemoveButton.OnHoverImage = null;
            this.RemoveButton.OnPressedColor = System.Drawing.Color.Black;
            this.RemoveButton.Radius = 15;
            this.RemoveButton.Size = new System.Drawing.Size(107, 49);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateButton
            // 
            this.UpdateButton.AnimationHoverSpeed = 0.07F;
            this.UpdateButton.AnimationSpeed = 0.03F;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.UpdateButton.BorderColor = System.Drawing.Color.Black;
            this.UpdateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateButton.FocusedColor = System.Drawing.Color.Empty;
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.UpdateButton.Location = new System.Drawing.Point(375, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.UpdateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UpdateButton.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.OnHoverImage = null;
            this.UpdateButton.OnPressedColor = System.Drawing.Color.Black;
            this.UpdateButton.Radius = 15;
            this.UpdateButton.Size = new System.Drawing.Size(107, 49);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(65, 89);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(110, 27);
            this.gunaLabel1.TabIndex = 23;
            this.gunaLabel1.Text = "Hóa Đơn";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(85, 35);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(61, 44);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "20";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 7);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(219, 133);
            this.gunaPictureBox1.TabIndex = 22;
            this.gunaPictureBox1.TabStop = false;
            // 
            // HoaDonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 725);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.dgvHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDonUI_FormClosing);
            this.Load += new System.EventHandler(this.HoaDonUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton FindButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton ReadButton;
        private Guna.UI.WinForms.GunaButton AddButton;
        private Guna.UI.WinForms.GunaButton RemoveButton;
        private Guna.UI.WinForms.GunaButton UpdateButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}