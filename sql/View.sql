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