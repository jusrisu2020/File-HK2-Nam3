create database DBQuanLyKhachSan
go

use quanlykhachsan
go

create table TableRoom
(
	id int primary key identity,
	name nvarchar(100) not null default N'chưa đặt tên',
	status nvarchar(100) not null default N'trống'
)
go

declare @i int =0
while @i <= 10
begin
	insert dbo.TableRoom(name) values (N'Phòng ' + cast(@i as nvarchar(100)))
	set @i = @i+1;
end

select * from TableRoom



create table Account(

	UserName nvarchar(100) primary key not null,
	DisplayName nvarchar(100) not null default N'Kter',
	PassWord nvarchar(1000) not null default 0,
	Type int not null default 0

)
go

insert into dbo.Account
(
	UserName , 
	DisplayName,
	Password,
	Type
)
values
(
	N'ngoc',
	N'thaingoc',
	N'123',
	1 --admin
)
insert into dbo.Account
(
	UserName , 
	DisplayName,
	Password,
	Type
)
values
(
	N'staff',
	N'staff',
	N'123',
	0 --admin
)

select * from Account where UserName = N'ngoc' and PassWord =N''or 1=1--123'
go

create proc USP_Login
@userName nvarchar(100) ,@passWord nvarchar(100) 
as
begin
	select * from Account where UserName = @userName and PassWord =@passWord
end 
go


create table RoomCategory(
	id int primary key identity,
	names nvarchar(100) not null default N'chưa đặt tên'
)
go

create table Room(
	id int primary key identity,
	names nvarchar(100) not null default N'chưa đặt tên',
	idCategory int not null,
	price float not null default 0,

	foreign key (idCategory) references dbo.RoomCategory(id)
)
go

create table Bill(
	id int primary key identity,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	status int not null ---1 la sa thanh toan,0 thi chua
	foreign key (idTable) references dbo.TableRoom(id)
)
go

create table BillInfo(
	id int identity primary key,
	idBill int not null,
	idRoom int not null,
	count int not null Default 0

	foreign key(idBill) references dbo.Bill(id),
	foreign key(idRoom) references dbo.Room(id)
)	
go

create proc	USP_GetTableList
as select * from dbo.TableRoom
go

update dbo.TableRoom set  status=N'Có người' where id=9
EXEC dbo.USP_GetTableList
go

--- Thêm Category
insert dbo.RoomCategory
		(names)
values 
		(N'Đồ Ăn')
go

insert dbo.RoomCategory
		(names)
values 
		(N'Nước Uống')
go

insert dbo.RoomCategory
		(names)
values 
		(N'Thiết Bị Cao Cấp')
go

insert dbo.RoomCategory
		(names)
values 
		(N'Dịch vụ khác')

--- thêm dịch vụ
insert dbo.Room
	(names, idCategory, price)
values
	(N'Cua Hoàng Đế',1,500000)


insert dbo.Room
	(names, idCategory, price)
values
	(N'Thịt Bò Nướng',1,250000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Canh Chua',1,10000)


insert dbo.Room
	(names, idCategory, price)
values
	(N'7up',2,50000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Cafe',2,30000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Máy MátXa',3,1000000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Máy Chơi Game',3,500000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Ngắm Thiên Văn',4,50000000)


---thêm Bill
insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),null,1,0)

insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),null,2,0)

insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),GETDATE(),2,1)

insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),GETDATE(),3,0)

insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),GETDATE(),6,0)

insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),GETDATE(),7,0)
--- thêm info
insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(1,1,2)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(1,3,4)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(1,5,1)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(2,1,2)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(5,1,1)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(5,3,1)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(4,3,2)


---delete from BillInfo
---where count=3;

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(1,6,2)

insert dbo.BillInfo
	(idBill,idRoom,count)
values
	(3,5,2)
go

create proc USP_Login
@userName nvarchar(100) ,@passWord nvarchar(100) 
as
begin
	select * from Account where UserName = @userName and PassWord =@passWord
end 
go

create proc USP_Login
@userName nvarchar(100) ,@passWord nvarchar(100) 
as
begin
	select * from Account where UserName = @userName and PassWord =@passWord
end 
go

select * from Bill where idTable=1 and status = 0

select r.names, bi.count,r.price,r.price*bi.count as totalPrice from BillInfo as bi,Bill as b, Room as r
where bi.idBill = b.id and bi.idRoom = r.id and b.status = 0 and b.idTable = 1

select * from Bill

select * from BillInfo
select * from Room
select * from RoomCategory


---tạo một staorepro để insert dữ liệu vào

create proc USP_InsertBill
@idTable int
as
begin
	insert into dbo.Bill
	(DateCheckIn,DateCheckOut,idTable,status)
values
	(GETDATE(),null,@idTable,0)

end
go

alter proc USP_InsertBillInfo
@idBill int, @idRoom int , @count int 
as
begin
	declare @isExitBillBillInfo int
	declare @roomCount int =1

	select @isExitBillBillInfo = id, @roomCount = count 
	from dbo.BillInfo where idBill=@idBill and idRoom=@idRoom	--ktra xem thuc an nay co ton tai trong billinfo khong

	if(@isExitBillBillInfo >0)
	begin
		declare @newCount int = @roomCount + @count
		if(@newCount >0)
		-- neu thuc an do co ton tai thi ta se cap nhat no len
		update dbo.BillInfo set count = @roomCount+@count where @idRoom=idRoom;
		else
			delete BillInfo where @idBill=idBill and idRoom=@idRoom;
	end
	else
	begin
		insert dbo.BillInfo	
			(idBill,idRoom,count)
		values
			(
			@idBill
			,@idRoom
			,@count
			)
	end

	
end
go

-----
select MAX(id) from Bill

update dbo.Bill set status = 1 where id=1