USE master;
DROP DATABASE IF EXISTS QuanLyBanHangTheThao;

CREATE DATABASE QuanLyBanHangTheThao;

GO
USE QuanLyBanHangTheThao;

GO
CREATE TABLE Customers (
	PhoneNumber VARCHAR(12) CONSTRAINT PhoneKey PRIMARY KEY,
	NameCustomer NVARCHAR(50) NOT NULL,
	Birthday DATE,
	Gender CHAR(3) NOT NULL CONSTRAINT GenderCheck_Customer CHECK (GENDER IN ('Nam', 'Nu')),
	Point INT,
	CONSTRAINT PhoneNumber_Customer CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber NOT LIKE '%[^0-9]%')
);

CREATE TABLE Employees (
	EmployeeID VARCHAR(5) CONSTRAINT EmployeeIDKey PRIMARY KEY,
	NameEmployee NVARCHAR(50) NOT NULL,
	Birthday DATE,
	Gender CHAR(3) NOT NULL CONSTRAINT GenderCheck_Employee CHECK (GENDER IN ('Nam', 'Nu')),
	AddressEmployee NVARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(12) NOT NULL,
	RoleEmployee NVARCHAR(50) NOT NULL,
	Active CHAR(1) NOT NULL,
	PassWordAccount VARCHAR(10) NOT NULL,
	CONSTRAINT PhoneNumber_Employee CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber NOT LIKE '%[^0-9]%'),
	CONSTRAINT LengthPassWordAccount CHECK (LEN(PassWordAccount) >= 6)
);

CREATE TABLE Brands (
	Brand_ID VARCHAR(10) CONSTRAINT Brand_IDKey PRIMARY KEY,
	BrandName NVARCHAR(50) NOT NULL
);

CREATE TABLE Categories (
	Category_ID VARCHAR(10) CONSTRAINT Category_IDKey PRIMARY KEY,
	CategoryName NVARCHAR(50) NOT NULL
);

CREATE TABLE Discounts (
	DiscountCode VARCHAR(10) CONSTRAINT DiscountCodeKey PRIMARY KEY,
	PercentageDiscount INT NOT NULL,
	StartDay DATE NOT NULL,
	EndDay DATE NOT NULL
);

CREATE TABLE Suppliers (
	Supplier_ID VARCHAR(10) CONSTRAINT Supplier_IDKey PRIMARY KEY,
	CompanyName NVARCHAR(30) NOT NULL,
	PhoneNumber VARCHAR(12) CONSTRAINT PhoneNumber_Supplier CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber NOT LIKE '%[^0-9]%'),
	AddressSupplier NVARCHAR(100) NOT NULL,
	Email VARCHAR(50)
);

CREATE TABLE Imports (
	Import_ID VARCHAR(10) CONSTRAINT Import_IDKey PRIMARY KEY,
	Supplier_ID VARCHAR(10) Not null ,
	ImportDay DATE NOT NULL,
	Total INT NOT NULL,
	CONSTRAINT FK_Supplier_Import FOREIGN KEY (Supplier_ID)
			REFERENCES Suppliers(Supplier_ID) On Update Cascade
);

CREATE TABLE Orders (
	Order_ID VARCHAR(15) CONSTRAINT Order_IDKey PRIMARY KEY,
	PhoneNumber VARCHAR(12) NOT NULL,
	EmployeeID VARCHAR(5) NOT NULL,
	OrderDate DATE NOT NULL,
	Total INT not null,
	DiscountCode VARCHAR(10),
	CONSTRAINT PhoneNumber_Orders CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber LIKE '%[0-9]%'),
	CONSTRAINT FK_PhoneNumber_Orders FOREIGN KEY (PhoneNumber)
			REFERENCES Customers(PhoneNumber) On Update Cascade,
	CONSTRAINT FK_Employee_Orders FOREIGN KEY (EmployeeID)
			REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_Discount_Order FOREIGN KEY (DiscountCode)
			REFERENCES Discounts(DiscountCode) 
);

CREATE TABLE PictureProduct (
	Picture_ID INT IDENTITY(1,1) PRIMARY KEY,
	Picture_Name varchar(100) 
);

CREATE TABLE Products (
	Product_ID VARCHAR(15) CONSTRAINT Product_IDKey PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL,
	UnitPrice INT NOT NULL,
	Quantity INT NOT NULL,
	Brand_ID VARCHAR(10) NOT NULL,
	Category_ID VARCHAR(10) NOT NULL,
	Picture_ID int 
	CONSTRAINT FK_Brand_Product FOREIGN KEY (Brand_ID)
			REFERENCES Brands(Brand_ID) ,
	CONSTRAINT FK_Category_Product FOREIGN KEY (Category_ID)
			REFERENCES Categories(Category_ID),
	 CONSTRAINT FK_Picture_Product FOREIGN KEY (Picture_ID)
			REFERENCES PictureProduct(Picture_ID)
);

