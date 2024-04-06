use QuanLyBanHangTheThao
go
-- CẬP NHẬT TỔNG TIỀN HÓA ĐƠN IMPORT
-- Khi thêm vào chi tiết nhập
CREATE TRIGGER UpdateTotalImport_InsertImportDetails ON [dbo].[ImportDetails]
AFTER INSERT
AS
BEGIN
    DECLARE @Import_ID VARCHAR(10)
    SELECT @Import_ID = Import_ID FROM inserted
    UPDATE Imports
    SET Total = Total + (SELECT SUM(Quantity * Unitcost) FROM inserted WHERE Import_ID = @Import_ID)
    WHERE Import_ID = @Import_ID
END
GO

-- Khi xóa khỏi chi tiết nhập
CREATE TRIGGER UpdateTotalImport_DeleteImportDetails ON [dbo].[ImportDetails]
AFTER DELETE
AS
BEGIN
    DECLARE @table TABLE(Import_ID VARCHAR(10), Quantity INT, Unitcost INT)
    INSERT INTO @table SELECT Import_ID, Quantity, Unitcost FROM deleted
    UPDATE [dbo].[Imports] SET [dbo].[Imports].[Total] = [dbo].[Imports].[Total] - T.Quantity * T.Unitcost
    FROM [dbo].[Imports] INNER JOIN @table AS T ON [dbo].[Imports].[Import_ID] = T.Import_ID
END
GO

-- Khi chỉnh sửa chi tiết nhập
CREATE TRIGGER UpdateTotalImport_UpdateImportDetails ON [dbo].[ImportDetails]
AFTER UPDATE
AS
BEGIN
    DECLARE @tableNew TABLE(Import_ID VARCHAR(10), Quantity INT, Unitcost INT)
    INSERT INTO @tableNew SELECT Import_ID, Quantity, Unitcost FROM inserted
    DECLARE @tableOld TABLE(Import_ID VARCHAR(10), Quantity INT, Unitcost INT)
    INSERT INTO @tableOld SELECT Import_ID, Quantity, Unitcost FROM deleted
    UPDATE [dbo].[Imports] SET [dbo].[Imports].[Total] = [dbo].[Imports].[Total] +
                    TN.Quantity * TN.Unitcost - TBO.Quantity * TBO.Unitcost
    FROM [dbo].[Imports] INNER JOIN @tableNew AS TN ON [dbo].[Imports].[Import_ID] = TN.Import_ID 
                    INNER JOIN @tableOld TBO ON [dbo].[Imports].[Import_ID] = TBO.Import_ID
END
GO

-- CẬP NHẬT SỐ LƯỢNG SẢN PHẨM KHI IMPORT
-- Khi nhập
CREATE TRIGGER UpdateQuantityProduct_InsertImportDetails ON [dbo].[ImportDetails]
AFTER INSERT
AS
BEGIN
    DECLARE @table TABLE(Product_ID VARCHAR(15), Quantity INT)
    INSERT INTO @table SELECT Product_ID, Quantity FROM inserted
    UPDATE [dbo].[Products] SET [dbo].[Products].[Quantity] = [dbo].[Products].[Quantity] + T.Quantity
    FROM [dbo].[Products] INNER JOIN @table T ON [dbo].[Products].[Product_ID] = T.Product_ID
END
GO

-- Khi xóa
CREATE TRIGGER UpdateQuantityProduct_DeleteImportDetails ON [dbo].[ImportDetails]
AFTER DELETE
AS
BEGIN
    DECLARE @table TABLE(Product_ID VARCHAR(15), Quantity INT)
    INSERT INTO @table SELECT Product_ID, Quantity FROM deleted
    UPDATE [dbo].[Products] SET [dbo].[Products].[Quantity] = [dbo].[Products].[Quantity] - T.Quantity
    FROM [dbo].[Products] INNER JOIN @table T ON [dbo].[Products].[Product_ID] = T.Product_ID
END
GO

-- Khi chỉnh sửa
CREATE TRIGGER UpdateQuantityProduct_UpdateImportDetails ON [dbo].[ImportDetails]
AFTER UPDATE
AS
BEGIN
    DECLARE @tableNew TABLE(Product_ID VARCHAR(15), Quantity INT)
    INSERT INTO @tableNew SELECT Product_ID, Quantity FROM inserted
    DECLARE @tableOld TABLE(Product_ID VARCHAR(15), Quantity INT)
    INSERT INTO @tableOld SELECT Product_ID, Quantity FROM deleted
    UPDATE [dbo].[Products] SET [dbo].[Products].[Quantity] = [dbo].[Products].[Quantity] - TBO.Quantity + TBN.Quantity
    FROM [dbo].[Products] INNER JOIN @tableOld TBO ON [dbo].[Products].[Product_ID] = TBO.Product_ID
        INNER JOIN @tableNew TBN ON [dbo].[Products].[Product_ID] = TBN.Product_ID
