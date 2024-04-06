namespace Project_ver1.UI.UserControl
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCustom = new Guna.UI2.WinForms.Guna2Button();
            this.Btn7Date = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast30 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThisMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnOKDate = new Guna.UI2.WinForms.Guna2Button();
            this.SLDH = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalRe = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalPro = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.chartGross = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SLKH = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.SLSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.SLDonHang = new Guna.UI.WinForms.GunaLabel();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.SLNCC = new Guna.UI.WinForms.GunaLabel();
            this.SLSPham = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUnderstock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartGross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(60, 17);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(139, 19);
            this.gunaLabel3.TabIndex = 198;
            this.gunaLabel3.Text = "Ngày thanh toán";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpStartDate.BorderRadius = 10;
            this.dtpStartDate.BorderThickness = 1;
            this.dtpStartDate.CheckedState.Parent = this.dtpStartDate;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.HoverState.Parent = this.dtpStartDate;
            this.dtpStartDate.Location = new System.Drawing.Point(39, 30);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShadowDecoration.Parent = this.dtpStartDate;
            this.dtpStartDate.Size = new System.Drawing.Size(192, 44);
            this.dtpStartDate.TabIndex = 199;
            this.dtpStartDate.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(258, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 19);
            this.gunaLabel1.TabIndex = 200;
            this.gunaLabel1.Text = "Ngày thanh toán";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpEndDate.BorderRadius = 10;
            this.dtpEndDate.BorderThickness = 1;
            this.dtpEndDate.CheckedState.Parent = this.dtpEndDate;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.HoverState.Parent = this.dtpEndDate;
            this.dtpEndDate.Location = new System.Drawing.Point(237, 29);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShadowDecoration.Parent = this.dtpEndDate;
            this.dtpEndDate.Size = new System.Drawing.Size(197, 44);
            this.dtpEndDate.TabIndex = 201;
            this.dtpEndDate.Value = new System.DateTime(2024, 3, 29, 7, 43, 2, 28);
            // 
            // btnCustom
            // 
            this.btnCustom.CheckedState.Parent = this.btnCustom;
            this.btnCustom.CustomImages.Parent = this.btnCustom;
            this.btnCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustom.ForeColor = System.Drawing.Color.White;
            this.btnCustom.HoverState.Parent = this.btnCustom;
            this.btnCustom.Location = new System.Drawing.Point(542, 29);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.ShadowDecoration.Parent = this.btnCustom;
            this.btnCustom.Size = new System.Drawing.Size(126, 45);
            this.btnCustom.TabIndex = 202;
            this.btnCustom.Text = "Tùy chỉnh";
            this.btnCustom.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // Btn7Date
            // 
            this.Btn7Date.CheckedState.Parent = this.Btn7Date;
            this.Btn7Date.CustomImages.Parent = this.Btn7Date;
            this.Btn7Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn7Date.ForeColor = System.Drawing.Color.White;
            this.Btn7Date.HoverState.Parent = this.Btn7Date;
            this.Btn7Date.Location = new System.Drawing.Point(674, 29);
            this.Btn7Date.Name = "Btn7Date";
            this.Btn7Date.ShadowDecoration.Parent = this.Btn7Date;
            this.Btn7Date.Size = new System.Drawing.Size(126, 45);
            this.Btn7Date.TabIndex = 203;
            this.Btn7Date.Text = "7 ngày";
            this.Btn7Date.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30
            // 
            this.btnLast30.CheckedState.Parent = this.btnLast30;
            this.btnLast30.CustomImages.Parent = this.btnLast30;
            this.btnLast30.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLast30.ForeColor = System.Drawing.Color.White;
            this.btnLast30.HoverState.Parent = this.btnLast30;
            this.btnLast30.Location = new System.Drawing.Point(806, 29);
            this.btnLast30.Name = "btnLast30";
            this.btnLast30.ShadowDecoration.Parent = this.btnLast30;
            this.btnLast30.Size = new System.Drawing.Size(126, 45);
            this.btnLast30.TabIndex = 204;
            this.btnLast30.Text = "30 ngày ";
            this.btnLast30.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.CheckedState.Parent = this.btnThisMonth;
            this.btnThisMonth.CustomImages.Parent = this.btnThisMonth;
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThisMonth.ForeColor = System.Drawing.Color.White;
            this.btnThisMonth.HoverState.Parent = this.btnThisMonth;
            this.btnThisMonth.Location = new System.Drawing.Point(938, 28);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.ShadowDecoration.Parent = this.btnThisMonth;
            this.btnThisMonth.Size = new System.Drawing.Size(126, 45);
            this.btnThisMonth.TabIndex = 205;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnOKDate
            // 
            this.btnOKDate.CheckedState.Parent = this.btnOKDate;
            this.btnOKDate.CustomImages.Parent = this.btnOKDate;
            this.btnOKDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOKDate.ForeColor = System.Drawing.Color.White;
            this.btnOKDate.HoverState.Parent = this.btnOKDate;
            this.btnOKDate.Location = new System.Drawing.Point(476, 30);
            this.btnOKDate.Name = "btnOKDate";
            this.btnOKDate.ShadowDecoration.Parent = this.btnOKDate;
            this.btnOKDate.Size = new System.Drawing.Size(60, 45);
            this.btnOKDate.TabIndex = 206;
            this.btnOKDate.Text = "OK";
            this.btnOKDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // SLDH
            // 
            this.SLDH.AutoSize = true;
            this.SLDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLDH.CausesValidation = false;
            this.SLDH.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLDH.ForeColor = System.Drawing.Color.Black;
            this.SLDH.Location = new System.Drawing.Point(100, 110);
            this.SLDH.Name = "SLDH";
            this.SLDH.Size = new System.Drawing.Size(40, 44);
            this.SLDH.TabIndex = 209;
            this.SLDH.Text = "0";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(80, 155);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(123, 27);
            this.gunaLabel2.TabIndex = 208;
            this.gunaLabel2.Text = "Sản Phẩm";
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
            this.guna2Button7.Location = new System.Drawing.Point(39, 81);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(192, 110);
            this.guna2Button7.TabIndex = 207;
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lbTotalRe
            // 
            this.lbTotalRe.AutoSize = true;
            this.lbTotalRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.lbTotalRe.CausesValidation = false;
            this.lbTotalRe.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalRe.ForeColor = System.Drawing.Color.Black;
            this.lbTotalRe.Location = new System.Drawing.Point(300, 110);
            this.lbTotalRe.Name = "lbTotalRe";
            this.lbTotalRe.Size = new System.Drawing.Size(40, 44);
            this.lbTotalRe.TabIndex = 212;
            this.lbTotalRe.Text = "0";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(280, 155);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(123, 27);
            this.gunaLabel5.TabIndex = 211;
            this.gunaLabel5.Text = "Sản Phẩm";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(0, -5);
            this.guna2Button1.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button1.Location = new System.Drawing.Point(239, 81);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(344, 110);
            this.guna2Button1.TabIndex = 210;
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lbTotalPro
            // 
            this.lbTotalPro.AutoSize = true;
            this.lbTotalPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.lbTotalPro.CausesValidation = false;
            this.lbTotalPro.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalPro.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPro.Location = new System.Drawing.Point(652, 110);
            this.lbTotalPro.Name = "lbTotalPro";
            this.lbTotalPro.Size = new System.Drawing.Size(40, 44);
            this.lbTotalPro.TabIndex = 215;
            this.lbTotalPro.Text = "0";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(632, 155);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(123, 27);
            this.gunaLabel7.TabIndex = 214;
            this.gunaLabel7.Text = "Sản Phẩm";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(0, -5);
            this.guna2Button2.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button2.Location = new System.Drawing.Point(591, 81);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(473, 110);
            this.guna2Button2.TabIndex = 213;
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // chartGross
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGross.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartGross.Legends.Add(legend1);
            this.chartGross.Location = new System.Drawing.Point(39, 198);
            this.chartGross.Name = "chartGross";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGross.Series.Add(series1);
            this.chartGross.Size = new System.Drawing.Size(653, 300);
            this.chartGross.TabIndex = 216;
            this.chartGross.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Doanh thu";
            this.chartGross.Titles.Add(title1);
            // 
            // chartProduct
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 15;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartProduct.Legends.Add(legend2);
            this.chartProduct.Location = new System.Drawing.Point(698, 198);
            this.chartProduct.Name = "chartProduct";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chartProduct.Series.Add(series2);
            this.chartProduct.Size = new System.Drawing.Size(366, 599);
            this.chartProduct.TabIndex = 217;
            this.chartProduct.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Top Seller";
            this.chartProduct.Titles.Add(title2);
            // 
            // SLKH
            // 
            this.SLKH.AutoSize = true;
            this.SLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLKH.CausesValidation = false;
            this.SLKH.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLKH.ForeColor = System.Drawing.Color.Black;
            this.SLKH.Location = new System.Drawing.Point(56, 562);
            this.SLKH.Name = "SLKH";
            this.SLKH.Size = new System.Drawing.Size(40, 44);
            this.SLKH.TabIndex = 220;
            this.SLKH.Text = "0";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.Location = new System.Drawing.Point(47, 505);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(70, 27);
            this.gunaLabel9.TabIndex = 219;
            this.gunaLabel9.Text = "Tổng";
            // 
            // SLSanPham
            // 
            this.SLSanPham.BorderRadius = 10;
            this.SLSanPham.CheckedState.Parent = this.SLSanPham;
            this.SLSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SLSanPham.CustomImages.Parent = this.SLSanPham;
            this.SLSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLSanPham.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLSanPham.ForeColor = System.Drawing.Color.Black;
            this.SLSanPham.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLSanPham.HoverState.Parent = this.SLSanPham;
            this.SLSanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SLSanPham.ImageOffset = new System.Drawing.Point(0, -5);
            this.SLSanPham.ImageSize = new System.Drawing.Size(60, 60);
            this.SLSanPham.Location = new System.Drawing.Point(39, 505);
            this.SLSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.SLSanPham.Name = "SLSanPham";
            this.SLSanPham.ShadowDecoration.Parent = this.SLSanPham;
            this.SLSanPham.Size = new System.Drawing.Size(224, 292);
            this.SLSanPham.TabIndex = 218;
            this.SLSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SLSanPham.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // SLDonHang
            // 
            this.SLDonHang.AutoSize = true;
            this.SLDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLDonHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLDonHang.ForeColor = System.Drawing.Color.Black;
            this.SLDonHang.Location = new System.Drawing.Point(48, 541);
            this.SLDonHang.Name = "SLDonHang";
            this.SLDonHang.Size = new System.Drawing.Size(196, 21);
            this.SLDonHang.TabIndex = 221;
            this.SLDonHang.Text = "Số lượng khách hàng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.label.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(48, 606);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(212, 21);
            this.label.TabIndex = 222;
            this.label.Text = "Số lượng nhà cung cấp";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(48, 671);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(181, 21);
            this.gunaLabel11.TabIndex = 223;
            this.gunaLabel11.Text = "Số lượng sản phẩm";
            // 
            // SLNCC
            // 
            this.SLNCC.AutoSize = true;
            this.SLNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLNCC.CausesValidation = false;
            this.SLNCC.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLNCC.ForeColor = System.Drawing.Color.Black;
            this.SLNCC.Location = new System.Drawing.Point(56, 627);
            this.SLNCC.Name = "SLNCC";
            this.SLNCC.Size = new System.Drawing.Size(40, 44);
            this.SLNCC.TabIndex = 224;
            this.SLNCC.Text = "0";
            // 
            // SLSPham
            // 
            this.SLSPham.AutoSize = true;
            this.SLSPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.SLSPham.CausesValidation = false;
            this.SLSPham.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLSPham.ForeColor = System.Drawing.Color.Black;
            this.SLSPham.Location = new System.Drawing.Point(56, 692);
            this.SLSPham.Name = "SLSPham";
            this.SLSPham.Size = new System.Drawing.Size(40, 44);
            this.SLSPham.TabIndex = 225;
            this.SLSPham.Text = "0";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(0, -5);
            this.guna2Button3.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button3.Location = new System.Drawing.Point(271, 505);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(420, 292);
            this.guna2Button3.TabIndex = 226;
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // dgvUnderstock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnderstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnderstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnderstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnderstock.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnderstock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnderstock.EnableHeadersVisualStyles = false;
            this.dgvUnderstock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.Location = new System.Drawing.Point(285, 541);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersVisible = false;
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.RowTemplate.Height = 24;
            this.dgvUnderstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnderstock.Size = new System.Drawing.Size(395, 248);
            this.dgvUnderstock.TabIndex = 227;
            this.dgvUnderstock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUnderstock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnderstock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnderstock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUnderstock.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUnderstock.ThemeStyle.ReadOnly = false;
            this.dgvUnderstock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderstock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnderstock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUnderstock.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUnderstock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(179)))));
            this.gunaLabel8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(280, 511);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(273, 27);
            this.gunaLabel8.TabIndex = 228;
            this.gunaLabel8.Text = "Sản phẩm sắp hết hàng";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 801);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.dgvUnderstock);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.SLSPham);
            this.Controls.Add(this.SLNCC);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SLDonHang);
            this.Controls.Add(this.SLKH);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.SLSanPham);
            this.Controls.Add(this.chartProduct);
            this.Controls.Add(this.chartGross);
            this.Controls.Add(this.lbTotalPro);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.lbTotalRe);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.SLDH);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.btnOKDate);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnLast30);
            this.Controls.Add(this.Btn7Date);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.dtpStartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.chartGross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnCustom;
        private Guna.UI2.WinForms.Guna2Button Btn7Date;
        private Guna.UI2.WinForms.Guna2Button btnLast30;
        private Guna.UI2.WinForms.Guna2Button btnThisMonth;
        private Guna.UI2.WinForms.Guna2Button btnOKDate;
        private Guna.UI.WinForms.GunaLabel SLDH;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI.WinForms.GunaLabel lbTotalRe;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI.WinForms.GunaLabel lbTotalPro;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGross;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private Guna.UI.WinForms.GunaLabel SLKH;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI2.WinForms.Guna2Button SLSanPham;
        private Guna.UI.WinForms.GunaLabel SLDonHang;
        private Guna.UI.WinForms.GunaLabel label;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel SLNCC;
        private Guna.UI.WinForms.GunaLabel SLSPham;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUnderstock;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
    }
}