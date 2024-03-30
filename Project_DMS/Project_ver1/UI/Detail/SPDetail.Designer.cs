namespace Project_ver1.UI
{
    partial class SPDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPDetail));
            this.PicProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.MaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.TenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gia = new Guna.UI2.WinForms.Guna2TextBox();
            this.ThuongHieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.DanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.a = new System.Windows.Forms.DataGridView();
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.imgBtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // PicProduct
            // 
            this.PicProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicProduct.Location = new System.Drawing.Point(12, 22);
            this.PicProduct.Name = "PicProduct";
            this.PicProduct.ShadowDecoration.Parent = this.PicProduct;
            this.PicProduct.Size = new System.Drawing.Size(236, 304);
            this.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProduct.TabIndex = 0;
            this.PicProduct.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(295, 20);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(112, 19);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Mã sản phẩm";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.Location = new System.Drawing.Point(295, 80);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 19);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Tên sản phẩm";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(295, 147);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(35, 19);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Giá";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(295, 218);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(111, 19);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Thương hiệu";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(295, 288);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(88, 19);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Danh mục";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(295, 350);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(83, 19);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Số lượng";
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
            this.MaSP.Location = new System.Drawing.Point(274, 32);
            this.MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.MaSP.Name = "MaSP";
            this.MaSP.PasswordChar = '\0';
            this.MaSP.PlaceholderText = "";
            this.MaSP.SelectedText = "";
            this.MaSP.ShadowDecoration.Parent = this.MaSP;
            this.MaSP.Size = new System.Drawing.Size(450, 44);
            this.MaSP.TabIndex = 12;
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
            this.TenSP.Location = new System.Drawing.Point(274, 93);
            this.TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.TenSP.Name = "TenSP";
            this.TenSP.PasswordChar = '\0';
            this.TenSP.PlaceholderText = "";
            this.TenSP.SelectedText = "";
            this.TenSP.ShadowDecoration.Parent = this.TenSP;
            this.TenSP.Size = new System.Drawing.Size(450, 44);
            this.TenSP.TabIndex = 13;
            // 
            // Gia
            // 
            this.Gia.BorderRadius = 10;
            this.Gia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gia.DefaultText = "";
            this.Gia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gia.DisabledState.Parent = this.Gia;
            this.Gia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gia.FocusedState.Parent = this.Gia;
            this.Gia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Gia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gia.HoverState.Parent = this.Gia;
            this.Gia.Location = new System.Drawing.Point(274, 159);
            this.Gia.Margin = new System.Windows.Forms.Padding(4);
            this.Gia.Name = "Gia";
            this.Gia.PasswordChar = '\0';
            this.Gia.PlaceholderText = "";
            this.Gia.SelectedText = "";
            this.Gia.ShadowDecoration.Parent = this.Gia;
            this.Gia.Size = new System.Drawing.Size(450, 44);
            this.Gia.TabIndex = 14;
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
            this.ThuongHieu.Location = new System.Drawing.Point(274, 231);
            this.ThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.PasswordChar = '\0';
            this.ThuongHieu.PlaceholderText = "";
            this.ThuongHieu.SelectedText = "";
            this.ThuongHieu.ShadowDecoration.Parent = this.ThuongHieu;
            this.ThuongHieu.Size = new System.Drawing.Size(450, 44);
            this.ThuongHieu.TabIndex = 15;
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
            this.DanhMuc.Location = new System.Drawing.Point(274, 302);
            this.DanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.PasswordChar = '\0';
            this.DanhMuc.PlaceholderText = "";
            this.DanhMuc.SelectedText = "";
            this.DanhMuc.ShadowDecoration.Parent = this.DanhMuc;
            this.DanhMuc.Size = new System.Drawing.Size(450, 44);
            this.DanhMuc.TabIndex = 16;
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
            this.SoLuong.Location = new System.Drawing.Point(274, 364);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.PasswordChar = '\0';
            this.SoLuong.PlaceholderText = "";
            this.SoLuong.SelectedText = "";
            this.SoLuong.ShadowDecoration.Parent = this.SoLuong;
            this.SoLuong.Size = new System.Drawing.Size(450, 44);
            this.SoLuong.TabIndex = 17;
            // 
            // a
            // 
            this.a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.a.Location = new System.Drawing.Point(12, 431);
            this.a.Name = "a";
            this.a.RowHeadersWidth = 51;
            this.a.RowTemplate.Height = 24;
            this.a.Size = new System.Drawing.Size(52, 33);
            this.a.TabIndex = 19;
            this.a.Visible = false;
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
            this.SaveButton.Location = new System.Drawing.Point(586, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Radius = 15;
            this.SaveButton.Size = new System.Drawing.Size(138, 49);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // imgBtn
            // 
            this.imgBtn.AnimationHoverSpeed = 0.07F;
            this.imgBtn.AnimationSpeed = 0.03F;
            this.imgBtn.BackColor = System.Drawing.Color.Transparent;
            this.imgBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.imgBtn.BorderColor = System.Drawing.Color.Black;
            this.imgBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgBtn.FocusedColor = System.Drawing.Color.Empty;
            this.imgBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBtn.ForeColor = System.Drawing.Color.Black;
            this.imgBtn.Image = null;
            this.imgBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imgBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.imgBtn.Location = new System.Drawing.Point(50, 332);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.imgBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.imgBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.imgBtn.OnHoverImage = null;
            this.imgBtn.OnPressedColor = System.Drawing.Color.Black;
            this.imgBtn.Radius = 15;
            this.imgBtn.Size = new System.Drawing.Size(138, 49);
            this.imgBtn.TabIndex = 21;
            this.imgBtn.Text = "Hình ảnh";
            this.imgBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imgBtn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // SPDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 481);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.TenSP);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.imgBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.a);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.DanhMuc);
            this.Controls.Add(this.ThuongHieu);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.MaSP);
            this.Controls.Add(this.PicProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SPDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PicProduct;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox MaSP;
        private Guna.UI2.WinForms.Guna2TextBox TenSP;
        private Guna.UI2.WinForms.Guna2TextBox Gia;
        private Guna.UI2.WinForms.Guna2TextBox ThuongHieu;
        private Guna.UI2.WinForms.Guna2TextBox DanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox SoLuong;
        private System.Windows.Forms.DataGridView a;
        private Guna.UI.WinForms.GunaButton SaveButton;
        private Guna.UI.WinForms.GunaButton imgBtn;
    }
}