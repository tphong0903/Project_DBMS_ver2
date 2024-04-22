use QuanLyBanHangTheThao
go
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'ADD', N'Adidas')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'KMT', N'Kamito')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'KWS', N'Kawasaki')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'LN', N'Lining')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'NIK', N'Nike')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'PKN', N'Prokennex')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'PN', N'PAN')
INSERT [dbo].[Brands] ([Brand_ID], [BrandName]) VALUES (N'YNX', N'Yonex')
GO
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'ACL', N'Áo cầu lông')
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'BĐBĐ', N'Bộ đồ bóng đá')
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'GBĐ', N'Giày bóng đá')
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'GCL', N'Giày cầu lông')
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'PK', N'Phụ kiện')
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'QCL', N'Quần cầu lông')
INSERT [dbo].[Categories] ([Category_ID], [CategoryName]) VALUES (N'VCL', N'Vợt cầu lông')
GO
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0901236767', N'Trần Đức Anh', CAST(N'2009-03-15' AS Date), N'Nam', 256)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0912345678', N'Nguyễn Thị Hương', CAST(N'1997-07-20' AS Date), N'Nu ', 743)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0923455789', N'Lê Văn Nam', CAST(N'1995-09-25' AS Date), N'Nam', 512)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0934586890', N'Phạm Thị Loan', CAST(N'2000-07-20' AS Date), N'Nu ', 899)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0944567901', N'Hoàng Minh Tuấn', CAST(N'2005-04-05' AS Date), N'Nam', 347)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0959839012', N'Vũ Thị Lan Anh', CAST(N'1988-06-12' AS Date), N'Nu ', 631)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0967801423', N'Đặng Xuân Hải', CAST(N'1993-04-05' AS Date), N'Nam', 178)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0978986234', N'Bùi Hồng Loan', CAST(N'2002-10-22' AS Date), N'Nu ', 425)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0989013345', N'Đỗ Quang Huy', CAST(N'1980-12-28' AS Date), N'Nam', 568)
INSERT [dbo].[Customers] ([PhoneNumber], [NameCustomer], [Birthday], [Gender], [Point]) VALUES (N'0990124756', N'Ngô Thị Hà', CAST(N'1978-02-03' AS Date), N'Nu ', 937)
GO
INSERT [dbo].[Discounts] ([DiscountCode], [PercentageDiscount], [StartDay], [EndDay]) VALUES (N'14THANG2', 15, CAST(N'2024-02-10' AS Date), CAST(N'2024-02-15' AS Date))
INSERT [dbo].[Discounts] ([DiscountCode], [PercentageDiscount], [StartDay], [EndDay]) VALUES (N'30THANG4', 25, CAST(N'2024-04-25' AS Date), CAST(N'2024-05-02' AS Date))
INSERT [dbo].[Discounts] ([DiscountCode], [PercentageDiscount], [StartDay], [EndDay]) VALUES (N'8THANG3', 20, CAST(N'2024-03-05' AS Date), CAST(N'2024-03-09' AS Date))
GO
EXEC spInsertEmployee 
    @EmployeeID = N'BH01',
    @NameEmployee = N'Ngô Thị Mai Anh',
    @Birthday = '1985-12-30',
    @Gender = N'Nu',
    @AddressEmployee = N'5 Đường Lê Lợi, Quận 3, TP.HCM',
    @PhoneNumber = N'0918575678',
    @RoleEmployee = N'Bán hàng',
    @Active = N'1',
    @PassWordAccount = N'hahaha';
go
EXEC spInsertEmployee 
    @EmployeeID = N'BH02',
    @NameEmployee = N'Lương Văn Tuấn',
    @Birthday = '1982-09-26',
    @Gender = N'Nam',
    @AddressEmployee = N'125 Đường Phan Xích Long, Quận Phú Nhuận, TP.HCM',
    @PhoneNumber = N'0978545412',
    @RoleEmployee = N'Bán hàng',
    @Active = N'1',
    @PassWordAccount = N'huhuhu';
