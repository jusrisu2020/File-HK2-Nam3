CREATE DATABASE QLCF
GO

USE QLCF
GO

CREATE TABLE TableFood
(
	id int identity primary key,
	nametext nvarchar(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
	status nvarchar(100) NOT NULL DEFAULT N'Trống',  -- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) NOT NULL DEFAULT N'TUser1',
	PassWord nvarchar(100) NOT NULL DEFAULT 0,
	Type int NOT NULL DEFAULT 0 --1 là admin && 0 là staff
)
GO

CREATE TABLE FoodCategory
(
	id int identity primary key,
	nameCF nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id int identity primary key,
	nameFood nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	price float NOT NULL DEFAULT 0, 
	idFCategory int NOT NULL
	foreign key (idFCategory) references FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id int identity primary key,
	DataCheckIn Date NOT NULL DEFAULT GETDATE(),
	DateCheckOut Date,
	idTable int NOT NULL,
	status int NOT NULL DEFAULT 0, --1: thanh toán  || 0: chưa thanh toán
	foreign key (idTable) references TableFood(id)
)
GO
CREATE TABLE BillInfo
(
	id int identity primary key,
	idBill int NOT NULL,
	idFood int NOT NULL,
	count int NOT NULL DEFAULT 0
	foreign key (idBill) references Bill(id),
	foreign key (idFood) references Food(id)
)
GO

CREATE PROC USPInsertAccount
@userName nvarchar(100), @displayName nvarchar(100), @passWord nvarchar(100), @type int
AS
BEGIN
	INSERT INTO Account(UserName,DisplayName,PassWord,Type) VALUES (@userName,@displayName,@passWord,@type)
END
EXEC USPInsertAccount N'ad1', N'ad1', N'1', 1
GO


CREATE PROC USPAccount
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE @userName = UserName and @passWord = Password
END
GO
EXEC USPAccount N'ad1', N'1'


DECLARE @i INT = 1

WHILE @i <= 10
BEGIN
	INSERT TableFood (nametext) VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USPTableFood
AS SELECT * FROM TableFood
GO
EXEC USPTableFood

UPDATE TableFood SET status = N'Có Khách' WHERE id = 1

DBCC CHECKIDENT ('TableFood', RESEED, 0)
DELETE FROM TableFood

SELECT * FROM Account;
SELECT * FROM FoodCategory;
SELECT * FROM Food;

SELECT * FROM Bill;
SELECT * FROM BillInfo;