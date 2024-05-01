namespace Project_ver1.UI.Detail
{
    partial class TaoKHForm
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
            Guna.UI.WinForms.GunaLabel gunaLabel8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoKHForm));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPoint = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboGT = new Guna.UI2.WinForms.Guna2ComboBox();
            gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel8
            // 
            gunaLabel8.AutoSize = true;
            gunaLabel8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            gunaLabel8.Location = new System.Drawing.Point(32, 71);
            gunaLabel8.Name = "gunaLabel8";
            gunaLabel8.Size = new System.Drawing.Size(112, 19);
            gunaLabel8.TabIndex = 132;
            gunaLabel8.Text = "Số điện thoại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(-113, 252);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(87, 19);
            this.gunaLabel3.TabIndex = 134;
            this.gunaLabel3.Text = "Ngày sinh";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.dtpBirthday.BorderRadius = 10;
            this.dtpBirthday.BorderThickness = 1;
            this.dtpBirthday.CheckedState.Parent = this.dtpBirthday;
            this.dtpBirthday.FillColor = System.Drawing.Color.White;
            this.dtpBirthday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.HoverState.Parent = this.dtpBirthday;
            this.dtpBirthday.Location = new System.Drawing.Point(11, 222);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.ShadowDecoration.Parent = this.dtpBirthday;
            this.dtpBirthday.Size = new System.Drawing.Size(337, 44);
            this.dtpBirthday.TabIndex = 144;
            this.dtpBirthday.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel9.Location = new System.Drawing.Point(261, 18);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(259, 27);
            this.gunaLabel9.TabIndex = 143;
            this.gunaLabel9.Text = "Thông tin khách hàng";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(443, 209);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(197, 19);
            this.gunaLabel6.TabIndex = 137;
            this.gunaLabel6.Text = "Tổng tiền đã thanh toán";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(443, 139);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(77, 19);
            this.gunaLabel5.TabIndex = 136;
            this.gunaLabel5.Text = "Giới tính";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(440, 70);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(113, 19);
            this.gunaLabel4.TabIndex = 135;
            this.gunaLabel4.Text = "Điểm thưởng";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.Location = new System.Drawing.Point(32, 138);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(134, 19);
            this.gunaLabel7.TabIndex = 133;
            this.gunaLabel7.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.AutoScroll = true;
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(11, 151);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(337, 44);
            this.txtName.TabIndex = 139;
            // 
            // txtPoint
            // 
            this.txtPoint.BorderRadius = 10;
            this.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.DefaultText = "0";
            this.txtPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.DisabledState.Parent = this.txtPoint;
            this.txtPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.Enabled = false;
            this.txtPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.FocusedState.Parent = this.txtPoint;
            this.txtPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.HoverState.Parent = this.txtPoint;
            this.txtPoint.Location = new System.Drawing.Point(419, 83);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.PasswordChar = '\0';
            this.txtPoint.PlaceholderText = "";
            this.txtPoint.SelectedText = "";
            this.txtPoint.SelectionStart = 1;
            this.txtPoint.ShadowDecoration.Parent = this.txtPoint;
            this.txtPoint.Size = new System.Drawing.Size(337, 44);
            this.txtPoint.TabIndex = 140;
            // 
            // txtSdt
            // 
            this.txtSdt.BorderRadius = 10;
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.DefaultText = "";
            this.txtSdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.DisabledState.Parent = this.txtSdt;
            this.txtSdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.FocusedState.Parent = this.txtSdt;
            this.txtSdt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.HoverState.Parent = this.txtSdt;
            this.txtSdt.Location = new System.Drawing.Point(11, 83);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PasswordChar = '\0';
            this.txtSdt.PlaceholderText = "";
            this.txtSdt.SelectedText = "";
            this.txtSdt.ShadowDecoration.Parent = this.txtSdt;
            this.txtSdt.Size = new System.Drawing.Size(337, 44);
            this.txtSdt.TabIndex = 138;
            // 
            // SaveButton
            // 
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SaveButton.BorderColor = System.Drawing.Color.White;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Image = null;
            this.SaveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButton.Location = new System.Drawing.Point(649, 273);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Radius = 15;
            this.SaveButton.Size = new System.Drawing.Size(107, 49);
            this.SaveButton.TabIndex = 145;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(32, 207);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(87, 19);
            this.gunaLabel1.TabIndex = 146;
            this.gunaLabel1.Text = "Ngày sinh";
            // 
            // Total
            // 
            this.Total.BorderRadius = 10;
            this.Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Total.DefaultText = "0";
            this.Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.DisabledState.Parent = this.Total;
            this.Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.Enabled = false;
            this.Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.FocusedState.Parent = this.Total;
            this.Total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.HoverState.Parent = this.Total;
            this.Total.Location = new System.Drawing.Point(419, 222);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.PasswordChar = '\0';
            this.Total.PlaceholderText = "";
            this.Total.SelectedText = "";
            this.Total.SelectionStart = 1;
            this.Total.ShadowDecoration.Parent = this.Total;
            this.Total.Size = new System.Drawing.Size(337, 44);
            this.Total.TabIndex = 142;
            // 
            // ComboGT
            // 
            this.ComboGT.BackColor = System.Drawing.Color.Transparent;
            this.ComboGT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComboGT.BorderRadius = 10;
            this.ComboGT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGT.FocusedColor = System.Drawing.Color.Empty;
            this.ComboGT.FocusedState.Parent = this.ComboGT;
            this.ComboGT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ComboGT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboGT.FormattingEnabled = true;
            this.ComboGT.HoverState.Parent = this.ComboGT;
            this.ComboGT.ItemHeight = 35;
            this.ComboGT.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.ComboGT.ItemsAppearance.Parent = this.ComboGT;
            this.ComboGT.Location = new System.Drawing.Point(416, 151);
            this.ComboGT.Name = "ComboGT";
            this.ComboGT.ShadowDecoration.Parent = this.ComboGT;
            this.ComboGT.Size = new System.Drawing.Size(340, 41);
            this.ComboGT.TabIndex = 191;
            // 
            // TaoKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 340);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(gunaLabel8);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.ComboGT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaoKHForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoKHForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPoint;
        private Guna.UI2.WinForms.Guna2TextBox txtSdt;
        private Guna.UI.WinForms.GunaButton SaveButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox Total;
        private Guna.UI2.WinForms.Guna2ComboBox ComboGT;
    }
}