END
GO

-- CẬP NHẬT SỐ LƯỢNG SP KHI THÊM, XÓA, SỬA CHI TIẾT HÓA ĐƠN
CREATE TRIGGER UpdateQuantityProduct_IDOrdersDetails ON OrderDetails
FOR INSERT, DELETE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        IF EXISTS(SELECT 1 FROM inserted)
            BEGIN 
                IF EXISTS (SELECT 1 FROM Products p, inserted i WHERE p.Product_ID = i.Product_ID AND p.Quantity < i.Quantity)
                    BEGIN
                        RAISERROR(N'Sản phẩm không đủ để bán', 16, 1)
                        ROLLBACK TRANSACTION
                        RETURN
                    END
                ELSE
                    BEGIN
                        UPDATE Products SET Quantity = p.Quantity - i.Quantity
                        FROM Products p ,inserted i WHERE p.Product_ID = i.Product_ID
                    END
            END
        ELSE
            BEGIN 
                UPDATE Products SET Quantity = p.Quantity + d.Quantity
                FROM Products p ,deleted d WHERE p.Product_ID = d.Product_ID
            END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
GO

-- CẬP NHẬT TỔNG TIỀN HÓA ĐƠN KHI THÊM, XÓA, SỬA CHI TIẾT HÓA ĐƠN
CREATE TRIGGER UpdateTotalOrderBill ON OrderDetails
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Cập nhật tổng tiền hóa đơn cho mỗi hóa đơn được thêm
        UPDATE o
        SET o.Total = ISNULL((SELECT SUM(p.UnitPrice * od.Quantity)
                              FROM OrderDetails od
                              INNER JOIN Products p ON od.Product_ID = p.Product_ID
                              WHERE od.Order_ID = o.Order_ID), 0)
        FROM Orders o
        JOIN inserted i ON o.Order_ID = i.Order_ID;

        -- Cập nhật tổng tiền hóa đơn cho mỗi hóa đơn bị xóa hoặc được sửa
        UPDATE o
        SET o.Total = ISNULL((SELECT SUM(p.UnitPrice * od.Quantity)
                              FROM OrderDetails od
                              INNER JOIN Products p ON od.Product_ID = p.Product_ID
                              WHERE od.Order_ID = o.Order_ID), 0)
        FROM Orders o
        JOIN deleted d ON o.Order_ID = d.Order_ID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
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
    BEGIN TRY
        BEGIN TRANSACTION;
        UPDATE Employees SET Active = 0 FROM Employees e, deleted d WHERE e.EmployeeID = d.EmployeeID
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
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
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @DateOrder DATE
        DECLARE @DateEnd DATE
        DECLARE @DateStart DATE
        DECLARE @Code VARCHAR(10)
        SELECT @DateOrder = OrderDate, @Code = DiscountCode FROM inserted
        SELECT @DateStart = StartDay, @DateEnd = EndDay FROM Discounts d WHERE d.DiscountCode = @Code 
        IF (@DateOrder > @DateEnd OR @DateOrder < @DateStart)
            BEGIN
                RAISERROR(N'Mã khuyến mãi hết hạn', 16, 1)
                ROLLBACK TRANSACTION
                RETURN
            END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END



CREATE TRIGGER trg_Customers_UpdateDeleteInsert
ON Customers
AFTER INSERT, UPDATE, DELETE
AS
BEGIN

    DELETE FROM View_Customer;

    -- Thêm lại dữ liệu mới từ bảng Customers và Orders vào view customer
    INSERT INTO View_Customer (PhoneNumber, NameCustomer, Birthday, Gender, Point, Tong)
    SELECT 
        c.[PhoneNumber],
        c.[NameCustomer],
        c.[Birthday],
        c.[Gender],
        c.[Point],
        ISNULL(SUM(o.[Amount]), 0) AS Tong
    FROM 
        Customers c
    LEFT JOIN 
        Orders o ON c.[PhoneNumber] = o.[CustomerPhoneNumber]
    GROUP BY 
        c.[PhoneNumber],
        c.[NameCustomer],
        c.[Birthday],
        c.[Gender],
        c.[Point];
END;
