CREATE DATABASE TestSQL
GO

USE TestSQL
GO

--Account
--Food
--TableFood
--Bill


--Account
CREATE TABLE Account
(
	UserName nvarchar(100) primary key,
	Pass nvarchar(100),
	Access nvarchar(100),
)
go
--Food
CREATE TABLE Food
(
	Id int identity primary key,
	FoodName nvarchar(100),
	FoodCount int,
)
go

--TableFood

CREATE TABLE TableFood
(
	Id int identity primary key,
	TableName nvarchar(100),
)
go
--Bill

CREATE TABLE Bill
(
	Id int identity primary key,
	IdFood int,
	CountSum int

	foreign key (IdFood) references Food(Id)
)
go

--Insert Data to Account table
insert into Account(UserName,Pass,Access) values(N'Admin1',N'1',N'Chủ tịt1')
insert into Account(UserName,Pass,Access) values(N'Admin6',N'1',N'Chủ tịt1')
insert into Account(UserName,Pass,Access) values(N'Admin2',N'2',N'Chủ tịt2')
insert into Account(UserName,Pass,Access) values(N'Admin3',N'3',N'Chủ tị3')
insert into Account(UserName,Pass,Access) values(N'Admin4',N'4',N'Chủ tịt4')
insert into Account(UserName,Pass,Access) values(N'Admin5',N'5',N'Chủ tịt5')
go

--Insert Data to Fool table
insert into Food(FoodName,FoodCount) values(N'Bánh Mì', 1000)
insert into Food(FoodName,FoodCount) values(N'Bánh Bò', 2000)
insert into Food(FoodName,FoodCount) values(N'Bánh Chuối', 3000)
insert into Food(FoodName,FoodCount) values(N'Bánh Bông Lan', 4000)

--Insert Data to TableFood table
insert into TableFood(TableName) values(N'Trống')
insert into TableFood(TableName) values(N'Có Khách')
insert into TableFood(TableName) values(N'Trống')
insert into TableFood(TableName) values(N'Có Khách')
insert into TableFood(TableName) values(N'Có Khách')

--Insert Data to Bill table


--Account
--Food
--TableFood
--Bill
select * from Account
select * from Food
select * from TableFood
select * from Bill

SELECT DISTINCT Pass, Access FROM Account
SELECT DISTINCT Pass FROM Account WHERE Pass BETWEEN N'1' AND N'3'

