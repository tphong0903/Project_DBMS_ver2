use QuanLyBanHangTheThao
INSERT INTO Customers (PhoneNumber, NameCustomer, Birthday, Gender, Point) 
VALUES
('0901236767', N'Trần Đức Anh', '2009-03-15', 'Nam', 256),
('0912345678', N'Nguyễn Thị Hương', '1997-07-20', 'Nu', 743),
('0923455789', N'Lê Văn Nam', '1995-09-25', 'Nam', 512),
('0934586890', N'Phạm Thị Loan', '2000-07-20', 'Nu', 899),
('0944567901', N'Hoàng Minh Tuấn', '2005-04-05', 'Nam', 347),
('0959839012', N'Vũ Thị Lan Anh', '1988-06-12', 'Nu', 631),
('0967801423', N'Đặng Xuân Hải', '1993-04-05', 'Nam', 178),
('0978986234', N'Bùi Hồng Loan', '2002-10-22', 'Nu', 425),
('0989013345', N'Đỗ Quang Huy', '1980-12-28', 'Nam', 568),
('0990124756', N'Ngô Thị Hà', '1978-02-03', 'Nu', 937);


INSERT INTO Employees (EmployeeID, NameEmployee, Birthday, Gender, AddressEmployee, PhoneNumber,RoleEmployee,Active,PasswordAccount) 
VALUES
('QL01', N'Phạm Minh Đức', '1980-02-28', 'Nam', N'1 Đường Võ Văn Ngân, TP.Thủ Đức , TP.HCM', '0987612521', N'Quản lí',1,'123456'),
('BH01', N'Ngô Thị Mai Anh', '1985-12-30', 'Nu', N'5 Đường Lê Lợi, Quận 3, TP.HCM', '0918575678',N'Bán hàng',1,'hahaha'),
('BH02', N'Lương Văn Tuấn', '1982-09-26', 'Nam', N'125 Đường Phan Xích Long, Quận Phú Nhuận, TP.HCM', '0978545412', N'Bán hàng',1,'huhuhu');


INSERT INTO Suppliers (Supplier_ID, CompanyName, PhoneNumber, AddressSupplier, Email)
VALUES
('YNS', 'Yonex Sunrise Vietnam', '0363609039', N'157 Điện Biên Phủ, Phường Đa Kao, Quận 1, Thành Phố Hồ Chí Minh, Việt Nam', 'sunrisevn@risesun.com.sg'),
('ATS', N'Anh Thắng Sport', '0981122234', N'41 Đường C1, P13, Q. Tân Bình, TP Hồ Chí Minh', 'anhthangsport.com'),
('VNB', 'Vietnam Badminton', '0977508430', N'20 Cao Bá Nhạ, Phường Nguyễn Cư Trinh, Quận 1, TPHCM', 'info@shopvnb.com');

INSERT INTO Brands (Brand_ID, BrandName)
VALUES 
    ('ADD', 'Adidas'),
    ('KMT', 'Kamito'),
    ('KWS', 'Kawasaki'),
    ('LN', 'Lining'),
    ('NIK', 'Nike'),
    ('PKN', 'Prokennex'),
    ('PN', 'PAN'),
    ('YNX', 'Yonex');

INSERT INTO Categories (Category_ID, CategoryName)
VALUES ('ACL', N'Áo cầu lông'),
       ('BĐBĐ', N'Bộ đồ bóng đá'),
       ('GBĐ', N'Giày bóng đá'),
       ('GCL', N'Giày cầu lông'),
       ('PK', N'Phụ kiện'),
       ('QCL', N'Quần cầu lông'),
       ('VCL', N'Vợt cầu lông');