CREATE TABLE OrderDetails (
	Order_ID VARCHAR(15) NOT NULL,
	Product_ID VARCHAR(15) NOT NULL,
	Quantity INT NOT NULL,
	CONSTRAINT FK_Order_OrderDetail FOREIGN KEY (Order_ID)
			REFERENCES Orders(Order_ID) ON DELETE CASCADE,
	CONSTRAINT FK_Product_OrderDetail FOREIGN KEY (Product_ID)
			REFERENCES Products(Product_ID) ON UPDATE CASCADE,
	CONSTRAINT OrderDetail_IDKey PRIMARY KEY (Order_ID , Product_ID)
);

CREATE TABLE ImportDetails (
	Import_ID VARCHAR(10),
	Product_ID VARCHAR(15),
	Quantity INT NOT NULL,
	Unitcost INT NOT NULL,
	CONSTRAINT FK_Import_ImportDetail FOREIGN KEY (Import_ID)
			REFERENCES Imports(Import_ID) ON DELETE CASCADE,
	CONSTRAINT FK_Product_ImportDetail FOREIGN KEY (Product_ID)
			REFERENCES Products(Product_ID),
	CONSTRAINT ImportDetail_IDKey PRIMARY KEY (Import_ID , Product_ID)
);
go
use QuanLyBanHangTheThao

-- CẬP NHẬT TỔNG TIỀN HÓA ĐƠN IMPORT
-- Khi thêm vào chi tiết nhập
GO
CREATE TRIGGER UpdateTotalImport_InsertImportDetails ON ImportDetails
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @Import_ID VARCHAR(10);
        DECLARE @TotalAmount INT;

        -- Lấy Import_ID từ bảng inserted
        SELECT @Import_ID = Import_ID FROM inserted;

        -- Tính tổng số tiền cho đợt nhập hàng mới
        SELECT @TotalAmount = SUM(Quantity * Unitcost) FROM inserted WHERE Import_ID = @Import_ID;

        -- Cập nhật tổng số tiền cho đợt nhập hàng trong bảng Imports
        UPDATE Imports
        SET Total = Total + @TotalAmount
        WHERE Import_ID = @Import_ID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT @ErrorMessage = ERROR_MESSAGE(),
               @ErrorSeverity = ERROR_SEVERITY(),
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

GO
-- Khi xóa khỏi chi tiết nhập
CREATE TRIGGER UpdateTotalImport_DeleteImportDetails ON ImportDetails
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @table TABLE(Import_ID VARCHAR(10), Quantity INT, Unitcost INT);
        
        -- Lưu các thông tin từ bảng deleted vào bảng tạm
        INSERT INTO @table 
        SELECT Import_ID, Quantity, Unitcost FROM deleted;

        -- Cập nhật tổng số tiền trong bảng Imports
        UPDATE Imports
        SET Imports.Total = Imports.Total - (T.Quantity * T.Unitcost)
        FROM Imports
        INNER JOIN @table AS T ON Imports.Import_ID = T.Import_ID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT @ErrorMessage = ERROR_MESSAGE(),
               @ErrorSeverity = ERROR_SEVERITY(),
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

GO

-- Khi chỉnh sửa chi tiết nhập
CREATE TRIGGER UpdateTotalImport_UpdateImportDetails ON ImportDetails
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @tableNew TABLE(Import_ID VARCHAR(10), Quantity INT, Unitcost INT);
        DECLARE @tableOld TABLE(Import_ID VARCHAR(10), Quantity INT, Unitcost INT);

        -- Lưu các thông tin mới từ bảng inserted vào bảng tạm
        INSERT INTO @tableNew 
        SELECT Import_ID, Quantity, Unitcost FROM inserted;

        -- Lưu các thông tin cũ từ bảng deleted vào bảng tạm
        INSERT INTO @tableOld 
        SELECT Import_ID, Quantity, Unitcost FROM deleted;

        -- Cập nhật tổng số tiền trong bảng Imports
        UPDATE Imports
        SET Imports.Total = Imports.Total + (TN.Quantity * TN.Unitcost) - (TBO.Quantity * TBO.Unitcost)
        FROM Imports
        INNER JOIN @tableNew AS TN ON Imports.Import_ID = TN.Import_ID 
        INNER JOIN @tableOld AS TBO ON Imports.Import_ID = TBO.Import_ID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT @ErrorMessage = ERROR_MESSAGE(),
               @ErrorSeverity = ERROR_SEVERITY(),
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

GO

-- CẬP NHẬT SỐ LƯỢNG SẢN PHẨM KHI IMPORT
-- Khi nhập
CREATE TRIGGER UpdateQuantityProduct_InsertImportDetails ON ImportDetails
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @table TABLE(Product_ID VARCHAR(15), Quantity INT);

        -- Lưu thông tin từ bảng inserted vào bảng tạm
        INSERT INTO @table 
        SELECT Product_ID, Quantity FROM inserted;

        -- Cập nhật số lượng sản phẩm trong bảng Products
        UPDATE Products
        SET Products.Quantity = Products.Quantity + T.Quantity
        FROM Products
        INNER JOIN @table AS T ON Products.Product_ID = T.Product_ID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT @ErrorMessage = ERROR_MESSAGE(),
               @ErrorSeverity = ERROR_SEVERITY(),
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

GO

