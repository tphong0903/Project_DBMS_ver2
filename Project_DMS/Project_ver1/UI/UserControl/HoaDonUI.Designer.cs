namespace Project_ver1.UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonUI));
            this.dgvHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateButton = new Guna.UI.WinForms.GunaButton();
            this.RemoveButton = new Guna.UI.WinForms.GunaButton();
            this.AddButton = new Guna.UI.WinForms.GunaButton();
            this.ReadButton = new Guna.UI.WinForms.GunaButton();
            this.ReloadButton = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvHoaDon.ColumnHeadersHeight = 30;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.PhoneNumber,
            this.MaNV,
            this.NgayThanhToan,
            this.TongTien,
            this.MaKM});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 373);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1070, 399);
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
            this.UpdateButton.Location = new System.Drawing.Point(862, 787);
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
            this.RemoveButton.Location = new System.Drawing.Point(636, 784);
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
            this.ReadButton.Location = new System.Drawing.Point(749, 787);
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
            this.ReloadButton.TabIndex = 111;
            this.ReloadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(252, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 158;
            this.label2.Text = "Mã hóa đơn";
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
            this.guna2TextBox1.Location = new System.Drawing.Point(236, 296);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(389, 44);
            this.guna2TextBox1.TabIndex = 157;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(41, 313);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(107, 27);
            this.gunaLabel1.TabIndex = 152;
            this.gunaLabel1.Text = "Hóa đơn";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(80, 269);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 44);
            this.gunaLabel2.TabIndex = 153;
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
            this.guna2Button7.Location = new System.Drawing.Point(13, 254);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(208, 110);
            this.guna2Button7.TabIndex = 154;
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(5, 0);
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
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(636, 296);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(361, 44);
            this.guna2DateTimePicker1.TabIndex = 160;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(658, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 161;
            this.label1.Text = "Ngày thanh toán";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 2;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.FlatAppearance.BorderSize = 2;
            this.guna2CheckBox1.Location = new System.Drawing.Point(1016, 313);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(18, 17);
            this.guna2CheckBox1.TabIndex = 162;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(39, 117);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(139, 19);
            this.gunaLabel3.TabIndex = 175;
            this.gunaLabel3.Text = "Ngày thanh toán";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderRadius = 10;
            this.guna2DateTimePicker2.BorderThickness = 1;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(18, 130);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(318, 44);
            this.guna2DateTimePicker2.TabIndex = 176;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel9.Location = new System.Drawing.Point(410, 6);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(220, 27);
            this.gunaLabel9.TabIndex = 173;
            this.gunaLabel9.Text = "Thông tin hóa đơn";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(773, 117);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(88, 19);
            this.gunaLabel6.TabIndex = 167;
            this.gunaLabel6.Text = "Tổng tiền ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(773, 47);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(119, 19);
            this.gunaLabel5.TabIndex = 166;
            this.gunaLabel5.Text = "Tên nhân viên";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(398, 117);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(93, 19);
            this.gunaLabel4.TabIndex = 165;
            this.gunaLabel4.Text = "Chiết khấu";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(398, 46);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(134, 19);
            this.gunaLabel7.TabIndex = 164;
            this.gunaLabel7.Text = "Tên khách hàng";
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
            this.TenSP.Location = new System.Drawing.Point(377, 59);
            this.TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.TenSP.Name = "TenSP";
            this.TenSP.PasswordChar = '\0';
            this.TenSP.PlaceholderText = "";
            this.TenSP.SelectedText = "";
            this.TenSP.ShadowDecoration.Parent = this.TenSP;
            this.TenSP.Size = new System.Drawing.Size(337, 44);
            this.TenSP.TabIndex = 169;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel8.Location = new System.Drawing.Point(39, 47);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(102, 19);
            this.gunaLabel8.TabIndex = 163;
            this.gunaLabel8.Text = "Mã hóa đơn";
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
            this.SoLuong.Location = new System.Drawing.Point(749, 130);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.PasswordChar = '\0';
            this.SoLuong.PlaceholderText = "";
            this.SoLuong.SelectedText = "";
            this.SoLuong.ShadowDecoration.Parent = this.SoLuong;
            this.SoLuong.Size = new System.Drawing.Size(337, 44);
            this.SoLuong.TabIndex = 172;
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
            this.DanhMuc.Location = new System.Drawing.Point(749, 59);
            this.DanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.PasswordChar = '\0';
            this.DanhMuc.PlaceholderText = "";
            this.DanhMuc.SelectedText = "";
            this.DanhMuc.ShadowDecoration.Parent = this.DanhMuc;
            this.DanhMuc.Size = new System.Drawing.Size(337, 44);
            this.DanhMuc.TabIndex = 171;
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
            this.ThuongHieu.Location = new System.Drawing.Point(377, 130);
            this.ThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.PasswordChar = '\0';
            this.ThuongHieu.PlaceholderText = "";
            this.ThuongHieu.SelectedText = "";
            this.ThuongHieu.ShadowDecoration.Parent = this.ThuongHieu;
            this.ThuongHieu.Size = new System.Drawing.Size(337, 44);
            this.ThuongHieu.TabIndex = 170;
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
            this.MaSP.Location = new System.Drawing.Point(18, 59);
            this.MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.MaSP.Name = "MaSP";
            this.MaSP.PasswordChar = '\0';
            this.MaSP.PlaceholderText = "";
            this.MaSP.SelectedText = "";
            this.MaSP.ShadowDecoration.Parent = this.MaSP;
            this.MaSP.Size = new System.Drawing.Size(318, 44);
            this.MaSP.TabIndex = 168;
            // 
            // HoaDonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 848);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.guna2DateTimePicker2);
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
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dgvHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDonUI_FormClosing);
            this.Load += new System.EventHandler(this.HoaDonUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private Guna.UI.WinForms.GunaButton UpdateButton;
        private Guna.UI.WinForms.GunaButton RemoveButton;
        private Guna.UI.WinForms.GunaButton AddButton;
        private Guna.UI.WinForms.GunaButton ReadButton;
        private Guna.UI.WinForms.GunaButton ReloadButton;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
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
    }
}