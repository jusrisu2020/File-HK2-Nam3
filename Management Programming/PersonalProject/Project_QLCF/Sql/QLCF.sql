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




-------------------------------------------------Insert FoodCategory---------------------
INSERT INTO dbo.FoodCategory (nameCF) VALUES (N'Hải sản')
INSERT INTO dbo.FoodCategory (nameCF) VALUES (N'Nông sản')
INSERT INTO dbo.FoodCategory (nameCF) VALUES (N'Lâm sản')
INSERT INTO dbo.FoodCategory (nameCF) VALUES (N'Sản sản')
INSERT INTO dbo.FoodCategory (nameCF) VALUES (N'Nước')

-------------------------------------------------Insert Food---------------------
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (   N'Mực chiên nước mắm',120000.0, 1)
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (	 N'Ngêu hấp xả',3000.0, 1)
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (   N'Dú dê nướng sữa',3000.0, 2)
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (	 N'Heo rừng nướng muối ớt',3000.0, 3)
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (	 N'Cơm chiên Mushi',3000.0, 4)
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (	 N'7Up',3000.0, 5)
INSERT INTO dbo.Food (nameFood,price,idFCategory) VALUES (	 N'Caphe',3000.0, 5)

-------------------------------------------------Insert Bill---------------------
INSERT INTO dbo.Bill (DataCheckIn,DateCheckOut,idTable,status) VALUES (GETDATE(),NULL,3,0)
INSERT INTO dbo.Bill (DataCheckIn,DateCheckOut,idTable,status) VALUES (GETDATE(),GETDATE(),4,0)
INSERT INTO dbo.Bill (DataCheckIn,DateCheckOut,idTable,status) VALUES (GETDATE(),GETDATE(),5,1)
-------------------------------------------------Insert BillInfo---------------------
INSERT INTO dbo.BillInfo (idBill,idFood,count) VALUES (1,1,2)
INSERT INTO dbo.BillInfo (idBill,idFood,count) VALUES (1,3,4)
INSERT INTO dbo.BillInfo (idBill,idFood,count) VALUES (2,6,2)
INSERT INTO dbo.BillInfo (idBill,idFood,count) VALUES (3,5,2)



SELECT * FROM Account;
SELECT * FROM Bill;
SELECT * FROM BillInfo;
SELECT * FROM Food;
SELECT * FROM FoodCategory;
SELECT * FROM dbo.TableFood;

SELECT * FROM Bill WHERE idTable = 3 AND status = 0

SELECT * FROM BillInfo WHERE idBill = 1