INSERT INTO Products (Product_ID, ProductName, UnitPrice, Brand_ID, Category_ID,Quantity)
VALUES
('99NAVY2020', 'Yonex Astrox 99 Navy 2020', 5000000, 'YNX', 'VCL',5),
('99PRO2022', 'Yonex Astrox 99 Pro 2022', 5500000, 'YNX', 'VCL',5),
('88DP2022', 'Yonex Astrox 88D Pro 2022', 4900000, 'YNX', 'VCL',5),
('88DS2022', 'Yonex Astrox 88S Pro 2022', 4800000, 'YNX', 'VCL',5),
('88D2018', 'Yonex Astrox 88D 2018', 6500000, 'YNX', 'VCL',0),
('88S2018', 'Yonex Astrox 88S 2018', 6400000, 'YNX', 'VCL',0),
('AX90', 'Lining Axforce 90', 5400000, 'LN', 'VCL',0),
('AX80', 'Lining Axforce 80', 5000000, 'LN', 'VCL',0),
('AX70', 'Lining Axforce 70', 4500000, 'LN', 'VCL',0),
('KMTVTT', 'Kamito VTT Gowo', 1700000, 'KMT', 'VCL',0),
('KMTTML', N'Kamito Tiến Minh Legend', 2300000, 'KMT', 'VCL',0),
('PKPP705', 'Pro Kennex Power Pro 705', 800000, 'PKN', 'VCL',0),
('PKT7004', 'Pro Kennex Thunder 7004', 900000, 'PKN', 'VCL',0),

('YEZ3NAVY39', 'Yonex Eclipsion Z3 Men Navy Size 39', 2700000, 'YNX', 'GCL',0),
('YEZ3NAVY40', 'Yonex Eclipsion Z3 Men Navy Size 40', 2700000, 'YNX', 'GCL',0),
('YEZ3NAVY41', 'Yonex Eclipsion Z3 Men Navy Size 41', 2700000, 'YNX', 'GCL',0),
('YEZ3NAVY42', 'Yonex Eclipsion Z3 Men Navy Size 42', 2700000, 'YNX', 'GCL',0),
('YEZ3NAVY43', 'Yonex Eclipsion Z3 Men Navy Size 43', 2700000, 'YNX', 'GCL',0),
('YEZ3NAVY44', 'Yonex Eclipsion Z3 Men Navy Size 44', 2700000, 'YNX', 'GCL',0),
('YEZ3WHITE39', 'Yonex Eclipsion Z3 Woman White Size 39', 2600000, 'YNX', 'GCL',0),
('YEZ3WHITE40', 'Yonex Eclipsion Z3 Woman White Size 40', 2600000, 'YNX', 'GCL',0),
('YEZ3WHITE41', 'Yonex Eclipsion Z3 Woman White Size 41', 2600000, 'YNX', 'GCL',0),
('YEZ3WHITE42', 'Yonex Eclipsion Z3 Woman White Size 42', 2600000, 'YNX', 'GCL',0),
('Y65Z3WT39', 'Yonex SHB 65 Z3 White Tiger Size 39', 2700000, 'YNX', 'GCL',0),
('Y65Z3WT40', 'Yonex SHB 65 Z3 White Tiger Size 40', 2700000, 'YNX', 'GCL',0),
('Y65Z3WT41', 'Yonex SHB 65 Z3 White Tiger Size 41', 2700000, 'YNX', 'GCL',0),
('Y65Z3WT42', 'Yonex SHB 65 Z3 White Tiger Size 42', 2700000, 'YNX', 'GCL',0),
('Y65Z3WT43', 'Yonex SHB 65 Z3 White Tiger Size 43', 2700000, 'YNX', 'GCL',0),
('Y65Z3WT44', 'Yonex SHB 65 Z3 White Tiger Size 44', 2700000, 'YNX', 'GCL',0),
('Y65Z3WN39', 'Yonex SHB 65 Z3 Woman Navy Size 39', 2600000, 'YNX', 'GCL',0),
('Y65Z3WN40', 'Yonex SHB 65 Z3 Woman Navy Size 40', 2600000, 'YNX', 'GCL',0),
('Y65Z3WN41', 'Yonex SHB 65 Z3 Woman Navy Size 41', 2600000, 'YNX', 'GCL',0),
('Y65Z3WN42', 'Yonex SHB 65 Z3 Woman Navy Size 42', 2600000, 'YNX', 'GCL',0),
('LCA39', 'Lining ChenLong AYZU011-1 Size 39', 2650000, 'LN', 'GCL',0),
('LCA40', 'Lining ChenLong AYZU011-1 Size 40', 2650000, 'LN', 'GCL',0),
('LCA41', 'Lining ChenLong AYZU011-1 Size 41', 2650000, 'LN', 'GCL',0),
('LCA42', 'Lining ChenLong AYZU011-1 Size 42', 2650000, 'LN', 'GCL',0),
('LCA43', 'Lining ChenLong AYZU011-1 Size 43', 2650000, 'LN', 'GCL',0),
('LCA44', 'Lining ChenLong AYZU011-1 Size 44', 2650000, 'LN', 'GCL',0),
('KWS065T39', N'Kawasaki 065 Trắng Size 39', 800000, 'KWS', 'GCL',0),
('KWS065T40', N'Kawasaki 065 Trắng Size 40', 800000, 'KWS', 'GCL',0),
('KWS065T41', N'Kawasaki 065 Trắng Size 41', 800000, 'KWS', 'GCL',0),
('KWS065T42', N'Kawasaki 065 Trắng Size 42', 800000, 'KWS', 'GCL',0),
('KWS065T43', N'Kawasaki 065 Trắng Size 43', 800000, 'KWS', 'GCL',0),
('KWS065T44', N'Kawasaki 065 Trắng Size 44', 800000, 'KWS', 'GCL',0),
('KWS065Đ39', N'Kawasaki 065 Đỏ Size 39', 800000, 'KWS', 'GCL',0),
('KWS065Đ40', N'Kawasaki 065 Đỏ Size 40', 800000, 'KWS', 'GCL',0),
('KWS065Đ41', N'Kawasaki 065 Đỏ Size 41', 800000, 'KWS', 'GCL',0),
('KWS065Đ42', N'Kawasaki 065 Đỏ Size 42', 800000, 'KWS', 'GCL',0),
('KWS065Đ43', N'Kawasaki 065 Đỏ Size 43', 800000, 'KWS', 'GCL',0),
('KWS065Đ44', N'Kawasaki 065 Đỏ Size 44', 800000, 'KWS', 'GCL',0),

