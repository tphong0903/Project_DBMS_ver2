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
GRANT SELECT ON Find_Product TO BanHang;
GRANT SELECT ON Find_Customer TO BanHang;
GRANT SELECT ON ProductOfCustomer TO BanHang;
GRANT SELECT ON Find_Order TO BanHang;
GRANT SELECT ON ProductOfOrder TO BanHang;
GRANT SELECT ON Find_Employee TO BanHang;
GRANT SELECT ON TotalRevenue TO BanHang;
GRANT SELECT ON TotalProfit TO BanHang;
GRANT SELECT ON Top5Product TO BanHang;
GRANT SELECT ON LoginCSDL TO BanHang;

DENY SELECT ON Find_Supplier TO BanHang;
DENY SELECT ON ProductOfSupplier TO BanHang;
DENY SELECT ON Find_Import TO BanHang;
DENY SELECT ON ProductOfImport TO BanHang;

-- Cấp quyền SELECT cho các view trừ IMPORTS_VIEW và SUPPLIER_VIEW
GRANT SELECT ON View_Product TO BanHang;
GRANT SELECT ON View_Customer TO BanHang;
GRANT SELECT ON EMPLOYEES_ACTIVE_VIEW TO BanHang;
GRANT SELECT ON EMPLOYEES_All_VIEW TO BanHang;
GRANT SELECT ON BILLS_VIEW TO BanHang;