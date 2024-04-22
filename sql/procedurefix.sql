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
CREATE or ALTER PROCEDURE spUpdateDiscount
    @DiscountCode VARCHAR(10),
    @PercentageDiscount INT,
    @StartDay DATE,
    @EndDay DATE
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		IF(@DiscountCode ='' or @PercentageDiscount IS NULL or @StartDay > @EndDay)
			BEGIN
				RAISERROR(N'Vui lòng nhập chính xác, đầy đủ thông tin', 16, 1)
				return
			END
        UPDATE Discounts 
        SET PercentageDiscount = @PercentageDiscount, 
            StartDay = @StartDay, 
            EndDay = @EndDay
        WHERE DiscountCode = @DiscountCode;

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
CREATE or ALTER PROCEDURE spDeleteDiscount
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
go
CREATE or ALTER PROCEDURE spDeleteImport
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

EXECUTE spDeleteOrder 'HD00012'
GO
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
