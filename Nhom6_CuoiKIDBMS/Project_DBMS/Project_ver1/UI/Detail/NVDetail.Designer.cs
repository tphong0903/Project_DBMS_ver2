namespace Project_ver1.UI
{
    partial class NVDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVDetail));
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.a = new System.Windows.Forms.DataGridView();
            this.textBoxSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.textBoxTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.textBoxDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SaveButton.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Image = null;
            this.SaveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButton.Location = new System.Drawing.Point(644, 347);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Radius = 15;
            this.SaveButton.Size = new System.Drawing.Size(139, 49);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // a
            // 
            this.a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.a.Location = new System.Drawing.Point(13, 347);
            this.a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Name = "a";
            this.a.RowHeadersWidth = 51;
            this.a.RowTemplate.Height = 24;
            this.a.Size = new System.Drawing.Size(52, 33);
            this.a.TabIndex = 35;
            this.a.Visible = false;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.BorderRadius = 10;
            this.textBoxSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSDT.DefaultText = "";
            this.textBoxSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSDT.DisabledState.Parent = this.textBoxSDT;
            this.textBoxSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSDT.FocusedState.Parent = this.textBoxSDT;
            this.textBoxSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSDT.HoverState.Parent = this.textBoxSDT;
            this.textBoxSDT.Location = new System.Drawing.Point(436, 27);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.PasswordChar = '\0';
            this.textBoxSDT.PlaceholderText = "";
            this.textBoxSDT.SelectedText = "";
            this.textBoxSDT.ShadowDecoration.Parent = this.textBoxSDT;
            this.textBoxSDT.Size = new System.Drawing.Size(348, 44);
            this.textBoxSDT.TabIndex = 33;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BorderRadius = 10;
            this.textBoxTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTotal.DefaultText = "";
            this.textBoxTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotal.DisabledState.Parent = this.textBoxTotal;
            this.textBoxTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotal.FocusedState.Parent = this.textBoxTotal;
            this.textBoxTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotal.HoverState.Parent = this.textBoxTotal;
            this.textBoxTotal.Location = new System.Drawing.Point(434, 269);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.PasswordChar = '\0';
            this.textBoxTotal.PlaceholderText = "";
            this.textBoxTotal.SelectedText = "";
            this.textBoxTotal.ShadowDecoration.Parent = this.textBoxTotal;
            this.textBoxTotal.Size = new System.Drawing.Size(348, 44);
            this.textBoxTotal.TabIndex = 32;
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.AutoScroll = true;
            this.textBoxTenNV.BorderRadius = 10;
            this.textBoxTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTenNV.DefaultText = "";
            this.textBoxTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTenNV.DisabledState.Parent = this.textBoxTenNV;
            this.textBoxTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTenNV.FocusedState.Parent = this.textBoxTenNV;
            this.textBoxTenNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTenNV.HoverState.Parent = this.textBoxTenNV;
            this.textBoxTenNV.Location = new System.Drawing.Point(13, 87);
            this.textBoxTenNV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.PasswordChar = '\0';
            this.textBoxTenNV.PlaceholderText = "";
            this.textBoxTenNV.SelectedText = "";
            this.textBoxTenNV.ShadowDecoration.Parent = this.textBoxTenNV;
            this.textBoxTenNV.Size = new System.Drawing.Size(348, 44);
            this.textBoxTenNV.TabIndex = 30;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.BorderRadius = 10;
            this.textBoxMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaNV.DefaultText = "";
            this.textBoxMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMaNV.DisabledState.Parent = this.textBoxMaNV;
            this.textBoxMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMaNV.FocusedState.Parent = this.textBoxMaNV;
            this.textBoxMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMaNV.HoverState.Parent = this.textBoxMaNV;
            this.textBoxMaNV.Location = new System.Drawing.Point(13, 27);
            this.textBoxMaNV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.PasswordChar = '\0';
            this.textBoxMaNV.PlaceholderText = "";
            this.textBoxMaNV.SelectedText = "";
            this.textBoxMaNV.ShadowDecoration.Parent = this.textBoxMaNV;
            this.textBoxMaNV.Size = new System.Drawing.Size(348, 44);
            this.textBoxMaNV.TabIndex = 29;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(454, 73);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(76, 19);
            this.gunaLabel6.TabIndex = 28;
            this.gunaLabel6.Text = "Chức vụ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(454, 13);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(112, 19);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "Số điện thoại";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(453, 259);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(141, 19);
            this.gunaLabel4.TabIndex = 26;
            this.gunaLabel4.Text = "Tổng tiền đã bán";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(32, 201);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(77, 19);
            this.gunaLabel3.TabIndex = 25;
            this.gunaLabel3.Text = "Giới tính";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.Location = new System.Drawing.Point(32, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 19);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "Tên nhân viên";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(32, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(112, 19);
            this.gunaLabel1.TabIndex = 23;
            this.gunaLabel1.Text = "Mã nhân viên";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(454, 135);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(88, 19);
            this.gunaLabel7.TabIndex = 38;
            this.gunaLabel7.Text = "Trạng thái";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel8.Location = new System.Drawing.Point(454, 193);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(80, 19);
            this.gunaLabel8.TabIndex = 39;
            this.gunaLabel8.Text = "Mật khẩu";
            // 
            // textBoxTrangThai
            // 
            this.textBoxTrangThai.BorderRadius = 10;
            this.textBoxTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTrangThai.DefaultText = "";
            this.textBoxTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTrangThai.DisabledState.Parent = this.textBoxTrangThai;
            this.textBoxTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTrangThai.FocusedState.Parent = this.textBoxTrangThai;
            this.textBoxTrangThai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTrangThai.HoverState.Parent = this.textBoxTrangThai;
            this.textBoxTrangThai.Location = new System.Drawing.Point(434, 145);
            this.textBoxTrangThai.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxTrangThai.Name = "textBoxTrangThai";
            this.textBoxTrangThai.PasswordChar = '\0';
            this.textBoxTrangThai.PlaceholderText = "";
            this.textBoxTrangThai.SelectedText = "";
            this.textBoxTrangThai.ShadowDecoration.Parent = this.textBoxTrangThai;
            this.textBoxTrangThai.Size = new System.Drawing.Size(348, 44);
            this.textBoxTrangThai.TabIndex = 40;
            // 
            // textBoxMK
            // 
            this.textBoxMK.BorderRadius = 10;
            this.textBoxMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMK.DefaultText = "";
            this.textBoxMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMK.DisabledState.Parent = this.textBoxMK;
            this.textBoxMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMK.FocusedState.Parent = this.textBoxMK;
            this.textBoxMK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMK.HoverState.Parent = this.textBoxMK;
            this.textBoxMK.Location = new System.Drawing.Point(434, 206);
            this.textBoxMK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.PasswordChar = '\0';
            this.textBoxMK.PlaceholderText = "";
            this.textBoxMK.SelectedText = "";
            this.textBoxMK.ShadowDecoration.Parent = this.textBoxMK;
            this.textBoxMK.Size = new System.Drawing.Size(348, 44);
            this.textBoxMK.TabIndex = 41;
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxGioiTinh.BorderRadius = 10;
            this.comboBoxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxGioiTinh.FocusedState.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.HoverState.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.IntegralHeight = false;
            this.comboBoxGioiTinh.ItemHeight = 40;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.comboBoxGioiTinh.ItemsAppearance.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(12, 213);
            this.comboBoxGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.ShadowDecoration.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(348, 46);
            this.comboBoxGioiTinh.TabIndex = 42;
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxChucVu.BorderRadius = 10;
            this.comboBoxChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChucVu.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxChucVu.FocusedState.Parent = this.comboBoxChucVu;
            this.comboBoxChucVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.HoverState.Parent = this.comboBoxChucVu;
            this.comboBoxChucVu.IntegralHeight = false;
            this.comboBoxChucVu.ItemHeight = 40;
            this.comboBoxChucVu.Items.AddRange(new object[] {
            "Bán hàng",
            "Quản lí"});
            this.comboBoxChucVu.ItemsAppearance.Parent = this.comboBoxChucVu;
            this.comboBoxChucVu.Location = new System.Drawing.Point(436, 86);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.ShadowDecoration.Parent = this.comboBoxChucVu;
            this.comboBoxChucVu.Size = new System.Drawing.Size(348, 46);
            this.comboBoxChucVu.TabIndex = 43;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel9.Location = new System.Drawing.Point(32, 135);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(87, 19);
            this.gunaLabel9.TabIndex = 44;
            this.gunaLabel9.Text = "Ngày sinh";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.dateTimePicker.BorderRadius = 10;
            this.dateTimePicker.BorderThickness = 1;
            this.dateTimePicker.CheckedState.Parent = this.dateTimePicker;
            this.dateTimePicker.FillColor = System.Drawing.Color.White;
            this.dateTimePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.HoverState.Parent = this.dateTimePicker;
            this.dateTimePicker.Location = new System.Drawing.Point(13, 145);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShadowDecoration.Parent = this.dateTimePicker;
            this.dateTimePicker.Size = new System.Drawing.Size(348, 54);
            this.dateTimePicker.TabIndex = 45;
            this.dateTimePicker.Value = new System.DateTime(2024, 3, 22, 21, 10, 19, 800);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel10.Location = new System.Drawing.Point(30, 259);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(62, 19);
            this.gunaLabel10.TabIndex = 46;
            this.gunaLabel10.Text = "Địa chỉ";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BorderRadius = 10;
            this.textBoxDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDiaChi.DefaultText = "";
            this.textBoxDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDiaChi.DisabledState.Parent = this.textBoxDiaChi;
            this.textBoxDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDiaChi.FocusedState.Parent = this.textBoxDiaChi;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDiaChi.HoverState.Parent = this.textBoxDiaChi;
            this.textBoxDiaChi.Location = new System.Drawing.Point(12, 269);
            this.textBoxDiaChi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.PasswordChar = '\0';
            this.textBoxDiaChi.PlaceholderText = "";
            this.textBoxDiaChi.SelectedText = "";
            this.textBoxDiaChi.ShadowDecoration.Parent = this.textBoxDiaChi;
            this.textBoxDiaChi.Size = new System.Drawing.Size(348, 44);
            this.textBoxDiaChi.TabIndex = 47;
            // 
            // NVDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 407);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxChucVu);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTrangThai);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.a);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxTenNV);
            this.Controls.Add(this.textBoxMaNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "NVDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton SaveButton;
        private System.Windows.Forms.DataGridView a;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSDT;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTotal;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTenNV;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMaNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMK;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxGioiTinh;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxChucVu;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDiaChi;
    }
}