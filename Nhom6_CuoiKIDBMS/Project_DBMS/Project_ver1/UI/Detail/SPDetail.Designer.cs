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
            this.PictureProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.textBoxMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.a = new System.Windows.Forms.DataGridView();
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.imgBtn = new Guna.UI.WinForms.GunaButton();
            this.ComboThuongHieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboDanhMuc = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureProduct
            // 
            this.PictureProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureProduct.Location = new System.Drawing.Point(12, 22);
            this.PictureProduct.Name = "PictureProduct";
            this.PictureProduct.ShadowDecoration.Parent = this.PictureProduct;
            this.PictureProduct.Size = new System.Drawing.Size(236, 304);
            this.PictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProduct.TabIndex = 0;
            this.PictureProduct.TabStop = false;
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
            // textBoxMaSP
            // 
            this.textBoxMaSP.BorderRadius = 10;
            this.textBoxMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaSP.DefaultText = "";
            this.textBoxMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMaSP.DisabledState.Parent = this.textBoxMaSP;
            this.textBoxMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMaSP.FocusedState.Parent = this.textBoxMaSP;
            this.textBoxMaSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMaSP.HoverState.Parent = this.textBoxMaSP;
            this.textBoxMaSP.Location = new System.Drawing.Point(274, 32);
            this.textBoxMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.PasswordChar = '\0';
            this.textBoxMaSP.PlaceholderText = "";
            this.textBoxMaSP.SelectedText = "";
            this.textBoxMaSP.ShadowDecoration.Parent = this.textBoxMaSP;
            this.textBoxMaSP.Size = new System.Drawing.Size(450, 44);
            this.textBoxMaSP.TabIndex = 12;
            // 
            // textBoxTenSP
            // 
            this.textBoxTenSP.AutoScroll = true;
            this.textBoxTenSP.BorderRadius = 10;
            this.textBoxTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTenSP.DefaultText = "";
            this.textBoxTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTenSP.DisabledState.Parent = this.textBoxTenSP;
            this.textBoxTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTenSP.FocusedState.Parent = this.textBoxTenSP;
            this.textBoxTenSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTenSP.HoverState.Parent = this.textBoxTenSP;
            this.textBoxTenSP.Location = new System.Drawing.Point(274, 93);
            this.textBoxTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenSP.Name = "textBoxTenSP";
            this.textBoxTenSP.PasswordChar = '\0';
            this.textBoxTenSP.PlaceholderText = "";
            this.textBoxTenSP.SelectedText = "";
            this.textBoxTenSP.ShadowDecoration.Parent = this.textBoxTenSP;
            this.textBoxTenSP.Size = new System.Drawing.Size(450, 44);
            this.textBoxTenSP.TabIndex = 13;
            // 
            // textBoxGia
            // 
            this.textBoxGia.BorderRadius = 10;
            this.textBoxGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxGia.DefaultText = "";
            this.textBoxGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxGia.DisabledState.Parent = this.textBoxGia;
            this.textBoxGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxGia.FocusedState.Parent = this.textBoxGia;
            this.textBoxGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxGia.HoverState.Parent = this.textBoxGia;
            this.textBoxGia.Location = new System.Drawing.Point(274, 159);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.PasswordChar = '\0';
            this.textBoxGia.PlaceholderText = "";
            this.textBoxGia.SelectedText = "";
            this.textBoxGia.ShadowDecoration.Parent = this.textBoxGia;
            this.textBoxGia.Size = new System.Drawing.Size(450, 44);
            this.textBoxGia.TabIndex = 14;
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
            // ComboThuongHieu
            // 
            this.ComboThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.ComboThuongHieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboThuongHieu.BorderRadius = 10;
            this.ComboThuongHieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboThuongHieu.FocusedColor = System.Drawing.Color.Empty;
            this.ComboThuongHieu.FocusedState.Parent = this.ComboThuongHieu;
            this.ComboThuongHieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ComboThuongHieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboThuongHieu.FormattingEnabled = true;
            this.ComboThuongHieu.HoverState.Parent = this.ComboThuongHieu;
            this.ComboThuongHieu.ItemHeight = 35;
            this.ComboThuongHieu.ItemsAppearance.Parent = this.ComboThuongHieu;
            this.ComboThuongHieu.Location = new System.Drawing.Point(274, 229);
            this.ComboThuongHieu.Name = "ComboThuongHieu";
            this.ComboThuongHieu.ShadowDecoration.Parent = this.ComboThuongHieu;
            this.ComboThuongHieu.Size = new System.Drawing.Size(450, 41);
            this.ComboThuongHieu.TabIndex = 112;
            // 
            // ComboDanhMuc
            // 
            this.ComboDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.ComboDanhMuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboDanhMuc.BorderRadius = 10;
            this.ComboDanhMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDanhMuc.FocusedColor = System.Drawing.Color.Empty;
            this.ComboDanhMuc.FocusedState.Parent = this.ComboDanhMuc;
            this.ComboDanhMuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ComboDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboDanhMuc.FormattingEnabled = true;
            this.ComboDanhMuc.HoverState.Parent = this.ComboDanhMuc;
            this.ComboDanhMuc.ItemHeight = 35;
            this.ComboDanhMuc.ItemsAppearance.Parent = this.ComboDanhMuc;
            this.ComboDanhMuc.Location = new System.Drawing.Point(274, 297);
            this.ComboDanhMuc.Name = "ComboDanhMuc";
            this.ComboDanhMuc.ShadowDecoration.Parent = this.ComboDanhMuc;
            this.ComboDanhMuc.Size = new System.Drawing.Size(450, 41);
            this.ComboDanhMuc.TabIndex = 113;
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
            this.Controls.Add(this.textBoxTenSP);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.imgBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.a);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.textBoxMaSP);
            this.Controls.Add(this.PictureProduct);
            this.Controls.Add(this.ComboThuongHieu);
            this.Controls.Add(this.ComboDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SPDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureProduct;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMaSP;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTenSP;
        private Guna.UI2.WinForms.Guna2TextBox textBoxGia;
        private Guna.UI2.WinForms.Guna2TextBox SoLuong;
        private System.Windows.Forms.DataGridView a;
        private Guna.UI.WinForms.GunaButton SaveButton;
        private Guna.UI.WinForms.GunaButton imgBtn;
        private Guna.UI2.WinForms.Guna2ComboBox ComboThuongHieu;
        private Guna.UI2.WinForms.Guna2ComboBox ComboDanhMuc;
    }
}