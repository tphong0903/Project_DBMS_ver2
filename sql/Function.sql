-- Hàm tìm kiếm sản phẩm
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
