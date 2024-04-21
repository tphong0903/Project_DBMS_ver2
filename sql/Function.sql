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

