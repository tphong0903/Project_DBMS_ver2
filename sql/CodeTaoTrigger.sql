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
CREATE TRIGGER UpdateTotalOrderBill ON OrderDetails
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
