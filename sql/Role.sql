USE QuanLyBanHangTheThao
GO

CREATE ROLE BanHang;

GRANT SELECT, REFERENCES ON Employees TO BanHang;
GRANT SELECT, INSERT, UPDATE, REFERENCES ON Customers TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON Orders TO BanHang;
GRANT SELECT, INSERT, REFERENCES ON Products TO BanHang;

GRANT EXECUTE TO BanHang;
DENY EXECUTE ON spDeleteEmployee to BanHang;