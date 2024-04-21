USE master;
DROP DATABASE IF EXISTS QuanLyBanHangTheThao;

CREATE DATABASE QuanLyBanHangTheThao;

GO
USE QuanLyBanHangTheThao;

GO
CREATE TABLE Customers (
	PhoneNumber VARCHAR(12) CONSTRAINT PhoneKey PRIMARY KEY,
	NameCustomer NVARCHAR(50) NOT NULL,
	Birthday DATE,
	Gender CHAR(3) NOT NULL CONSTRAINT GenderCheck_Customer CHECK (GENDER IN ('Nam', 'Nu')),
	Point INT,
	CONSTRAINT PhoneNumber_Customer CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber LIKE '%[0-9]%')
);

CREATE TABLE Employees (
	EmployeeID VARCHAR(5) CONSTRAINT EmployeeIDKey PRIMARY KEY,
	NameEmployee NVARCHAR(50) NOT NULL,
	Birthday DATE,
	Gender CHAR(3) NOT NULL CONSTRAINT GenderCheck_Employee CHECK (GENDER IN ('Nam', 'Nu')),
	AddressEmployee NVARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(12) NOT NULL,
	RoleEmployee NVARCHAR(50) NOT NULL,
	Active CHAR(1) NOT NULL,
	PassWordAccount VARCHAR(10) NOT NULL,
	CONSTRAINT PhoneNumber_Employee CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber LIKE '%[0-9]%'),
	CONSTRAINT LengthPassWordAccount CHECK (LEN(PassWordAccount) >= 6)
);

CREATE TABLE Brands (
	Brand_ID VARCHAR(10) CONSTRAINT Brand_IDKey PRIMARY KEY,
	BrandName NVARCHAR(50) NOT NULL
);

CREATE TABLE Categories (
	Category_ID VARCHAR(10) CONSTRAINT Category_IDKey PRIMARY KEY,
	CategoryName NVARCHAR(50) NOT NULL
);

CREATE TABLE Discounts (
	DiscountCode VARCHAR(10) CONSTRAINT DiscountCodeKey PRIMARY KEY,
	PercentageDiscount INT NOT NULL,
	StartDay DATE NOT NULL,
	EndDay DATE NOT NULL
);

CREATE TABLE Suppliers (
	Supplier_ID VARCHAR(10) CONSTRAINT Supplier_IDKey PRIMARY KEY,
	CompanyName NVARCHAR(30) NOT NULL,
	PhoneNumber VARCHAR(12) CONSTRAINT PhoneNumber_Supplier CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber LIKE '%[0-9]%'),
	AddressSupplier NVARCHAR(100) NOT NULL,
	Email VARCHAR(50)
);

CREATE TABLE Imports (
	Import_ID VARCHAR(10) CONSTRAINT Import_IDKey PRIMARY KEY,
	Supplier_ID VARCHAR(10) Not null ,
	ImportDay DATE NOT NULL,
	Total INT NOT NULL,
	CONSTRAINT FK_Supplier_Import FOREIGN KEY (Supplier_ID)
			REFERENCES Suppliers(Supplier_ID) On Update Cascade
);

CREATE TABLE Orders (
	Order_ID VARCHAR(15) CONSTRAINT Order_IDKey PRIMARY KEY,
	PhoneNumber VARCHAR(12) NOT NULL,
	EmployeeID VARCHAR(5) NOT NULL,
	OrderDate DATE NOT NULL,
	Total INT NOT NULL,
	DiscountCode VARCHAR(10),
	CONSTRAINT PhoneNumber_Orders CHECK (LEN(PhoneNumber) = 10 AND PhoneNumber LIKE '%[0-9]%'),
	CONSTRAINT FK_PhoneNumber_Orders FOREIGN KEY (PhoneNumber)
			REFERENCES Customers(PhoneNumber) On Update Cascade,
	CONSTRAINT FK_Employee_Orders FOREIGN KEY (EmployeeID)
			REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_Discount_Order FOREIGN KEY (DiscountCode)
			REFERENCES Discounts(DiscountCode) 
);

CREATE TABLE PictureProduct (
	Picture_ID INT IDENTITY(1,1) PRIMARY KEY,
	Picture_Name varchar(100) 
);

CREATE TABLE Products (
	Product_ID VARCHAR(15) CONSTRAINT Product_IDKey PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL,
	UnitPrice INT NOT NULL,
	Quantity INT NOT NULL,
	Brand_ID VARCHAR(10) NOT NULL,
	Category_ID VARCHAR(10) NOT NULL,
	Picture_ID int 
	CONSTRAINT FK_Brand_Product FOREIGN KEY (Brand_ID)
			REFERENCES Brands(Brand_ID) ,
	CONSTRAINT FK_Category_Product FOREIGN KEY (Category_ID)
			REFERENCES Categories(Category_ID),
	 CONSTRAINT FK_Picture_Product FOREIGN KEY (Picture_ID)
			REFERENCES PictureProduct(Picture_ID)
);

CREATE TABLE OrderDetails (
	Order_ID VARCHAR(15) NOT NULL,
	Product_ID VARCHAR(15) NOT NULL,
	Quantity INT NOT NULL,
	CONSTRAINT FK_Order_OrderDetail FOREIGN KEY (Order_ID)
			REFERENCES Orders(Order_ID) ON DELETE CASCADE,
	CONSTRAINT FK_Product_OrderDetail FOREIGN KEY (Product_ID)
			REFERENCES Products(Product_ID) ON UPDATE CASCADE,
	CONSTRAINT OrderDetail_IDKey PRIMARY KEY (Order_ID , Product_ID)
);

CREATE TABLE ImportDetails (
	Import_ID VARCHAR(10),
	Product_ID VARCHAR(15),
	Quantity INT NOT NULL,
	Unitcost INT NOT NULL,
	CONSTRAINT FK_Import_ImportDetail FOREIGN KEY (Import_ID)
			REFERENCES Imports(Import_ID) ON DELETE CASCADE,
	CONSTRAINT FK_Product_ImportDetail FOREIGN KEY (Product_ID)
			REFERENCES Products(Product_ID),
	CONSTRAINT ImportDetail_IDKey PRIMARY KEY (Import_ID , Product_ID)
);