-- Khi xóa
CREATE TRIGGER UpdateQuantityProduct_DeleteImportDetails ON ImportDetails
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @table TABLE(Product_ID VARCHAR(15), Quantity INT);

        -- Lưu thông tin từ bảng deleted vào bảng tạm
        INSERT INTO @table 
        SELECT Product_ID, Quantity FROM deleted;

        -- Cập nhật số lượng sản phẩm trong bảng Products
        UPDATE Products
        SET Products.Quantity = Products.Quantity - T.Quantity
        FROM Products
        INNER JOIN @table AS T ON Products.Product_ID = T.Product_ID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT @ErrorMessage = ERROR_MESSAGE(),
               @ErrorSeverity = ERROR_SEVERITY(),
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

GO

-- Khi chỉnh sửa
CREATE TRIGGER UpdateQuantityProduct_UpdateImportDetails ON [dbo].[ImportDetails]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @tableNew TABLE(Product_ID VARCHAR(15), Quantity INT);
        DECLARE @tableOld TABLE(Product_ID VARCHAR(15), Quantity INT);

        -- Lưu thông tin mới từ bảng inserted vào bảng tạm
        INSERT INTO @tableNew 
        SELECT Product_ID, Quantity FROM inserted;

        -- Lưu thông tin cũ từ bảng deleted vào bảng tạm
        INSERT INTO @tableOld 
        SELECT Product_ID, Quantity FROM deleted;

        -- Cập nhật số lượng sản phẩm trong bảng Products
        UPDATE P
        SET P.Quantity = P.Quantity - TBO.Quantity + TBN.Quantity
        FROM [dbo].[Products] AS P
        INNER JOIN @tableOld AS TBO ON P.Product_ID = TBO.Product_ID
        INNER JOIN @tableNew AS TBN ON P.Product_ID = TBN.Product_ID;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT @ErrorMessage = ERROR_MESSAGE(),
               @ErrorSeverity = ERROR_SEVERITY(),
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

GO

-- CẬP NHẬT SỐ LƯỢNG SP KHI THÊM, XÓA, SỬA CHI TIẾT HÓA ĐƠN
CREATE TRIGGER UpdateQuantityProduct_IDOrdersDetails ON OrderDetails
FOR INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS(SELECT * FROM inserted)
        BEGIN 
            IF EXISTS (SELECT * FROM Products p INNER JOIN inserted i ON p.Product_ID = i.Product_ID WHERE p.Quantity < i.Quantity)
            BEGIN
                -- Nếu có sản phẩm không đủ để bán, phát sinh lỗi và rollback transaction
                RAISERROR('San pham khong du de ban', 16, 1);
                ROLLBACK TRANSACTION;
                RETURN;
            END
            ELSE
            BEGIN
                -- Cập nhật số lượng sản phẩm sau khi thêm đơn hàng mới
                UPDATE p
                SET p.Quantity = p.Quantity - i.Quantity
                FROM Products p
                INNER JOIN inserted i ON p.Product_ID = i.Product_ID;
            END
        END
        ELSE
			BEGIN 
				-- Cập nhật số lượng sản phẩm sau khi xóa đơn hàng
				UPDATE p
				SET p.Quantity = p.Quantity + d.Quantity
				FROM Products p
				INNER JOIN deleted d ON p.Product_ID = d.Product_ID;
			END

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END

GO

-- CẬP NHẬT TỔNG TIỀN HÓA ĐƠN KHI THÊM, XÓA, SỬA CHI TIẾT HÓA ĐƠN
CREATE or alter TRIGGER UpdateTotalOrderBill ON OrderDetails
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Cập nhật tổng tiền hóa đơn cho mỗi hóa đơn được thêm
        UPDATE o
        SET o.Total = ISNULL((
            SELECT SUM(p.UnitPrice * od.Quantity)
            FROM OrderDetails od
            INNER JOIN Products p ON od.Product_ID = p.Product_ID
            WHERE od.Order_ID = o.Order_ID
        ), 0)
        FROM Orders o
        JOIN inserted i ON o.Order_ID = i.Order_ID;

        -- Cập nhật tổng tiền hóa đơn cho mỗi hóa đơn bị xóa hoặc được sửa
        UPDATE o
        SET o.Total = ISNULL((
            SELECT SUM(p.UnitPrice * od.Quantity)
            FROM OrderDetails od
            INNER JOIN Products p ON od.Product_ID = p.Product_ID
            WHERE od.Order_ID = o.Order_ID
        ), 0)
        FROM Orders o
        JOIN deleted d ON o.Order_ID = d.Order_ID;

		 -- Cập nhật tổng tiền của hóa đơn dựa trên mã giảm giá
        UPDATE o
        SET o.Total = o.Total * (1 - (d.PercentageDiscount / 100.0))
        FROM Orders o
        JOIN inserted i ON o.Order_ID = i.Order_ID
        JOIN Discounts d ON o.DiscountCode = d.DiscountCode;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
GO

-- CẬP NHẬT TRẠNG THÁI ACTIVE CỦA NHÂN VIÊN KHI XÓA
CREATE TRIGGER UpdateActive_Employee ON Employees
INSTEAD OF DELETE 
AS 
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Cập nhật trạng thái Active của nhân viên
        UPDATE Employees 
        SET Active = 0 
        FROM Employees e
        JOIN deleted d ON e.EmployeeID = d.EmployeeID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