go
EXEC spInsertEmployee 
    @EmployeeID = N'QL01',
    @NameEmployee = N'Phạm Minh Đức',
    @Birthday = '1980-02-28',
    @Gender = N'Nam',
    @AddressEmployee = N'1 Đường Võ Văn Ngân, TP.Thủ Đức , TP.HCM',
    @PhoneNumber = N'0987612521',
    @RoleEmployee = N'Quản lí',
    @Active = N'1',
    @PassWordAccount = N'123456';

GO

INSERT INTO PictureProduct(Picture_Name)
VALUES('AocaulongYonexDen.jpg'),
		('AocaulongYonexTrang.jpg'),
		('KamitoTienMinhLegend.jpg'),
		('KamitoVTTGowo.jpg'),
		('Kawasaki065Do.jpg'),
		('Kawasaki065Trang.jpg'),
		('LiningAxforce70.jpg'),
		('LiningAxforce80.jpg'),
		('LiningAxforce90.jpg'),
		('LiningChenLongAYZU011-1.jpg'),
		('OngcaulongLining.jpg'),
		('OngcaulongYonex.jpg'),
		('PanPatriotEVOPod TFDo.jpg'),
		('PanPatriotEVOPodTFTrang.jpg'),
		('PanPatriotEVOPodTFVang.jpg'),
		('ProKennexPowerPro705.jpg'),
		('ProKennexThunder7004.jpg'),
		('QuancancaulongLining.jpg'),
		('QuancancaulongYonex.jpg'),
		('YonexAstrox88D2018.jpg'),
		('YonexAstrox88DPro2022.jpg'),
		('YonexAstrox88S2018.jpg'),
		('YonexAstrox88SPro2022.jpg'),
		('YonexAstrox99Navy2020.jpg'),
		('YonexAstrox99Pro2022.jpg'),
		('YonexEclipsionZ3MenNavy.jpg'),
		('YonexSHB65Z3WhiteTiger.jpg'),
		('YonexSHB65Z3WomanNavy.jpg'),
		('AdidasXCrazyfastMessi.jpg'),
		('AobongdaNikekhonglogoDen.jpg'),
		('AobongdaNikekhonglogoTrang.jpg')