('PPTEP39TTF', N'Pan Patriot EVO Pod TF Trắng Size 39', 620000, 'PN', 'GBĐ',0),
('PPTEP40TTF', N'Pan Patriot EVO Pod TF Trắng Size 40', 620000, 'PN', 'GBĐ',0),
('PPTEP41TTF', N'Pan Patriot EVO Pod TF Trắng Size 41', 620000, 'PN', 'GBĐ',0),
('PPTEP42TTF', N'Pan Patriot EVO Pod TF Trắng Size 42', 620000, 'PN', 'GBĐ',0),
('PPTEP43TTF', N'Pan Patriot EVO Pod TF Trắng Size 43', 620000, 'PN', 'GBĐ',0),
('PPTEP44TTF', N'Pan Patriot EVO Pod TF Trắng Size 44', 620000, 'PN', 'GBĐ',0),
('PPTEP39TIC', N'Pan Patriot EVO Pod IC Trắng Size 39', 610000, 'PN', 'GBĐ',0),
('PPTEP40TIC', N'Pan Patriot EVO Pod IC Trắng Size 40', 610000, 'PN', 'GBĐ',0),
('PPTEP41TIC', N'Pan Patriot EVO Pod IC Trắng Size 41', 610000, 'PN', 'GBĐ',0),
('PPTEP42TIC', N'Pan Patriot EVO Pod IC Trắng Size 42', 610000, 'PN', 'GBĐ',0),
('PPTEP43TIC', N'Pan Patriot EVO Pod IC Trắng Size 43', 610000, 'PN', 'GBĐ',0),
('PPTEP44TIC', N'Pan Patriot EVO Pod IC Trắng Size 44', 610000, 'PN', 'GBĐ',0),
('PPTEP39ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 39', 620000, 'PN', 'GBĐ',0),
('PPTEP40ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 40', 620000, 'PN', 'GBĐ',0),
('PPTEP41ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 41', 620000, 'PN', 'GBĐ',0),
('PPTEP42ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 42', 620000, 'PN', 'GBĐ',0),
('PPTEP43ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 43', 620000, 'PN', 'GBĐ',0),
('PPTEP44ĐTF', N'Pan Patriot EVO Pod TF Đỏ Size 44', 620000, 'PN', 'GBĐ',0),
('PPTEP39VTF', N'Pan Patriot EVO Pod TF Vàng Size 39', 620000, 'PN', 'GBĐ',0),
('PPTEP40VTF', N'Pan Patriot EVO Pod TF Vàng Size 40', 620000, 'PN', 'GBĐ',0),
('PPTEP41VTF', N'Pan Patriot EVO Pod TF Vàng Size 41', 620000, 'PN', 'GBĐ',0),
('PPTEP42VTF', N'Pan Patriot EVO Pod TF Vàng Size 42', 620000, 'PN', 'GBĐ',0),
('PPTEP43VTF', N'Pan Patriot EVO Pod TF Vàng Size 43', 620000, 'PN', 'GBĐ',0),
('PPTEP44VTF', N'Pan Patriot EVO Pod TF Vàng Size 44', 620000, 'PN', 'GBĐ',0),
('AXM39', 'Adidas X Crazyfast Messi Size 39', 2000000, 'ADD', 'GBĐ',0),
('AXM40', 'Adidas X Crazyfast Messi Size 40', 2000000, 'ADD', 'GBĐ',0),
('AXM41', 'Adidas X Crazyfast Messi Size 41', 2000000, 'ADD', 'GBĐ',0),
('AXM42', 'Adidas X Crazyfast Messi Size 42', 2000000, 'ADD', 'GBĐ',0),
('AXM43', 'Adidas X Crazyfast Messi Size 43', 2000000, 'ADD', 'GBĐ',0),
('AXM44', 'Adidas X Crazyfast Messi Size 44', 2000000, 'ADD', 'GBĐ',0),
('NGCR39', 'Nike Galaxy CR7 Size 39', 2000000, 'NIK', 'GBĐ',0),
('NGCR40', 'Nike Galaxy CR7 Size 40', 2000000, 'NIK', 'GBĐ',0),
('NGCR41', 'Nike Galaxy CR7 Size 41', 2000000, 'NIK', 'GBĐ',0),
('NGCR42', 'Nike Galaxy CR7 Size 42', 2000000, 'NIK', 'GBĐ',0),
('NGCR43', 'Nike Galaxy CR7 Size 43', 2000000, 'NIK', 'GBĐ',0),
('NGCR44', 'Nike Galaxy CR7 Size 44', 2000000, 'NIK', 'GBĐ',0),