GO

-- KIỂM TRA NGÀY HỢP LỆ CỦA DISCOUNT
CREATE TRIGGER CheckDateDiscount ON Orders
FOR INSERT, UPDATE
AS 
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @DateOrder DATE;
        DECLARE @DateEnd DATE;
        DECLARE @DateStart DATE;
        DECLARE @Code VARCHAR(10);

        -- Lấy ngày đặt hàng và mã khuyến mãi từ dữ liệu được thêm mới hoặc cập nhật
        SELECT @DateOrder = OrderDate, @Code = DiscountCode FROM inserted;

        -- Lấy ngày bắt đầu và kết thúc của mã khuyến mãi từ bảng Discounts
        SELECT @DateStart = StartDay, @DateEnd = EndDay FROM Discounts d WHERE d.DiscountCode = @Code ;

        -- Kiểm tra xem ngày đặt hàng có nằm trong khoảng thời gian khuyến mãi không
        IF (@DateOrder > @DateEnd OR @DateOrder < @DateStart)
        BEGIN
            -- Nếu ngày đặt hàng không nằm trong khoảng thời gian khuyến mãi, phát sinh lỗi và rollback transaction
            RAISERROR('Ma khuyen mai het han', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, rollback transaction và in ra thông báo lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END


-- Kiểm tra giá sản phẩm nhập phải thấp hơn giá bán
GO
CREATE TRIGGER CheckProductPrice_OnInsertImportDetails
ON [dbo].[ImportDetails]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra giá tiền sản phẩm từ đơn nhập hàng phải thấp hơn giá bán
    IF EXISTS (
        SELECT 1
        FROM inserted AS i
        INNER JOIN Products AS p ON i.Product_ID = p.Product_ID
        WHERE i.Unitcost > p.UnitPrice
    )
    BEGIN
        -- Nếu có sản phẩm có giá tiền cao hơn giá bán, rollback transaction và in ra thông báo lỗi
        RAISERROR ('Giá tiền sản phẩm phải thấp hơn giá bán.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
go
use QuanLyBanHangTheThao
go
--Product View
create VIEW View_Product AS
SELECT 
		p.Product_ID,
		p.ProductName, 
		p.UnitPrice, 
		p.Quantity,
		b.BrandName,
		c.CategoryName,
		pp.Picture_Name,
		p.Picture_ID
FROM Products p
LEFT JOIN Brands b ON p.Brand_ID = b.Brand_ID
LEFT JOIN Categories c ON p.Category_ID = c.Category_ID
Left Join PictureProduct pp on p.Picture_ID = pp.Picture_ID;

go
CREATE VIEW View_Customer AS

SELECT 
        c.PhoneNumber, 
        c.NameCustomer, 
        c.Birthday, 
        c.Gender, 
        c.Point, 
        SUM(o.Total) AS Tong
FROM 
        Customers c
    LEFT JOIN 
        Orders o ON c.PhoneNumber = o.PhoneNumber
GROUP BY 
        c.PhoneNumber, 
        c.NameCustomer, 
        c.Birthday, 
        c.Gender, 
        c.Point
go
-- Employee_Active View
CREATE VIEW EMPLOYEES_ACTIVE_VIEW
AS
	SELECT 
		e.EmployeeID,
		e.NameEmployee,
		e.Birthday,
		e.Gender,
		e.AddressEmployee,
		e.PhoneNumber,
		e.RoleEmployee,
		Sum(o.Total) as Tong
	FROM Employees e
	Left Join Orders o on  e.EmployeeID=o.EmployeeID
	WHERE e.Active = 1
	GROUP BY 
        e.EmployeeID,
		e.NameEmployee,
		e.Birthday,
		e.Gender,
		e.AddressEmployee,
		e.PhoneNumber,
		e.RoleEmployee
go
CREATE VIEW EMPLOYEES_All_VIEW
AS
	SELECT 
		e.EmployeeID,
		e.NameEmployee,
		e.Birthday,
		e.Gender,
		e.AddressEmployee,
		e.PhoneNumber,
		e.RoleEmployee,
		e.Active,
		e.PassWordAccount,
		Sum(o.Total) as Tong
	FROM Employees e
	Left Join Orders o on  e.EmployeeID=o.EmployeeID
	GROUP BY 
        e.EmployeeID,
		e.NameEmployee,
		e.Birthday,
		e.Gender,
		e.AddressEmployee,
		e.PhoneNumber,
		e.RoleEmployee,
		e.Active,
		e.PassWordAccount
go
-- Bill View
CREATE VIEW BILLS_VIEW
AS
	SELECT 
		o.Order_ID,
		c.NameCustomer,
		e.NameEmployee,
		o.OrderDate,
		o.Total,
		d.PercentageDiscount,
		o.PhoneNumber,
		o.DiscountCode,
		o.EmployeeID
	FROM Orders o
	JOIN Employees e ON e.EmployeeID = o.EmployeeID
	JOIN Customers c ON c.PhoneNumber = o.PhoneNumber
	left JOIN Discounts d ON d.DiscountCode = o.DiscountCode
go
-- Imports View
CREATE VIEW IMPORTS_VIEW
AS
	SELECT
		ips.Import_ID,
		ips.ImportDay,
		ips.Total,
		ips.Supplier_ID,
		s.CompanyName
	FROM Imports ips
	JOIN Suppliers s ON ips.Supplier_ID = s.Supplier_ID
go
Create VIEW SUPPLIER_VIEW
AS
	SELECT
		s.Supplier_ID,
		s.CompanyName,
		s.PhoneNumber,
		s.AddressSupplier,
		s.Email,
		Sum(i.Total) as Tong
	FROM Suppliers s
	Left JOIN Imports i ON i.Supplier_ID = s.Supplier_ID
	Group by
		s.Supplier_ID,
		s.CompanyName,
		s.PhoneNumber,
		s.AddressSupplier,
		s.Email
go
use QuanLyBanHangTheThao
go
CREATE FUNCTION Find_Product
(
    @BrandName NVARCHAR(50),
    @CategoryName NVARCHAR(50),
    @Name NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT Product_ID, ProductName, UnitPrice, Quantity
    FROM View_Product
    WHERE BrandName LIKE '%' + @BrandName + '%'
    AND CategoryName LIKE '%' + @CategoryName + '%'
    AND LOWER(ProductName) LIKE '%' + @Name + '%'
);
go
-- Hàm tìm kiếm khách hàng
CREATE FUNCTION Find_Customer
(
    @Phone VARCHAR(12),
    @Name NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM View_Customer
    WHERE LOWER(NameCustomer) LIKE '%' + @Name + '%'
    AND PhoneNumber LIKE '%' + @Phone + '%'
);
go
-- Hàm lấy danh sách sản phẩm của khách hàng
CREATE or alter FUNCTION ProductOfCustomer
(
    @Phone VARCHAR(12)
)
RETURNS TABLE
AS
RETURN
(
    SELECT od.Product_ID, p.ProductName, SUM(od.Quantity) AS Quantity, p.UnitPrice
    FROM OrderDetails od
    INNER JOIN Orders o ON od.Order_ID = o.Order_ID
    INNER JOIN Products p ON od.Product_ID = p.Product_ID
    WHERE o.PhoneNumber = @Phone
    GROUP BY od.Product_ID, p.ProductName, p.UnitPrice
);
go
-- Hàm tìm kiếm đơn đặt hàng
CREATE FUNCTION Find_Order
(
    @ID VARCHAR(15),
    @date VARCHAR(15)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM BILLS_VIEW
    WHERE LOWER(Order_ID) LIKE '%' + @ID + '%'
    AND CONVERT(DATE, OrderDate, 103) LIKE '%' + @date + '%'
);
go
-- Hàm lấy danh sách sản phẩm của đơn đặt hàng
CREATE FUNCTION ProductOfOrder
(
    @ID VARCHAR(15)
)
RETURNS TABLE
AS
RETURN
(
    SELECT od.Product_ID, p.ProductName, od.Quantity, p.UnitPrice
    FROM OrderDetails od
    INNER JOIN Products p ON od.Product_ID = p.Product_ID
    WHERE od.Order_ID = @ID
);
go
-- Hàm tìm kiếm nhân viên
CREATE FUNCTION Find_Employee
(
    @ID VARCHAR(12),
    @Name NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM EMPLOYEES_ACTIVE_VIEW
    WHERE LOWER(NameEmployee) LIKE '%' + @Name + '%'
    AND EmployeeID LIKE '%' + @ID + '%'
);
go
-- Hàm tìm kiếm nhà cung cấp
CREATE FUNCTION Find_Supplier
(
    @ID VARCHAR(10),
    @Name NVARCHAR(30)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM SUPPLIER_VIEW
    WHERE CompanyName LIKE '%' + @Name + '%'
    AND Supplier_ID LIKE '%' + @ID + '%'
);
go
-- Hàm lấy danh sách sản phẩm của nhà cung cấp
CREATE FUNCTION ProductOfSupplier
(
    @ID VARCHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT id.Product_ID, p.ProductName, SUM(id.Quantity) AS Quantity, id.Unitcost
    FROM ImportDetails id
    INNER JOIN Products p ON id.Product_ID = p.Product_ID
    INNER JOIN Imports i ON id.Import_ID = i.Import_ID 
    WHERE i.Supplier_ID = @ID
    GROUP BY id.Product_ID, p.ProductName, id.Unitcost
);
go
-- Hàm tìm kiếm nhập hàng
CREATE FUNCTION Find_Import
(
    @ID VARCHAR(15),
    @date VARCHAR(15)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM IMPORTS_VIEW
    WHERE LOWER(Import_ID) LIKE '%' + @ID + '%'
    AND CONVERT(DATE, ImportDay, 103) LIKE '%' + @date + '%'
);
go
-- Hàm lấy danh sách sản phẩm của nhập hàng
CREATE FUNCTION ProductOfImport
(
    @ID VARCHAR(15)
)
RETURNS TABLE
AS
RETURN
(
    SELECT id.Product_ID, p.ProductName, id.Quantity, id.Unitcost
    FROM ImportDetails id
    INNER JOIN Products p ON id.Product_ID = p.Product_ID
    WHERE id.Import_ID = @ID
);
go
CREATE FUNCTION TotalRevenue
(
    @fromDate Date,
	@toDate Date
)
RETURNS TABLE
AS
RETURN
(
   select OrderDate, SUM(Total) as Total From Orders where OrderDate between @fromDate and @toDate group by OrderDate
);
go
CREATE FUNCTION TotalProfit
(
    @fromDate Date,
	@toDate Date
)
RETURNS TABLE
AS
RETURN
(
    SELECT CAST(o.OrderDate AS DATE) AS OrderDate, SUM((p.UnitPrice - id.Unitcost) * od.Quantity) AS TotalProfit
                                    FROM  OrderDetails od
                                    JOIN Products p ON od.Product_ID = p.Product_ID
                                    JOIN ImportDetails id ON od.Product_ID = id.Product_ID
                                    JOIN Orders o ON od.Order_ID = o.Order_ID
                                    WHERE o.OrderDate BETWEEN @fromDate AND @toDate
                                    GROUP BY CAST(o.OrderDate AS DATE)
);
go
CREATE FUNCTION Top5Product
(
    @fromDate Date,
	@toDate Date
)
RETURNS TABLE
AS
RETURN
(
	Select top 5 p.ProductName,sum(od.Quantity) as Q
                    from OrderDetails od 
                    join Products p on p.Product_ID  = od.Product_ID
                    join Orders o on o.Order_ID = od.Order_ID
                    where OrderDate between  @fromDate and @toDate
                    group by p.ProductName
                    Order by Q desc
);
go



CREATE OR ALTER FUNCTION LoginCSDL
(
    @username VARCHAR(50), 
    @password VARCHAR(25)
)
RETURNS @ConnectionTable TABLE
(
    connectString VARCHAR(1000)
)
AS
BEGIN
    DECLARE @connectString VARCHAR(1000);
    
    -- Check if the username and password exist in the Employees table
    IF EXISTS (
        SELECT 1
        FROM Employees
        WHERE EmployeeID = @username AND PassWordAccount = @password
    )
    BEGIN
        -- If user exists, construct the connection string
        SET @connectString = 'Data Source=MSI\\CSDL;Initial Catalog=QuanLyBanHangTheThao;Integrated Security=False;User Id='
                            + @username + ';Password=' + @password + ';Encrypt=False';
    END
    ELSE
    BEGIN
        -- If user does not exist, set the connection string to empty or default
        SET @connectString = 'huhu'; -- or set it to your default connection string
    END

    INSERT INTO @ConnectionTable (connectString) VALUES (@connectString);
	return;
END

go
USE QuanLyBanHangTheThao

-- Stored Procedure Customer
GO
CREATE or ALTER  PROCEDURE spInsertCustomer
    @PhoneNumber VARCHAR(12),
    @NameCustomer NVARCHAR(50),
    @Birthday DATE,
    @Gender CHAR(3),
    @Point INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
		IF(@NameCustomer ='')
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
		INSERT INTO Customers (PhoneNumber, NameCustomer, Birthday, Gender, Point)
		VALUES (@PhoneNumber, @NameCustomer, @Birthday, @Gender, @Point);
		COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE or ALTER PROCEDURE spUpdateCustomer
    @PhoneNumber VARCHAR(12),
    @NameCustomer NVARCHAR(50),
    @Birthday DATE,
    @Gender CHAR(3),
    @Point INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@PhoneNumber ='' or @NameCustomer ='')
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        UPDATE Customers 
        SET NameCustomer = @NameCustomer, 
            Birthday = @Birthday, 
            Gender = @Gender, 
            Point = @Point
        WHERE PhoneNumber = @PhoneNumber;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;



GO

-- Stored Procedure Discount
GO
CREATE or ALTER PROCEDURE spInsertDiscount
    @DiscountCode VARCHAR(10),
    @PercentageDiscount INT,
    @StartDay DATE,
    @EndDay DATE
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@DiscountCode ='' or @PercentageDiscount ='' or @StartDay > @EndDay)
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        INSERT INTO Discounts (DiscountCode, PercentageDiscount, StartDay, EndDay)
        VALUES (@DiscountCode, @PercentageDiscount, @StartDay, @EndDay);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;