go
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'88D2018', N'Yonex Astrox 88D 2018', 6500000, 0, N'YNX', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'88DP2022', N'Yonex Astrox 88D Pro 2022', 4900000, 0, N'YNX', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'88DS2022', N'Yonex Astrox 88S Pro 2022', 4800000, 0, N'YNX', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'88S2018', N'Yonex Astrox 88S 2018', 6400000, 0, N'YNX', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'99NAVY2020', N'Yonex Astrox 99 Navy 2020', 5000000, 0, N'YNX', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'99PRO2022', N'Yonex Astrox 99 Pro 2022', 5500000, 0, N'YNX', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYĐL', N'Áo cầu lông Yonex Đen Size L', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYĐM', N'Áo cầu lông Yonex Đen Size M', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYĐS', N'Áo cầu lông Yonex Đen Size S', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYĐXL', N'Áo cầu lông Yonex Đen Size XL', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYĐXXL', N'Áo cầu lông Yonex Đen Size XXL', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYTL', N'Áo cầu lông Yonex Trắng Size L', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYTM', N'Áo cầu lông Yonex Trắng Size M', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYTS', N'Áo cầu lông Yonex Trắng Size S', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYTXL', N'Áo cầu lông Yonex Trắng Size XL', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ACLYTXXL', N'Áo cầu lông Yonex Trắng Size XXL', 200000, 0, N'YNX', N'ACL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLĐL', N'Áo bóng đá Nike không logo Đen Size L', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLĐM', N'Áo bóng đá Nike không logo Đen Size M', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLĐS', N'Áo bóng đá Nike không logo Đen Size S', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLĐXL', N'Áo bóng đá Nike không logo Đen Size XL', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLĐXXL', N'Áo bóng đá Nike không logo Đen Size XXL', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLTL', N'Áo bóng đá Nike không logo Trắng Size L', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLTM', N'Áo bóng đá Nike không logo Trắng Size M', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLTS', N'Áo bóng đá Nike không logo Trắng Size S', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLTXL', N'Áo bóng đá Nike không logo Trắng Size XL', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'ANKLTXXL', N'Áo bóng đá Nike không logo Trắng Size XXL', 150000, 0, N'NIK', N'BĐBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AX70', N'Lining Axforce 70', 4500000, 0, N'LN', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AX80', N'Lining Axforce 80', 5000000, 0, N'LN', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AX90', N'Lining Axforce 90', 5400000, 0, N'LN', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AXM39', N'Adidas X Crazyfast Messi Size 39', 2000000, 0, N'ADD', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AXM40', N'Adidas X Crazyfast Messi Size 40', 2000000, 0, N'ADD', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AXM41', N'Adidas X Crazyfast Messi Size 41', 2000000, 0, N'ADD', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AXM42', N'Adidas X Crazyfast Messi Size 42', 2000000, 0, N'ADD', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AXM43', N'Adidas X Crazyfast Messi Size 43', 2000000, 0, N'ADD', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'AXM44', N'Adidas X Crazyfast Messi Size 44', 2000000, 0, N'ADD', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KMTTML', N'Kamito Tiến Minh Legend', 2300000, 0, N'KMT', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KMTVTT', N'Kamito VTT Gowo', 1700000, 0, N'KMT', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065Đ39', N'Kawasaki 065 Đỏ Size 39', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065Đ40', N'Kawasaki 065 Đỏ Size 40', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065Đ41', N'Kawasaki 065 Đỏ Size 41', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065Đ42', N'Kawasaki 065 Đỏ Size 42', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065Đ43', N'Kawasaki 065 Đỏ Size 43', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065Đ44', N'Kawasaki 065 Đỏ Size 44', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065T39', N'Kawasaki 065 Trắng Size 39', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065T40', N'Kawasaki 065 Trắng Size 40', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065T41', N'Kawasaki 065 Trắng Size 41', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065T42', N'Kawasaki 065 Trắng Size 42', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065T43', N'Kawasaki 065 Trắng Size 43', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'KWS065T44', N'Kawasaki 065 Trắng Size 44', 800000, 0, N'KWS', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'LCA39', N'Lining ChenLong AYZU011-1 Size 39', 2650000, 0, N'LN', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'LCA40', N'Lining ChenLong AYZU011-1 Size 40', 2650000, 0, N'LN', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'LCA41', N'Lining ChenLong AYZU011-1 Size 41', 2650000, 0, N'LN', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'LCA42', N'Lining ChenLong AYZU011-1 Size 42', 2650000, 0, N'LN', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'LCA43', N'Lining ChenLong AYZU011-1 Size 43', 2650000, 0, N'LN', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'LCA44', N'Lining ChenLong AYZU011-1 Size 44', 2650000, 0, N'LN', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'NGCR39', N'Nike Galaxy CR7 Size 39', 2000000, 0, N'NIK', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'NGCR40', N'Nike Galaxy CR7 Size 40', 2000000, 0, N'NIK', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'NGCR41', N'Nike Galaxy CR7 Size 41', 2000000, 0, N'NIK', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'NGCR42', N'Nike Galaxy CR7 Size 42', 2000000, 0, N'NIK', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'NGCR43', N'Nike Galaxy CR7 Size 43', 2000000, 0, N'NIK', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'NGCR44', N'Nike Galaxy CR7 Size 44', 2000000, 0, N'NIK', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PKPP705', N'Pro Kennex Power Pro 705', 800000,0, N'PKN', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PKT7004', N'Pro Kennex Thunder 7004', 900000, 0, N'PKN', N'VCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP39ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 39', 620000,0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP39TIC', N'Pan Patriot EVO Pod IC Trắng Size 39', 610000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP39TTF', N'Pan Patriot EVO Pod TF Trắng Size 39', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP39VTF', N'Pan Patriot EVO Pod TF Vàng Size 39', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP40ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 40', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP40TIC', N'Pan Patriot EVO Pod IC Trắng Size 40', 610000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP40TTF', N'Pan Patriot EVO Pod TF Trắng Size 40', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP40VTF', N'Pan Patriot EVO Pod TF Vàng Size 40', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP41ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 41', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP41TIC', N'Pan Patriot EVO Pod IC Trắng Size 41', 610000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP41TTF', N'Pan Patriot EVO Pod TF Trắng Size 41', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP41VTF', N'Pan Patriot EVO Pod TF Vàng Size 41', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP42ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 42', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP42TIC', N'Pan Patriot EVO Pod IC Trắng Size 42', 610000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP42TTF', N'Pan Patriot EVO Pod TF Trắng Size 42', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP42VTF', N'Pan Patriot EVO Pod TF Vàng Size 42', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP43ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 43', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP43TIC', N'Pan Patriot EVO Pod IC Trắng Size 43', 610000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP43TTF', N'Pan Patriot EVO Pod TF Trắng Size 43', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP43VTF', N'Pan Patriot EVO Pod TF Vàng Size 43', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP44ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 44', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP44TIC', N'Pan Patriot EVO Pod IC Trắng Size 44', 610000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP44TTF', N'Pan Patriot EVO Pod TF Trắng Size 44', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'PPTEP44VTF', N'Pan Patriot EVO Pod TF Vàng Size 44', 620000, 0, N'PN', N'GBĐ')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'QCCLL', N'Quấn cán cầu lông Lining', 20000, 0, N'LN', N'PK')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'QCCLY', N'Quấn cán cầu lông Yonex', 50000, 0, N'YNX', N'PK')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'QCL', N'Ống cầu lông Lining', 200000, 0, N'LN', N'PK')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'QCY', N'Ống cầu lông Yonex', 1200000, 0, N'YNX', N'PK')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WN39', N'Yonex SHB 65 Z3 Woman Navy Size 39', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WN40', N'Yonex SHB 65 Z3 Woman Navy Size 40', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WN41', N'Yonex SHB 65 Z3 Woman Navy Size 41', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WN42', N'Yonex SHB 65 Z3 Woman Navy Size 42', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WT39', N'Yonex SHB 65 Z3 White Tiger Size 39', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WT40', N'Yonex SHB 65 Z3 White Tiger Size 40', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WT41', N'Yonex SHB 65 Z3 White Tiger Size 41', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WT42', N'Yonex SHB 65 Z3 White Tiger Size 42', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WT43', N'Yonex SHB 65 Z3 White Tiger Size 43', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'Y65Z3WT44', N'Yonex SHB 65 Z3 White Tiger Size 44', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3NAVY39', N'Yonex Eclipsion Z3 Men Navy Size 39', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3NAVY40', N'Yonex Eclipsion Z3 Men Navy Size 40', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3NAVY41', N'Yonex Eclipsion Z3 Men Navy Size 41', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3NAVY42', N'Yonex Eclipsion Z3 Men Navy Size 42', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3NAVY43', N'Yonex Eclipsion Z3 Men Navy Size 43', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3NAVY44', N'Yonex Eclipsion Z3 Men Navy Size 44', 2700000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3WHITE39', N'Yonex Eclipsion Z3 Woman White Size 39', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3WHITE40', N'Yonex Eclipsion Z3 Woman White Size 40', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3WHITE41', N'Yonex Eclipsion Z3 Woman White Size 41', 2600000, 0, N'YNX', N'GCL')
INSERT [dbo].[Products] ([Product_ID], [ProductName], [UnitPrice], [Quantity], [Brand_ID], [Category_ID]) VALUES (N'YEZ3WHITE42', N'Yonex Eclipsion Z3 Woman White Size 42', 2600000, 0, N'YNX', N'GCL')
GO
INSERT [dbo].[Suppliers] ([Supplier_ID], [CompanyName], [PhoneNumber], [AddressSupplier], [Email]) VALUES (N'ATS', N'Anh Thắng Sport', N'0981122234', N'41 Đường C1, P13, Q. Tân Bình, TP Hồ Chí Minh', N'anhthangsport.com')
INSERT [dbo].[Suppliers] ([Supplier_ID], [CompanyName], [PhoneNumber], [AddressSupplier], [Email]) VALUES (N'VNB', N'Vietnam Badminton', N'0977508430', N'20 Cao Bá Nhạ, Phường Nguyễn Cư Trinh, Quận 1, TPHCM', N'info@shopvnb.com')
INSERT [dbo].[Suppliers] ([Supplier_ID], [CompanyName], [PhoneNumber], [AddressSupplier], [Email]) VALUES (N'YNS', N'Yonex Sunrise Vietnam', N'0363609039', N'157 Điện Biên Phủ, Phường Đa Kao, Quận 1, Thành Phố Hồ Chí Minh, Việt Nam', N'sunrisevn@risesun.com.sg')
GO
INSERT INTO Imports (Import_ID, Supplier_ID, ImportDay, Total) VALUES ('NH00001', 'ATS', '2024-01-15', 0)
INSERT INTO Imports (Import_ID, Supplier_ID, ImportDay, Total) VALUES ('NH00002', 'VNB', '2024-01-15', 0)
INSERT INTO Imports (Import_ID, Supplier_ID, ImportDay, Total) VALUES ('NH00003', 'YNS', '2024-01-15',0);
GO
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'KWS065T39', 13, 700000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'LCA40', 9, 2450000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'KWS065T43', 9, 700000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00003', 'YEZ3NAVY39', 22, 2550000)--YNX
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00003', 'YEZ3WHITE41', 4, 2500000)--YNX
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'ANKLTS', 8, 135000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00003', 'YEZ3NAVY42', 9, 2550000)--YNX
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00002', 'YEZ3WHITE41', 5, 2500000)--YNX
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'KWS065T40', 13, 700000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'AX70', 9, 4200000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'AX90', 18, 5100000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00002', '88DP2022', 6, 4500000) --YNX 
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'KMTTML', 9, 2100000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00002', 'Y65Z3WT40', 9, 2400000)--YNX
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'PPTEP39TTF', 8, 600000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'AXM39', 9, 1850000)
INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES ('NH00001', 'AXM40', 9, 1850000);
GO
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00001', N'0923455789', N'QL01', CAST(N'2024-03-08' AS Date), 2760000, N'8thang3')
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00002', N'0934586890', N'BH01', CAST(N'2024-02-14' AS Date), 800000, N'14thang2')
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00003', N'0901236767', N'QL01', CAST(N'2024-03-10' AS Date), 8100000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00004', N'0912345678', N'BH01', CAST(N'2024-03-10' AS Date), 300000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00005', N'0923455789', N'QL01', CAST(N'2024-03-10' AS Date), 5300000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00006', N'0934586890', N'BH01', CAST(N'2024-03-11' AS Date), 800000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00007', N'0944567901', N'QL01', CAST(N'2024-03-12' AS Date), 15300000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00008', N'0959839012', N'QL01', CAST(N'2024-03-13' AS Date), 9800000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00009', N'0967801423', N'BH02', CAST(N'2024-03-14' AS Date), 2300000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00010', N'0978986234', N'BH02', CAST(N'2024-03-15' AS Date), 2700000, NULL)
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00011', N'0989013345', N'QL01', CAST(N'2024-04-30' AS Date), 930000, N'30THANG4')
INSERT [dbo].[Orders] ([Order_ID], [PhoneNumber], [EmployeeID], [OrderDate], [Total], [DiscountCode]) VALUES (N'HD00012', N'0990124756', N'QL01', CAST(N'2024-03-17' AS Date), 4000000, NULL)
GO
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00001', N'KWS065T39', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00001', N'LCA40', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00002', N'KWS065T43', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00003', N'YEZ3NAVY39', 2)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00003', N'YEZ3WHITE41', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00004', N'ANKLTS', 2)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00005', N'YEZ3NAVY42', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00005', N'YEZ3WHITE41', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00006', N'KWS065T40', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00007', N'AX70', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00007', N'AX90', 2)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00008', N'88DP2022', 2)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00009', N'KMTTML', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00010', N'Y65Z3WT40', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00011', N'PPTEP39TTF', 2)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00012', N'AXM39', 1)
INSERT [dbo].[OrderDetails] ([Order_ID], [Product_ID], [Quantity]) VALUES (N'HD00012', N'AXM40', 1)
GO

