namespace Project_ver1.UI
{
    partial class NhanVienUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienUI));
            this.dgvNhanVien = new Guna.UI.WinForms.GunaDataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadButton = new Guna.UI.WinForms.GunaButton();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.RemoveButton = new Guna.UI.WinForms.GunaButton();
            this.UpdateButton = new Guna.UI.WinForms.GunaButton();
            this.ReloadButton = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.TenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.DanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.ThuongHieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeight = 30;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.Birthday,
            this.GioiTinh,
            this.DiaChi,
            this.SDT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 373);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1070, 399);
            this.dgvNhanVien.TabIndex = 15;
            this.dgvNhanVien.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvNhanVien.ThemeStyle.ReadOnly = true;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "EmployeeID";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 165;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "NameEmployee";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 177;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Ngày sinh";
            this.Birthday.MinimumWidth = 6;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 133;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "Gender";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.Width = 128;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "AddressEmployee";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 103;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "PhoneNumber";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 163;
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
            this.ReadButton.Location = new System.Drawing.Point(751, 790);
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
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
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
            this.AddButton.Location = new System.Drawing.Point(977, 790);
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
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.RemoveButton.Location = new System.Drawing.Point(638, 787);
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
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
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
            this.UpdateButton.Location = new System.Drawing.Point(864, 790);
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
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.AnimationHoverSpeed = 0.07F;
            this.ReloadButton.AnimationSpeed = 0.03F;
            this.ReloadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReloadButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.ReloadButton.BorderColor = System.Drawing.Color.Black;
            this.ReloadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReloadButton.FocusedColor = System.Drawing.Color.Empty;
            this.ReloadButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.ForeColor = System.Drawing.Color.Black;
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReloadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ReloadButton.Location = new System.Drawing.Point(18, 787);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ReloadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReloadButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ReloadButton.OnHoverImage = null;
            this.ReloadButton.OnPressedColor = System.Drawing.Color.Black;
            this.ReloadButton.Radius = 15;
            this.ReloadButton.Size = new System.Drawing.Size(107, 49);
            this.ReloadButton.TabIndex = 110;
            this.ReloadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(981, 184);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(107, 49);
            this.gunaButton1.TabIndex = 151;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel9.Location = new System.Drawing.Point(412, 9);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(239, 27);
            this.gunaLabel9.TabIndex = 150;
            this.gunaLabel9.Text = "Thông tin nhân viên";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(775, 120);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(141, 19);
            this.gunaLabel6.TabIndex = 143;
            this.gunaLabel6.Text = "Tổng tiền đã bán";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(775, 50);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(77, 19);
            this.gunaLabel5.TabIndex = 142;
            this.gunaLabel5.Text = "Giới tính";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(400, 120);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(76, 19);
            this.gunaLabel4.TabIndex = 141;
            this.gunaLabel4.Text = "Chức vụ";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(400, 49);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(119, 19);
            this.gunaLabel7.TabIndex = 139;
            this.gunaLabel7.Text = "Tên nhân viên";
            // 
            // TenSP
            // 
            this.TenSP.AutoScroll = true;
            this.TenSP.BorderRadius = 10;
            this.TenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenSP.DefaultText = "";
            this.TenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenSP.DisabledState.Parent = this.TenSP;
            this.TenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenSP.FocusedState.Parent = this.TenSP;
            this.TenSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenSP.HoverState.Parent = this.TenSP;
            this.TenSP.Location = new System.Drawing.Point(379, 62);
            this.TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.TenSP.Name = "TenSP";
            this.TenSP.PasswordChar = '\0';
            this.TenSP.PlaceholderText = "";
            this.TenSP.SelectedText = "";
            this.TenSP.ShadowDecoration.Parent = this.TenSP;
            this.TenSP.Size = new System.Drawing.Size(337, 44);
            this.TenSP.TabIndex = 145;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel8.Location = new System.Drawing.Point(41, 50);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(112, 19);
            this.gunaLabel8.TabIndex = 138;
            this.gunaLabel8.Text = "Mã nhân viên";
            // 
            // SoLuong
            // 
            this.SoLuong.BorderRadius = 10;
            this.SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoLuong.DefaultText = "";
            this.SoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoLuong.DisabledState.Parent = this.SoLuong;
            this.SoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoLuong.FocusedState.Parent = this.SoLuong;
            this.SoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoLuong.HoverState.Parent = this.SoLuong;
            this.SoLuong.Location = new System.Drawing.Point(751, 133);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.PasswordChar = '\0';
            this.SoLuong.PlaceholderText = "";
            this.SoLuong.SelectedText = "";
            this.SoLuong.ShadowDecoration.Parent = this.SoLuong;
            this.SoLuong.Size = new System.Drawing.Size(337, 44);
            this.SoLuong.TabIndex = 149;
            // 
            // DanhMuc
            // 
            this.DanhMuc.BorderRadius = 10;
            this.DanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DanhMuc.DefaultText = "";
            this.DanhMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DanhMuc.DisabledState.Parent = this.DanhMuc;
            this.DanhMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DanhMuc.FocusedState.Parent = this.DanhMuc;
            this.DanhMuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DanhMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DanhMuc.HoverState.Parent = this.DanhMuc;
            this.DanhMuc.Location = new System.Drawing.Point(751, 62);
            this.DanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.PasswordChar = '\0';
            this.DanhMuc.PlaceholderText = "";
            this.DanhMuc.SelectedText = "";
            this.DanhMuc.ShadowDecoration.Parent = this.DanhMuc;
            this.DanhMuc.Size = new System.Drawing.Size(337, 44);
            this.DanhMuc.TabIndex = 148;
            // 
            // ThuongHieu
            // 
            this.ThuongHieu.BorderRadius = 10;
            this.ThuongHieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThuongHieu.DefaultText = "";
            this.ThuongHieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ThuongHieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ThuongHieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ThuongHieu.DisabledState.Parent = this.ThuongHieu;
            this.ThuongHieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ThuongHieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThuongHieu.FocusedState.Parent = this.ThuongHieu;
            this.ThuongHieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThuongHieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThuongHieu.HoverState.Parent = this.ThuongHieu;
            this.ThuongHieu.Location = new System.Drawing.Point(379, 133);
            this.ThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.PasswordChar = '\0';
            this.ThuongHieu.PlaceholderText = "";
            this.ThuongHieu.SelectedText = "";
            this.ThuongHieu.ShadowDecoration.Parent = this.ThuongHieu;
            this.ThuongHieu.Size = new System.Drawing.Size(337, 44);
            this.ThuongHieu.TabIndex = 147;
            // 
            // MaSP
            // 
            this.MaSP.BorderRadius = 10;
            this.MaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaSP.DefaultText = "";
            this.MaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaSP.DisabledState.Parent = this.MaSP;
            this.MaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaSP.FocusedState.Parent = this.MaSP;
            this.MaSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaSP.HoverState.Parent = this.MaSP;
            this.MaSP.Location = new System.Drawing.Point(20, 62);
            this.MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.MaSP.Name = "MaSP";
            this.MaSP.PasswordChar = '\0';
            this.MaSP.PlaceholderText = "";
            this.MaSP.SelectedText = "";
            this.MaSP.ShadowDecoration.Parent = this.MaSP;
            this.MaSP.Size = new System.Drawing.Size(318, 44);
            this.MaSP.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(259, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 137;
            this.label2.Text = "Số điện thoại";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AccessibleName = "";
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(243, 298);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(389, 44);
            this.guna2TextBox1.TabIndex = 136;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(51, 325);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(128, 27);
            this.gunaLabel1.TabIndex = 131;
            this.gunaLabel1.Text = "Nhân Viên";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(87, 271);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 44);
            this.gunaLabel2.TabIndex = 132;
            this.gunaLabel2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(671, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 135;
            this.label1.Text = "Tên khách hàng";
            // 
            // NameText
            // 
            this.NameText.AccessibleName = "";
            this.NameText.BackColor = System.Drawing.Color.Transparent;
            this.NameText.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameText.BorderRadius = 8;
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.DefaultText = "";
            this.NameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.DisabledState.Parent = this.NameText;
            this.NameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.FocusedState.Parent = this.NameText;
            this.NameText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.HoverState.Parent = this.NameText;
            this.NameText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.NameText.IconRight = ((System.Drawing.Image)(resources.GetObject("NameText.IconRight")));
            this.NameText.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.NameText.IconRightSize = new System.Drawing.Size(30, 30);
            this.NameText.Location = new System.Drawing.Point(654, 298);
            this.NameText.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.PlaceholderText = "";
            this.NameText.SelectedText = "";
            this.NameText.ShadowDecoration.Parent = this.NameText;
            this.NameText.Size = new System.Drawing.Size(412, 44);
            this.NameText.TabIndex = 134;
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(0, -5);
            this.guna2Button7.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button7.Location = new System.Drawing.Point(20, 256);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(208, 110);
            this.guna2Button7.TabIndex = 133;
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(41, 120);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(87, 19);
            this.gunaLabel3.TabIndex = 152;
            this.gunaLabel3.Text = "Ngày sinh";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(20, 133);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(318, 44);
            this.guna2DateTimePicker1.TabIndex = 153;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // NhanVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 848);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.DanhMuc);
            this.Controls.Add(this.ThuongHieu);
            this.Controls.Add(this.MaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dgvNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVienUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanVienUI_FormClosing);
            this.Load += new System.EventHandler(this.NhanVienUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvNhanVien;
        private Guna.UI.WinForms.GunaButton ReadButton;
        private Guna.UI.WinForms.GunaButton AddButton;
        private Guna.UI.WinForms.GunaButton RemoveButton;
        private Guna.UI.WinForms.GunaButton UpdateButton;
        private Guna.UI.WinForms.GunaButton ReloadButton;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox TenSP;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox SoLuong;
        private Guna.UI2.WinForms.Guna2TextBox DanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox ThuongHieu;
        private Guna.UI2.WinForms.Guna2TextBox MaSP;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox NameText;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}