('ANKLTS', N'Áo bóng đá Nike không logo Trắng Size S', 150000, 'NIK', 'BĐBĐ',0),
('ANKLTM', N'Áo bóng đá Nike không logo Trắng Size M', 150000, 'NIK', 'BĐBĐ',0),
('ANKLTL', N'Áo bóng đá Nike không logo Trắng Size L', 150000, 'NIK', 'BĐBĐ',0),
('ANKLTXL', N'Áo bóng đá Nike không logo Trắng Size XL', 150000, 'NIK', 'BĐBĐ',0),
('ANKLTXXL', N'Áo bóng đá Nike không logo Trắng Size XXL', 150000, 'NIK', 'BĐBĐ',0),
('ANKLĐS', N'Áo bóng đá Nike không logo Đen Size S', 150000, 'NIK', 'BĐBĐ',0),
('ANKLĐM', N'Áo bóng đá Nike không logo Đen Size M', 150000, 'NIK', 'BĐBĐ',0),
('ANKLĐL', N'Áo bóng đá Nike không logo Đen Size L', 150000, 'NIK', 'BĐBĐ',0),
('ANKLĐXL', N'Áo bóng đá Nike không logo Đen Size XL', 150000, 'NIK', 'BĐBĐ',0),
('ANKLĐXXL', N'Áo bóng đá Nike không logo Đen Size XXL', 150000, 'NIK', 'BĐBĐ',0),

('QCY', N'Ống cầu lông Yonex', 1200000, 'YNX', 'PK',0),
('QCL', N'Ống cầu lông Lining', 200000, 'LN', 'PK',0),
('QCCLY', N'Quấn cán cầu lông Yonex', 50000, 'YNX', 'PK',0),
('QCCLL', N'Quấn cán cầu lông Lining', 20000, 'LN', 'PK',0),

