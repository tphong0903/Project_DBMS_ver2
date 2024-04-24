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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.MaNhaCungCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.TenNhaCungCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaBienLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ngay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MBL = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.LabelSoBienLai = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.tick = new Guna.UI.WinForms.GunaMediumCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBienLai
            // 
            this.dgvBienLai.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvBienLai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBienLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBienLai.BackgroundColor = System.Drawing.Color.White;
            this.dgvBienLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBienLai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBienLai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBienLai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBienLai.ColumnHeadersHeight = 30;
            this.dgvBienLai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBL,
            this.MaNCC,
            this.PhoneNumber,
            this.TongTien,
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBienLai.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBienLai.EnableHeadersVisualStyles = false;
            this.dgvBienLai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvBienLai.Location = new System.Drawing.Point(12, 373);
            this.dgvBienLai.MultiSelect = false;
            this.dgvBienLai.Name = "dgvBienLai";
            this.dgvBienLai.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBienLai.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBienLai.RowHeadersVisible = false;
            this.dgvBienLai.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvBienLai.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            this.gunaLabel3.Size = new System.Drawing.Size(120, 16);
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
            this.ngayNhap.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel9.Location = new System.Drawing.Point(409, 9);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(170, 22);
            this.gunaLabel9.TabIndex = 195;
            this.gunaLabel9.Text = "Thông tin biên lai";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(624, 120);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(77, 16);
            this.gunaLabel6.TabIndex = 189;
            this.gunaLabel6.Text = "Tổng tiền ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(772, 50);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(130, 16);
            this.gunaLabel5.TabIndex = 188;
            this.gunaLabel5.Text = "Tên nhà cung cấp";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(397, 49);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(126, 16);
            this.gunaLabel7.TabIndex = 186;
            this.gunaLabel7.Text = "Mã nhà cung cấp";
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.AutoScroll = true;
            this.MaNhaCungCap.BorderRadius = 10;
            this.MaNhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaNhaCungCap.DefaultText = "";
            this.MaNhaCungCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaNhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaNhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaNhaCungCap.DisabledState.Parent = this.MaNhaCungCap;
            this.MaNhaCungCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaNhaCungCap.FocusedState.Parent = this.MaNhaCungCap;
            this.MaNhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaNhaCungCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaNhaCungCap.HoverState.Parent = this.MaNhaCungCap;
            this.MaNhaCungCap.Location = new System.Drawing.Point(376, 62);
            this.MaNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.PasswordChar = '\0';
            this.MaNhaCungCap.PlaceholderText = "";
            this.MaNhaCungCap.SelectedText = "";
            this.MaNhaCungCap.ShadowDecoration.Parent = this.MaNhaCungCap;
            this.MaNhaCungCap.Size = new System.Drawing.Size(337, 44);
            this.MaNhaCungCap.TabIndex = 191;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel8.Location = new System.Drawing.Point(38, 50);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(82, 16);
            this.gunaLabel8.TabIndex = 185;
            this.gunaLabel8.Text = "Mã biên lai";
            // 
            // Total
            // 
            this.Total.BorderRadius = 10;
            this.Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Total.DefaultText = "";
            this.Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.DisabledState.Parent = this.Total;
            this.Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.FocusedState.Parent = this.Total;
            this.Total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.HoverState.Parent = this.Total;
            this.Total.Location = new System.Drawing.Point(600, 133);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.PasswordChar = '\0';
            this.Total.PlaceholderText = "";
            this.Total.SelectedText = "";
            this.Total.ShadowDecoration.Parent = this.Total;
            this.Total.Size = new System.Drawing.Size(337, 44);
            this.Total.TabIndex = 194;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.BorderRadius = 10;
            this.TenNhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenNhaCungCap.DefaultText = "";
            this.TenNhaCungCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TenNhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TenNhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenNhaCungCap.DisabledState.Parent = this.TenNhaCungCap;
            this.TenNhaCungCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenNhaCungCap.FocusedState.Parent = this.TenNhaCungCap;
            this.TenNhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenNhaCungCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenNhaCungCap.HoverState.Parent = this.TenNhaCungCap;
            this.TenNhaCungCap.Location = new System.Drawing.Point(748, 62);
            this.TenNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.PasswordChar = '\0';
            this.TenNhaCungCap.PlaceholderText = "";
            this.TenNhaCungCap.SelectedText = "";
            this.TenNhaCungCap.ShadowDecoration.Parent = this.TenNhaCungCap;
            this.TenNhaCungCap.Size = new System.Drawing.Size(337, 44);
            this.TenNhaCungCap.TabIndex = 193;
            // 
            // MaBienLai
            // 
            this.MaBienLai.BorderRadius = 10;
            this.MaBienLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaBienLai.DefaultText = "";
            this.MaBienLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaBienLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaBienLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaBienLai.DisabledState.Parent = this.MaBienLai;
            this.MaBienLai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaBienLai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaBienLai.FocusedState.Parent = this.MaBienLai;
            this.MaBienLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaBienLai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaBienLai.HoverState.Parent = this.MaBienLai;
            this.MaBienLai.Location = new System.Drawing.Point(17, 62);
            this.MaBienLai.Margin = new System.Windows.Forms.Padding(4);
            this.MaBienLai.Name = "MaBienLai";
            this.MaBienLai.PasswordChar = '\0';
            this.MaBienLai.PlaceholderText = "";
            this.MaBienLai.SelectedText = "";
            this.MaBienLai.ShadowDecoration.Parent = this.MaBienLai;
            this.MaBienLai.Size = new System.Drawing.Size(318, 44);
            this.MaBienLai.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(657, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
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
            this.Ngay.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(251, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 181;
            this.label2.Text = "Mã biên lai";
            // 
            // MBL
            // 
            this.MBL.AccessibleName = "";
            this.MBL.BackColor = System.Drawing.Color.Transparent;
            this.MBL.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MBL.BorderRadius = 8;
            this.MBL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MBL.DefaultText = "";
            this.MBL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MBL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MBL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MBL.DisabledState.Parent = this.MBL;
            this.MBL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MBL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MBL.FocusedState.Parent = this.MBL;
            this.MBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MBL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MBL.HoverState.Parent = this.MBL;
            this.MBL.IconLeftSize = new System.Drawing.Size(30, 30);
            this.MBL.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.MBL.IconRightSize = new System.Drawing.Size(30, 30);
            this.MBL.Location = new System.Drawing.Point(235, 299);
            this.MBL.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.MBL.Name = "MBL";
            this.MBL.PasswordChar = '\0';
            this.MBL.PlaceholderText = "";
            this.MBL.SelectedText = "";
            this.MBL.ShadowDecoration.Parent = this.MBL;
            this.MBL.Size = new System.Drawing.Size(389, 44);
            this.MBL.TabIndex = 180;
            this.MBL.TextChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(66, 330);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 22);
            this.gunaLabel1.TabIndex = 177;
            this.gunaLabel1.Text = "Biên lai";
            // 
            // LabelSoBienLai
            // 
            this.LabelSoBienLai.AutoSize = true;
            this.LabelSoBienLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.LabelSoBienLai.CausesValidation = false;
            this.LabelSoBienLai.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelSoBienLai.ForeColor = System.Drawing.Color.Black;
            this.LabelSoBienLai.Location = new System.Drawing.Point(89, 279);
            this.LabelSoBienLai.Name = "LabelSoBienLai";
            this.LabelSoBienLai.Size = new System.Drawing.Size(32, 35);
            this.LabelSoBienLai.TabIndex = 178;
            this.LabelSoBienLai.Text = "0";
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
            this.Controls.Add(this.MaNhaCungCap);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TenNhaCungCap);
            this.Controls.Add(this.MaBienLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MBL);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.LabelSoBienLai);
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
        private Guna.UI2.WinForms.Guna2TextBox MaNhaCungCap;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox Total;
        private Guna.UI2.WinForms.Guna2TextBox TenNhaCungCap;
        private Guna.UI2.WinForms.Guna2TextBox MaBienLai;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Ngay;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox MBL;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel LabelSoBienLai;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI.WinForms.GunaMediumCheckBox tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}