GO

-- Stored Procedure Employee
GO
CREATE or ALTER PROCEDURE spInsertEmployee
    @EmployeeID VARCHAR(5),
    @NameEmployee NVARCHAR(50),
    @Birthday DATE,
    @Gender CHAR(3),
    @AddressEmployee NVARCHAR(100),
    @PhoneNumber VARCHAR(12),
    @RoleEmployee NVARCHAR(50),
    @Active CHAR(1),
    @PassWordAccount VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@EmployeeID ='' or @NameEmployee ='' or @AddressEmployee ='' or @PhoneNumber ='' or @RoleEmployee ='' or @PassWordAccount ='')
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        INSERT INTO Employees (EmployeeID, NameEmployee, Birthday, Gender, AddressEmployee, PhoneNumber, RoleEmployee, Active, PassWordAccount)
        VALUES (@EmployeeID, @NameEmployee, @Birthday, @Gender, @AddressEmployee, @PhoneNumber, @RoleEmployee, @Active, @PassWordAccount);

		DECLARE @sqlString NVARCHAR(2000)

		-- Tạo tài khoản login cho nhân viên, tên người dùng và mật khẩu là tài khoản được tạo trên bảng Account

		SET @sqlString = 'CREATE LOGIN [' + @EmployeeID + '] WITH PASSWORD=''' +@PassWordAccount + ''', DEFAULT_DATABASE=[QuanLyBanHangTheThao], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'

		EXEC (@sqlString)

		-- Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)

		SET @sqlString = 'CREATE USER ' +@EmployeeID + ' FOR LOGIN ' +@EmployeeID;

		EXEC (@sqlString)

		-- Thêm người dùng vào vai trò quyền tương ứng (Staff hoặc Manager(sysadmin))

		IF (@RoleEmployee = N'Bán hàng')

			SET @sqlString = 'ALTER ROLE BanHang ADD MEMBER ' + @EmployeeID;

		ELSE
			SET @sqlString = 'ALTER SERVER ROLE sysadmin ADD MEMBER ' + @EmployeeID;
		EXEC (@sqlString)

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE or ALTER PROCEDURE spUpdateEmployee
    @EmployeeID VARCHAR(5),
    @NameEmployee NVARCHAR(50),
    @Birthday DATE,
    @Gender CHAR(3),
    @AddressEmployee NVARCHAR(100),
    @PhoneNumber VARCHAR(12),
    @RoleEmployee NVARCHAR(50),
    @Active CHAR(1),
    @PassWordAccount VARCHAR(15)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@EmployeeID ='' or @NameEmployee ='' or @AddressEmployee ='' or @PhoneNumber ='' or @RoleEmployee ='' or @PassWordAccount ='')
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        UPDATE Employees 
        SET NameEmployee = @NameEmployee, 
            Birthday = @Birthday, 
            Gender = @Gender,
            AddressEmployee = @AddressEmployee, 
            PhoneNumber = @PhoneNumber, 
            RoleEmployee = @RoleEmployee, 
            Active = @Active, 
            PassWordAccount = @PassWordAccount
        WHERE EmployeeID = @EmployeeID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;



GO
 CREATE or ALTER  PROCEDURE spDeleteEmployee
    @EmployeeID VARCHAR(5)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Employees WHERE EmployeeID = @EmployeeID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



-- Stored Import
GO
CREATE or ALTER PROCEDURE spInsertImport
    @Import_ID VARCHAR(10),
    @Supplier_ID VARCHAR(10),
    @ImportDay DATE,
    @Total INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF( @Supplier_ID ='')
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        INSERT INTO Imports (Import_ID, Supplier_ID, ImportDay, Total)
        VALUES (@Import_ID, @Supplier_ID, @ImportDay, @Total);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;

GO

-- Stored Procedure ImportDetails
GO
CREATE or ALTER PROCEDURE spInsertImportDetail
    @Import_ID VARCHAR(10),
    @Product_ID VARCHAR(15),
    @Quantity INT,
    @Unitcost INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF( @Product_ID ='')
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost)
        VALUES (@Import_ID, @Product_ID, @Quantity, @Unitcost);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;

-- Stored Procedure Order
GO
CREATE or ALTER PROCEDURE spInsertOrder
    @Order_ID VARCHAR(15),
    @PhoneNumber VARCHAR(12),
    @EmployeeID VARCHAR(5),
    @OrderDate DATE,
    @Total INT,
    @DiscountCode VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@PhoneNumber ='' )
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
		IF @DiscountCode = ''
			SET @DiscountCode = NULL;
        INSERT INTO Orders (Order_ID, PhoneNumber, EmployeeID, OrderDate, Total, DiscountCode)
        VALUES (@Order_ID, @PhoneNumber, @EmployeeID, @OrderDate, @Total, @DiscountCode);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;
go
CREATE or ALTER PROCEDURE spDeleteOrder
    @Order_ID VARCHAR(15)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Orders WHERE Order_ID = @Order_ID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;

-- Stored Procedure Order Details
GO
CREATE or ALTER PROCEDURE spInsertOrderDetail
    @Order_ID VARCHAR(15),
    @Product_ID VARCHAR(15),
    @Quantity INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@Product_ID ='' )
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        INSERT INTO OrderDetails (Order_ID, Product_ID, Quantity)
        VALUES (@Order_ID, @Product_ID, @Quantity);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;




GO
CREATE or ALTER  PROCEDURE spUpdateProduct
    @Product_ID VARCHAR(15),
    @ProductName NVARCHAR(100),
    @UnitPrice INT,
    @Quantity INT,
    @BrandName NVARCHAR(50),
    @CategoryName NVARCHAR(50),
	@Pic_ID INT
AS
BEGIN
	
	DECLARE @Brand_ID VARCHAR(10), @Category_ID VARCHAR(10)
	SELECT @Brand_ID = Brand_ID FROM Brands WHERE BrandName = @BrandName;
	SELECT @Category_ID = Category_ID FROM Categories WHERE CategoryName = @CategoryName;
    BEGIN TRANSACTION;

    BEGIN TRY
		IF (@Product_ID = '' OR @ProductName = '' OR @UnitPrice IS NULL OR @Pic_ID = '' or @CategoryName='' or @BrandName = '')
        BEGIN
            RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
			return
        END
        UPDATE Products
        SET ProductName = @ProductName,
            UnitPrice = @UnitPrice,
            Quantity = @Quantity,
            Brand_ID = @Brand_ID,
            Category_ID = @Category_ID,
			Picture_ID = @Pic_ID
        WHERE Product_ID = @Product_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;


GO


-- Stored Procedure Supplier
GO
CREATE or ALTER  PROCEDURE spInsertSupplier
    @Supplier_ID VARCHAR(10),
    @CompanyName NVARCHAR(30),
    @PhoneNumber VARCHAR(12),
    @AddressSupplier NVARCHAR(100),
    @Email VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		  IF (@Supplier_ID = '' OR @CompanyName = '' OR @PhoneNumber ='' or @AddressSupplier='' or @Email = '')
        BEGIN
            RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
			return
        END
        INSERT INTO Suppliers (Supplier_ID, CompanyName, PhoneNumber, AddressSupplier, Email)
        VALUES (@Supplier_ID, @CompanyName, @PhoneNumber, @AddressSupplier, @Email);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE or ALTER PROCEDURE spUpdateSupplier
    @Supplier_ID VARCHAR(10),
    @CompanyName NVARCHAR(30),
    @PhoneNumber VARCHAR(12),
    @AddressSupplier NVARCHAR(100),
    @Email VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF (@Supplier_ID = '' OR @CompanyName = '' OR @PhoneNumber = '' or @AddressSupplier='' or @Email = '')
        BEGIN
            RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
			return
        END
        UPDATE Suppliers
        SET CompanyName = @CompanyName,
            PhoneNumber = @PhoneNumber,
            AddressSupplier = @AddressSupplier,
            Email = @Email
        WHERE Supplier_ID = @Supplier_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;


GO


CREATE or ALTER PROCEDURE spInsertProduct
    @Product_ID VARCHAR(15),
    @ProductName NVARCHAR(100),
    @UnitPrice INT,
    @Quantity INT,
    @BrandName NVARCHAR(10),
    @CategoryName NVARCHAR(10),
	@Pic_Name VARCHAR(100)
AS
BEGIN
 BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @Brand_ID VARCHAR(10), @Category_ID VARCHAR(10), @Pic_ID INT
		SELECT @Brand_ID = Brand_ID FROM Brands WHERE BrandName like N'%'+@BrandName+'%';
		SELECT @Category_ID = Category_ID FROM Categories WHERE CategoryName like N'%'+@CategoryName+'%';
		SELECT @Pic_ID = Picture_ID FROM PictureProduct WHERE @Pic_Name like @Pic_Name;
		IF (@Product_ID = '' OR @ProductName = '' OR @UnitPrice IS NULL OR @Pic_Name = '' or @CategoryName='' or @BrandName = '')
        BEGIN
            RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
			return
        END
		INSERT INTO Products (Product_ID, ProductName, UnitPrice, Quantity, Brand_ID, Category_ID, Picture_ID)
		VALUES (@Product_ID, @ProductName, @UnitPrice, @Quantity, @Brand_ID, @Category_ID, @Pic_ID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: '  + ERROR_MESSAGE();
		RAISERROR(@err, 16, 1)
		ROLLBACK TRANSACTION;
    END CATCH
END;
go
USE QuanLyBanHangTheThao;
GO

-- Tạo vai trò BanHang
CREATE ROLE BanHang;
GO

GRANT SELECT, REFERENCES ON Employees TO BanHang;
GRANT SELECT, INSERT, UPDATE, REFERENCES ON Customers TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON Orders TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON OrderDetails TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON Products TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON Brands TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON Categories TO BanHang;
GRANT SELECT, REFERENCES ON Suppliers TO BanHang;

-- Cấp quyền EXECUTE cho vai trò BanHang
GRANT EXECUTE TO BanHang;
DENY EXECUTE ON spDeleteEmployee TO BanHang;
DENY EXECUTE ON spInsertEmployee TO BanHang;
DENY EXECUTE ON spDeleteOrder TO BanHang;
DENY EXECUTE ON spInsertSupplier TO BanHang;
DENY EXECUTE ON spUpdateSupplier TO BanHang;
DENY EXECUTE ON spInsertImportDetail TO BanHang;

-- Cấp quyền SELECT cho các hàm
GRANT SELECT TO BanHang;
DENY SELECT ON Find_Supplier TO BanHang;
DENY SELECT ON ProductOfSupplier TO BanHang;
DENY SELECT ON Find_Import TO BanHang;
DENY SELECT ON ProductOfImport TO BanHang;

-- Cấp quyền SELECT cho các view trừ IMPORTS_VIEW và SUPPLIER_VIEW
GRANT SELECT ON View_Product TO BanHang;
GRANT SELECT ON View_Customer TO BanHang;
GRANT SELECT ON EMPLOYEES_ACTIVE_VIEW TO BanHang;
GRANT SELECT ON BILLS_VIEW TO BanHang;

DENY SELECT ON EMPLOYEES_All_VIEW TO BanHang;
go
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
--Update Products set Picture_ID = 16 where ProductName like N'%Pro Kennex Power Pro 705%'
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
