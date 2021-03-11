CREATE DATABASE QLCF
GO

USE QLCF
GO
-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id int identity primary key,
	nametext nvarchar(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
	status nvarchar(100) NOT NULL DEFAULT N'Trống',  -- Trống || Có người
)
go

CREATE TABLE Account
(
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) NOT NULL DEFAULT N'TUser1',
	PassWord nvarchar(1000) NOT NULL DEFAULT 0,
	Type int NOT NULL DEFAULT 0 --1 là admin && 0 là staff
)
go

CREATE TABLE FoodCategory
(
	id int identity primary key,
	nameCF nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
go

CREATE TABLE Food
(
	id int identity primary key,
	nameFood nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	price float NOT NULL DEFAULT 0, 
	idFCategory int NOT NULL
	foreign key (idFCategory) references FoodCategory(id)
)
go

CREATE TABLE Bill
(
	id int identity primary key,
	DataCheckIn Date NOT NULL DEFAULT GETDATE(),
	DateCheckOut Date,
	idTable int NOT NULL,
	status int NOT NULL DEFAULT 0, --1: thanh toán  || 0: chưa thanh toán
	foreign key (idTable) references TableFood(id)
)
go

CREATE TABLE BillInfo
(
	id int identity primary key,
	idBill int NOT NULL,
	idFood int NOT NULL,
	count int NOT NULL DEFAULT 0
	foreign key (idBill) references Bill(id),
	foreign key (idFood) references Food(id)
)
go

insert into Account 
(
	UserName,
	DisplayName,
	PassWord,
	Type
)
Values
(
	N'Admin0',
	N'Trí',
	N'123',
	1
)
go

create proc USPGetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from Account where @userName = UserName;
end
go

exec USPGetAccountByUserName @userName = N'Admin0'


select * from TableFood;
select * from Account;
select * from FoodCategory;
select * from Food;
select * from Bill;
select * from BillInfo;