Update Products set Picture_ID = 1 where ProductName like N'%Áo cầu lông Yonex Đen%'
Update Products set Picture_ID = 2 where ProductName like N'%Áo cầu lông Yonex Trắng%'
Update Products set Picture_ID = 3 where ProductName like N'%Kamito Tiến Minh Legend%'
Update Products set Picture_ID = 4 where ProductName like N'%Kamito VTT Gowo%'
Update Products set Picture_ID = 5 where ProductName like N'%Kawasaki 065 Đỏ%'
Update Products set Picture_ID = 6 where ProductName like N'%Kawasaki 065 Trắng%'
Update Products set Picture_ID = 7 where ProductName like N'%Lining Axforce 70%'
Update Products set Picture_ID = 8 where ProductName like N'%Lining Axforce 80%'
Update Products set Picture_ID = 9 where ProductName like N'%Lining Axforce 90%'
Update Products set Picture_ID = 10 where ProductName like N'%Lining ChenLong AYZU011-1%'
Update Products set Picture_ID = 11 where ProductName like N'%Ống cầu lông Lining%'
Update Products set Picture_ID = 12 where ProductName like N'%Ống cầu lông Yonex%'
Update Products set Picture_ID = 13 where ProductName like N'%Pan Patriot EVO Pod TF Đỏ%'
Update Products set Picture_ID = 14 where ProductName like N'%Pan Patriot EVO Pod TF Trắng%'
Update Products set Picture_ID = 15 where ProductName like N'%Pan Patriot EVO Pod TF Vàng%'
Update Products set Picture_ID = 16 where ProductName like N'%Pro Kennex Power Pro 705%'
Update Products set Picture_ID = 17 where ProductName like N'%Pro Kennex Thunder 7004%'
Update Products set Picture_ID = 18 where ProductName like N'%Quấn cán cầu lông Lining%'
Update Products set Picture_ID = 19 where ProductName like N'%Quấn cán cầu lông Yonex%'
Update Products set Picture_ID = 20 where ProductName like N'%Yonex Astrox 88D 2018%'
Update Products set Picture_ID = 21 where ProductName like N'%Yonex Astrox 88D Pro 2022%'
Update Products set Picture_ID = 22 where ProductName like N'%Yonex Astrox 88S 2018%'
Update Products set Picture_ID = 23 where ProductName like N'%Yonex Astrox 88S Pro 2022%'
Update Products set Picture_ID = 24 where ProductName like N'%Yonex Astrox 99 Navy 2020%'
Update Products set Picture_ID = 25 where ProductName like N'%Yonex Astrox 99 Pro 2022%'
Update Products set Picture_ID = 26 where ProductName like N'%Yonex Eclipsion Z3 Men Navy%'
Update Products set Picture_ID = 27 where ProductName like N'%Yonex SHB 65 Z3 White Tiger%'
Update Products set Picture_ID = 28 where ProductName like N'%Yonex SHB 65 Z3 Woman Navy%'
Update Products set Picture_ID = 29 where ProductName like N'%Adidas X Crazyfast Messi%'
Update Products set Picture_ID = 30 where ProductName like N'%Áo bóng đá Nike không logo Đen%'
Update Products set Picture_ID = 31 where ProductName like N'%Áo bóng đá Nike không logo Trắng%'
