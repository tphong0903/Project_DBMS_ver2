namespace Project_ver1.UI
{
    partial class BienLaiUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BienLaiUI));
            this.dgvBienLai = new Guna.UI.WinForms.GunaDataGridView();
            this.MaBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadButton = new Guna.UI.WinForms.GunaButton();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.ReloadButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.ngayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.TenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.DanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ngay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.tick = new Guna.UI.WinForms.GunaMediumCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBienLai
            // 
            this.dgvBienLai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvBienLai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBienLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBienLai.BackgroundColor = System.Drawing.Color.White;
            this.dgvBienLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBienLai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBienLai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBienLai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBienLai.ColumnHeadersHeight = 30;
            this.dgvBienLai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBL,
            this.MaNCC,
            this.PhoneNumber,
            this.TongTien,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBienLai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBienLai.EnableHeadersVisualStyles = false;
            this.dgvBienLai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvBienLai.Location = new System.Drawing.Point(12, 373);
            this.dgvBienLai.MultiSelect = false;
            this.dgvBienLai.Name = "dgvBienLai";
            this.dgvBienLai.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBienLai.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBienLai.RowHeadersVisible = false;
            this.dgvBienLai.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvBienLai.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBienLai.RowTemplate.Height = 24;
            this.dgvBienLai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienLai.Size = new System.Drawing.Size(1070, 399);
            this.dgvBienLai.StandardTab = true;
            this.dgvBienLai.TabIndex = 17;
            this.dgvBienLai.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light;
            this.dgvBienLai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvBienLai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBienLai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBienLai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBienLai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBienLai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBienLai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvBienLai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.dgvBienLai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBienLai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvBienLai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBienLai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBienLai.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBienLai.ThemeStyle.ReadOnly = true;
            this.dgvBienLai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBienLai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBienLai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBienLai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBienLai.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBienLai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBienLai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBienLai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // MaBL
            // 
            this.MaBL.DataPropertyName = "Import_ID";
            this.MaBL.HeaderText = "Mã biên lai";
            this.MaBL.MinimumWidth = 6;
            this.MaBL.Name = "MaBL";
            this.MaBL.ReadOnly = true;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "Supplier_ID";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "ImportDay";
            this.PhoneNumber.HeaderText = "Ngày nhập";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Total";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CompanyName";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Visible = false;
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
            this.ReadButton.Location = new System.Drawing.Point(862, 787);
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
            this.AddButton.Location = new System.Drawing.Point(975, 787);
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
            this.ReloadButton.Location = new System.Drawing.Point(12, 787);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.ReloadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ReloadButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.ReloadButton.OnHoverImage = null;
            this.ReloadButton.OnPressedColor = System.Drawing.Color.Black;
            this.ReloadButton.Radius = 15;
            this.ReloadButton.Size = new System.Drawing.Size(107, 49);
            this.ReloadButton.TabIndex = 112;
            this.ReloadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(202, 120);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(139, 19);
            this.gunaLabel3.TabIndex = 196;
            this.gunaLabel3.Text = "Ngày thanh toán";
            // 
            // ngayNhap
            // 
            this.ngayNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ngayNhap.BorderRadius = 10;
            this.ngayNhap.BorderThickness = 1;
            this.ngayNhap.CheckedState.Parent = this.ngayNhap;
            this.ngayNhap.FillColor = System.Drawing.Color.White;
            this.ngayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayNhap.HoverState.Parent = this.ngayNhap;
            this.ngayNhap.Location = new System.Drawing.Point(181, 133);
            this.ngayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.ShadowDecoration.Parent = this.ngayNhap;
            this.ngayNhap.Size = new System.Drawing.Size(318, 44);
            this.ngayNhap.TabIndex = 197;
            this.ngayNhap.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel9.Location = new System.Drawing.Point(409, 9);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(209, 27);
            this.gunaLabel9.TabIndex = 195;
            this.gunaLabel9.Text = "Thông tin biên lai";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(624, 120);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(88, 19);
            this.gunaLabel6.TabIndex = 189;
            this.gunaLabel6.Text = "Tổng tiền ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(772, 50);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(149, 19);
            this.gunaLabel5.TabIndex = 188;
            this.gunaLabel5.Text = "Tên nhà cung cấp";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(397, 49);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(142, 19);
            this.gunaLabel7.TabIndex = 186;
            this.gunaLabel7.Text = "Mã nhà cung cấp";
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
            this.TenSP.Location = new System.Drawing.Point(376, 62);
            this.TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.TenSP.Name = "TenSP";
            this.TenSP.PasswordChar = '\0';
            this.TenSP.PlaceholderText = "";
            this.TenSP.SelectedText = "";
            this.TenSP.ShadowDecoration.Parent = this.TenSP;
            this.TenSP.Size = new System.Drawing.Size(337, 44);
            this.TenSP.TabIndex = 191;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel8.Location = new System.Drawing.Point(38, 50);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(91, 19);
            this.gunaLabel8.TabIndex = 185;
            this.gunaLabel8.Text = "Mã biên lai";
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
            this.SoLuong.Location = new System.Drawing.Point(600, 133);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.PasswordChar = '\0';
            this.SoLuong.PlaceholderText = "";
            this.SoLuong.SelectedText = "";
            this.SoLuong.ShadowDecoration.Parent = this.SoLuong;
            this.SoLuong.Size = new System.Drawing.Size(337, 44);
            this.SoLuong.TabIndex = 194;
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
            this.DanhMuc.Location = new System.Drawing.Point(748, 62);
            this.DanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.PasswordChar = '\0';
            this.DanhMuc.PlaceholderText = "";
            this.DanhMuc.SelectedText = "";
            this.DanhMuc.ShadowDecoration.Parent = this.DanhMuc;
            this.DanhMuc.Size = new System.Drawing.Size(337, 44);
            this.DanhMuc.TabIndex = 193;
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
            this.MaSP.Location = new System.Drawing.Point(17, 62);
            this.MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.MaSP.Name = "MaSP";
            this.MaSP.PasswordChar = '\0';
            this.MaSP.PlaceholderText = "";
            this.MaSP.SelectedText = "";
            this.MaSP.ShadowDecoration.Parent = this.MaSP;
            this.MaSP.Size = new System.Drawing.Size(318, 44);
            this.MaSP.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(657, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 183;
            this.label1.Text = "Ngày thanh toán";
            // 
            // Ngay
            // 
            this.Ngay.BorderRadius = 10;
            this.Ngay.BorderThickness = 1;
            this.Ngay.CheckedState.Parent = this.Ngay;
            this.Ngay.FillColor = System.Drawing.Color.White;
            this.Ngay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngay.HoverState.Parent = this.Ngay;
            this.Ngay.Location = new System.Drawing.Point(635, 299);
            this.Ngay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Ngay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Ngay.Name = "Ngay";
            this.Ngay.ShadowDecoration.Parent = this.Ngay;
            this.Ngay.Size = new System.Drawing.Size(361, 44);
            this.Ngay.TabIndex = 182;
            this.Ngay.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(251, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 181;
            this.label2.Text = "Mã biên lai";
            // 
            // MHD
            // 
            this.MHD.AccessibleName = "";
            this.MHD.BackColor = System.Drawing.Color.Transparent;
            this.MHD.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MHD.BorderRadius = 8;
            this.MHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MHD.DefaultText = "";
            this.MHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MHD.DisabledState.Parent = this.MHD;
            this.MHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MHD.FocusedState.Parent = this.MHD;
            this.MHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MHD.HoverState.Parent = this.MHD;
            this.MHD.IconLeftSize = new System.Drawing.Size(30, 30);
            this.MHD.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.MHD.IconRightSize = new System.Drawing.Size(30, 30);
            this.MHD.Location = new System.Drawing.Point(235, 299);
            this.MHD.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.MHD.Name = "MHD";
            this.MHD.PasswordChar = '\0';
            this.MHD.PlaceholderText = "";
            this.MHD.SelectedText = "";
            this.MHD.ShadowDecoration.Parent = this.MHD;
            this.MHD.Size = new System.Drawing.Size(389, 44);
            this.MHD.TabIndex = 180;
            this.MHD.TextChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(66, 330);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 27);
            this.gunaLabel1.TabIndex = 177;
            this.gunaLabel1.Text = "Biên lai";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(89, 279);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 44);
            this.gunaLabel2.TabIndex = 178;
            this.gunaLabel2.Text = "0";
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
            this.guna2Button7.Location = new System.Drawing.Point(12, 257);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(208, 110);
            this.guna2Button7.TabIndex = 179;
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // tick
            // 
            this.tick.BaseColor = System.Drawing.Color.White;
            this.tick.CheckedOffColor = System.Drawing.Color.Gray;
            this.tick.CheckedOnColor = System.Drawing.Color.Black;
            this.tick.FillColor = System.Drawing.Color.White;
            this.tick.Location = new System.Drawing.Point(1017, 316);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(20, 20);
            this.tick.TabIndex = 198;
            this.tick.CheckedChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // BienLaiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 848);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.ngayNhap);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.DanhMuc);
            this.Controls.Add(this.MaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MHD);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dgvBienLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BienLaiUI";
            this.Text = "BienLaiUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BienLaiUI_FormClosing);
            this.Load += new System.EventHandler(this.BienLaiUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvBienLai;
        private Guna.UI.WinForms.GunaButton ReadButton;
        private Guna.UI.WinForms.GunaButton AddButton;
        private Guna.UI.WinForms.GunaButton ReloadButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngayNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox TenSP;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox SoLuong;
        private Guna.UI2.WinForms.Guna2TextBox DanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox MaSP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Ngay;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox MHD;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI.WinForms.GunaMediumCheckBox tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}