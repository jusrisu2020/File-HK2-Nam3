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

--Add Data
insert into Account(UserName,Pass,Access) values(N'Admin1',N'1',N'Chủ tịt1')
insert into Account(UserName,Pass,Access) values(N'Admin2',N'2',N'Chủ tịt2')
insert into Account(UserName,Pass,Access) values(N'Admin3',N'3',N'Chủ tị3')
insert into Account(UserName,Pass,Access) values(N'Admin4',N'4',N'Chủ tịt4')
insert into Account(UserName,Pass,Access) values(N'Admin5',N'5',N'Chủ tịt5')
go
delete from Account where Pass=1;
delete from Account
update Account set Access = N'Chủ tịch' where Pass = 5;
select * from Account where Access = N'Chủ tịt2'
select count(UserName) as N'Tổng tài khoản' from Account
--Hàm SUM() tính tổng các giá trị trong 1 cột ""
--Account
--Food
--TableFood
--Bill
select * from Account
select * from Food
select * from TableFood
select * from Bill