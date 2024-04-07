USE QuanLyBanHangTheThao

-- Stored Procedure Customer
GO
CREATE PROCEDURE spInsertCustomer
    @PhoneNumber VARCHAR(12),
    @NameCustomer NVARCHAR(50),
    @Birthday DATE,
    @Gender CHAR(3),
    @Point INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        INSERT INTO Customers (PhoneNumber, NameCustomer, Birthday, Gender, Point)
        VALUES (@PhoneNumber, @NameCustomer, @Birthday, @Gender, @Point);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spUpdateCustomer
    @PhoneNumber VARCHAR(12),
    @NameCustomer NVARCHAR(50),
    @Birthday DATE,
    @Gender CHAR(3),
    @Point INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Customers 
        SET NameCustomer = @NameCustomer, 
            Birthday = @Birthday, 
            Gender = @Gender, 
            Point = @Point
        WHERE PhoneNumber = @PhoneNumber;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spDeleteCustomer
    @PhoneNumber VARCHAR(12)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Customers WHERE PhoneNumber = @PhoneNumber;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



-- Stored Procedure Discount
GO
CREATE PROCEDURE spInsertDiscount
    @DiscountCode VARCHAR(10),
    @PercentageDiscount INT,
    @StartDay DATE,
    @EndDay DATE
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Discounts (DiscountCode, PercentageDiscount, StartDay, EndDay)
        VALUES (@DiscountCode, @PercentageDiscount, @StartDay, @EndDay);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spUpdateDiscount
    @DiscountCode VARCHAR(10),
    @PercentageDiscount INT,
    @StartDay DATE,
    @EndDay DATE
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Discounts 
        SET PercentageDiscount = @PercentageDiscount, 
            StartDay = @StartDay, 
            EndDay = @EndDay
        WHERE DiscountCode = @DiscountCode;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spDeleteDiscount
    @DiscountCode VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Discounts WHERE DiscountCode = @DiscountCode;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



-- Stored Procedure Employee
GO
CREATE PROCEDURE spInsertEmployee
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
        INSERT INTO Employees (EmployeeID, NameEmployee, Birthday, Gender, AddressEmployee, PhoneNumber, RoleEmployee, Active, PassWordAccount)
        VALUES (@EmployeeID, @NameEmployee, @Birthday, @Gender, @AddressEmployee, @PhoneNumber, @RoleEmployee, @Active, @PassWordAccount);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spUpdateEmployee
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
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spDeleteEmployee
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
CREATE PROCEDURE spInsertImport
    @Import_ID VARCHAR(10),
    @Supplier_ID VARCHAR(10),
    @ImportDay DATE,
    @Total INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Imports (Import_ID, Supplier_ID, ImportDay, Total)
        VALUES (@Import_ID, @Supplier_ID, @ImportDay, @Total);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spUpdateImport
    @Import_ID VARCHAR(10),
    @Supplier_ID VARCHAR(10),
    @ImportDay DATE,
    @Total INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Imports
        SET Supplier_ID = @Supplier_ID,
            ImportDay = @ImportDay,
            Total = @Total
        WHERE Import_ID = @Import_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spDeleteImport
    @Import_ID VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Imports WHERE Import_ID = @Import_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



-- Stored Procedure ImportDetails
GO
CREATE PROCEDURE spInsertImportDetail
    @Import_ID VARCHAR(10),
    @Product_ID VARCHAR(15),
    @Quantity INT,
    @Unitcost INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO ImportDetails (Import_ID, Product_ID, Quantity, Unitcost)
        VALUES (@Import_ID, @Product_ID, @Quantity, @Unitcost);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spUpdateImportDetail
    @Import_ID VARCHAR(10),
    @Product_ID VARCHAR(15),
    @Quantity INT,
    @Unitcost INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE ImportDetails
        SET Quantity = @Quantity,
            Unitcost = @Unitcost
        WHERE Import_ID = @Import_ID AND Product_ID = @Product_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



GO
CREATE PROCEDURE spDeleteImportDetail
    @Import_ID VARCHAR(10),
    @Product_ID VARCHAR(15)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM ImportDetails WHERE Import_ID = @Import_ID AND Product_ID = @Product_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