('ACLYTS', N'Áo cầu lông Yonex Trắng Size S', 200000, 'YNX', 'ACL',0),
('ACLYTM', N'Áo cầu lông Yonex Trắng Size M', 200000, 'YNX', 'ACL',0),
('ACLYTL', N'Áo cầu lông Yonex Trắng Size L', 200000, 'YNX', 'ACL',0),
('ACLYTXL', N'Áo cầu lông Yonex Trắng Size XL', 200000, 'YNX', 'ACL',0),
('ACLYTXXL', N'Áo cầu lông Yonex Trắng Size XXL', 200000, 'YNX', 'ACL',0),
('ACLYĐS', N'Áo cầu lông Yonex Đen Size S', 200000, 'YNX', 'ACL',0),
('ACLYĐM', N'Áo cầu lông Yonex Đen Size M', 200000, 'YNX', 'ACL',0),
('ACLYĐL', N'Áo cầu lông Yonex Đen Size L', 200000, 'YNX', 'ACL',0),
('ACLYĐXL', N'Áo cầu lông Yonex Đen Size XL', 200000, 'YNX', 'ACL',0),
('ACLYĐXXL', N'Áo cầu lông Yonex Đen Size XXL', 200000, 'YNX', 'ACL',0);

UPDATE Products
SET Quantity = 10
WHERE Quantity = 0;

INSERT INTO Imports (Import_ID, Supplier_ID, ImportDay, Total) VALUES
('IP1', 'YNS', '2023-03-14', 24100000),
('IP2', 'ATS', '2023-03-14', 83000000),
('IP3', 'YNS', '2023-03-15', 27600000),
('IP4', 'VNB', '2023-03-15', 5600000),
('IP5', 'ATS', '2023-03-16', 21200000);

INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost) VALUES
('IP1', '99NAVY2020', 5, 3500000),
('IP1', '88DP2022', 3, 2200000),
('IP2', '88D2018', 7, 5000000),
('IP2', 'AX90', 10, 480000),
('IP3', 'YEZ3NAVY39', 8, 220000),
('IP3', 'YEZ3WHITE39', 5, 2000000),
('IP4', 'KWS065T39', 4, 650000),
('IP4', 'KWS065T40', 4, 750000),
('IP5', 'YEZ3NAVY40', 6, 2200000),
('IP5', 'YEZ3WHITE40', 4, 2000000);


INSERT INTO Discounts (DiscountCode, PercentageDiscount, StartDay, EndDay) 
VALUES
('14THANG2', 15, '2024-02-10', '2024-02-15'),
('8THANG3', 20, '2024-03-05', '2024-03-09'),
('30THANG4', 25, '2024-04-25', '2024-05-02');


INSERT INTO Orders (Order_ID, PhoneNumber, EmployeeID, OrderDate, Total, DiscountCode)
VALUES
('HD00001', '0923455789', 'QL01', '2024-03-8', 2760000,'8thang3'),
('HD00002', '0934586890', 'BH01', '2024-02-14',800000,'14thang2'),
('HD00003', '0901236767', 'QL01', '2024-03-10', 8100000, NULL),
 ('HD00004', '0912345678', 'BH01', '2024-03-10', 300000, NULL), 
('HD00005', '0923455789', 'QL01', '2024-03-10', 5300000, NULL), 
('HD00006', '0934586890', 'BH01', '2024-03-11', 800000, NULL), 
('HD00007', '0944567901', 'QL01', '2024-03-12', 15300000, NULL), 
('HD00008', '0959839012', 'QL01', '2024-03-13',9800000, NULL), 
('HD00009', '0967801423', 'BH02', '2024-03-14', 2300000, NULL),
('HD00010', '0978986234', 'BH02', '2024-03-15', 2700000, NULL), 
('HD00011', '0989013345', 'QL01', '2024-04-30', 930000, '30THANG4'),
 ('HD00012', '0990124756', 'QL01', '2024-03-17', 4000000, NULL);


INSERT INTO OrderDetails (Order_ID, Product_ID, Quantity) 
VALUES
('HD00001','KWS065T39', 1),
('HD00001','LCA40', 1),

('HD00002','KWS065T43', 1),

('HD00003', 'YEZ3NAVY39', 2),
('HD00003', 'YEZ3WHITE41', 1),

('HD00004', 'ANKLTS', 2),

('HD00005', 'YEZ3NAVY42', 1),
('HD00005', 'YEZ3WHITE41', 1),

('HD00006', 'KWS065T40', 1),

('HD00007', 'AX90', 2),
('HD00007', 'AX70', 1),

('HD00008', '88DP2022', 2),


('HD00009', 'KMTTML', 1),

('HD00010', 'Y65Z3WT40', 1),

('HD00011', 'PPTEP39TTF', 2),

('HD00012', 'AXM39', 1),
('HD00012', 'AXM40', 1);

