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
/*alter TRIGGER UpdateTotal_IUD_OrdersDetails ON OrderDetails
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @Total INT 
        DECLARE @Discount INT
        DECLARE @table1 TABLE(Product_ID VARCHAR(15), Quantity INT, UnitPrice INT)
        IF EXISTS(SELECT 1 FROM inserted)
            BEGIN 
                INSERT INTO @table1 SELECT o.Product_ID, o.Quantity, UnitPrice FROM inserted i, OrderDetails o, Products p  WHERE o.Product_ID = p.Product_ID AND o.Order_ID = i.Order_ID
                SELECT @Total = SUM(Quantity * UnitPrice) FROM @table1
                IF EXISTS(SELECT 1 FROM Orders o, inserted i WHERE o.Order_ID = i.Order_ID AND o.DiscountCode IS NULL)
                    SET @Discount = 0
                ELSE
                    BEGIN
                        SELECT @Discount = PercentageDiscount FROM Discounts d, Orders o, inserted i WHERE o.Order_ID = i.Order_ID AND o.DiscountCode = d.DiscountCode
                    END
                UPDATE Orders SET Total = @Total * (1 - @Discount) FROM Orders o, inserted i WHERE o.Order_ID = i.Order_ID
            END
        ELSE
            BEGIN 
                INSERT INTO @table1 SELECT o.Product_ID, o.Quantity, UnitPrice FROM deleted d, OrderDetails o, Products p WHERE o.Product_ID = p.Product_ID AND o.Order_ID = d.Order_ID
                SELECT @Total = SUM(Quantity * UnitPrice) FROM @table1
                IF EXISTS(SELECT 1 FROM Orders o, deleted d WHERE o.Order_ID = d.Order_ID AND o.DiscountCode IS NULL)
                    SET @Discount = 0
                ELSE
                    BEGIN
                        SELECT @Discount = PercentageDiscount FROM Discounts d, Orders o, deleted de WHERE o.Order_ID = de.Order_ID AND o.DiscountCode = d.DiscountCode
                    END
                UPDATE Orders SET Total = @Total * (1 - @Discount) FROM Orders o, deleted d WHERE o.Order_ID = d.Order_ID
            END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
GO*/ 

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