-- Stored Procedure Order
GO
CREATE PROCEDURE spInsertOrder
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
        INSERT INTO Orders (Order_ID, PhoneNumber, EmployeeID, OrderDate, Total, DiscountCode)
        VALUES (@Order_ID, @PhoneNumber, @EmployeeID, @OrderDate, @Total, @DiscountCode);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spUpdateOrder
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
        UPDATE Orders
        SET PhoneNumber = @PhoneNumber,
            EmployeeID = @EmployeeID,
            OrderDate = @OrderDate,
            Total = @Total,
            DiscountCode = @DiscountCode
        WHERE Order_ID = @Order_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spDeleteOrder
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
CREATE PROCEDURE spInsertOrderDetail
    @Order_ID VARCHAR(15),
    @Product_ID VARCHAR(15),
    @Quantity INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO OrderDetails (Order_ID, Product_ID, Quantity)
        VALUES (@Order_ID, @Product_ID, @Quantity);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spUpdateOrderDetail
    @Order_ID VARCHAR(15),
    @Product_ID VARCHAR(15),
    @Quantity INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE OrderDetails
        SET Quantity = @Quantity
        WHERE Order_ID = @Order_ID AND Product_ID = @Product_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spDeleteOrderDetail
    @Order_ID VARCHAR(15),
    @Product_ID VARCHAR(15)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM OrderDetails WHERE Order_ID = @Order_ID AND Product_ID = @Product_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



-- Stored Proc Product
GO
Alter PROCEDURE spInsertProduct
    @Product_ID VARCHAR(15),
    @ProductName NVARCHAR(100),
    @UnitPrice INT,
    @Quantity INT,
    @BrandName VARCHAR(10),
    @CategoryName VARCHAR(10),
	@Pic_Name VARCHAR(100)
AS
BEGIN
	DECLARE @Brand_ID VARCHAR(10), @Category_ID VARCHAR(10), @Pic_ID INT
	SELECT @Brand_ID = Brand_ID FROM Brands WHERE BrandName =  @BrandName;
	SELECT @Category_ID = Category_ID FROM Categories WHERE CategoryName = @CategoryName;
	SELECT @Pic_ID = Pic_ID FROM PictureProduct WHERE @Pic_Name = @Pic_Name;
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Products (Product_ID, ProductName, UnitPrice, Quantity, Brand_ID, Category_ID, Picture_ID)
        VALUES (@Product_ID, @ProductName, @UnitPrice, @Quantity, @Brand_ID, @Category_ID, @Pic_ID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;




GO
CREATE PROCEDURE spUpdateProduct
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
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spDeleteProduct
    @Product_ID VARCHAR(15)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Products WHERE Product_ID = @Product_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;

-- Stored Procedure Supplier
GO
CREATE PROCEDURE spInsertSupplier
    @Supplier_ID VARCHAR(10),
    @CompanyName NVARCHAR(30),
    @PhoneNumber VARCHAR(12),
    @AddressSupplier NVARCHAR(100),
    @Email VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Suppliers (Supplier_ID, CompanyName, PhoneNumber, AddressSupplier, Email)
        VALUES (@Supplier_ID, @CompanyName, @PhoneNumber, @AddressSupplier, @Email);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spUpdateSupplier
    @Supplier_ID VARCHAR(10),
    @CompanyName NVARCHAR(30),
    @PhoneNumber VARCHAR(12),
    @AddressSupplier NVARCHAR(100),
    @Email VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE Suppliers
        SET CompanyName = @CompanyName,
            PhoneNumber = @PhoneNumber,
            AddressSupplier = @AddressSupplier,
            Email = @Email
        WHERE Supplier_ID = @Supplier_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


GO
CREATE PROCEDURE spDeleteSupplier
    @Supplier_ID VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DELETE FROM Suppliers WHERE @Supplier_ID = @Supplier_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;



CREATE PROCEDURE spInsertProduct
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
		SELECT @Pic_ID = Pic_ID FROM PictureProduct WHERE @Pic_Name like @Pic_Name;
		INSERT INTO Products (Product_ID, ProductName, UnitPrice, Quantity, Brand_ID, Category_ID, Picture_ID)
		VALUES (@Product_ID, @ProductName, @UnitPrice, @Quantity, @Brand_ID, @Category_ID, @Pic_ID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;
