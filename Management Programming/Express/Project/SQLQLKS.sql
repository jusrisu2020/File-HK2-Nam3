create database DBQuanLyKhachSan
go

use DBQuanLyKhachSan
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
	(N'Cá Lóc Nướng Chui',1,10000)
insert dbo.Room
	(names, idCategory, price)
values
	(N'Ếch Nướng Muối Ớt',1,15000)
insert dbo.Room
	(names, idCategory, price)
values
	(N'Bào Ngư',1,50000)

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
	(N'Chè',2,3000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Máy MátXa',3,250000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Máy Chơi Game',3,50000)

insert dbo.Room
	(names, idCategory, price)
values
	(N'Ngắm Thiên Văn',4,300000)


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
	(DateCheckIn,DateCheckOut,idTable,status,discount)
values
	(GETDATE(),null,@idTable,0,0)

end
go

create proc USP_InsertBillInfo
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
--select MAX(id) from Bill

--update dbo.Bill set status = 1 where id=1

delete dbo.BillInfo
delete dbo.Bill



alter trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert, update
as
begin
	declare @idBill int

	select @idBill=idBill from Inserted

	declare @idTable int

	select  @idTable = idTable from dbo.Bill where id=@idBill and status=0
	
	declare @count int 
	select @count = count(*) from dbo.BillInfo where idBill = @idBill
	if(@count >0)
		update dbo.TableRoom set status = N'Có Người' where id=@idTable
	else
		update dbo.TableRoom set status = N'Trống' where id=@idTable
end
go

/*
drop trigger UTG_UpdateTable
on dbo.TableRoom for update
as
begin
	 declare @idTable int 
	 declare @status  nvarchar(100)
	 select @idTable = id , @status = Inserted.status from Inserted

	 declare @idBill int
	 select @idBill = id from dbo.Bill where idTable =@idTable and status =0

	 declare @countBillInfo int
	 select @countBillInfo = count(*) from dbo.BillInfo where idBill = @idBill

	if(@countBillInfo >0) --and status <> N'Có Người')
		update dbo.TableRoom set status = N'Có Người' where id=@idTable
	else --if(@countBillInfo <0 and status <> N'Trống'
		update dbo.TableRoom set status = N'Trống' where id=@idTable
end
go
*/

create trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int

	 select @idBill = id from Inserted

	  declare @idTable int

	  select @idTable = idTable from dbo.Bill where id= @idBill

	  declare @count int =0

	  select @count = count(*) from dbo.Bill where idTable =@idTable and status =0

	  if(@count = 0)
		update dbo.TableRoom set status = N'Trống' where id=@idTable

end
go

--- thêm trường giảm giá 
alter table dbo.Bill add discount int

update dbo.Bill set discount = 0
go


drop proc USP_SwitchTable

alter proc USP_SwitchTable
@idTable1 int, @idTable2 int
as 
begin

	declare @idFirstBill int 
	declare @idSecondBill int
	
	declare @isFirstTablEmty int = 1
	declare @isSecondTablEmty int = 1

	select @idSecondBill = id from dbo.Bill where idTable = @idTable2 and status = 0 -- thằng này có thể bị null nếu không có bill
	select @idFirstBill = id from dbo.Bill where idTable = @idTable1 and status = 0 -- thằng này có thể bị null nếu không có bill

	if(@idFirstBill is null)
	begin 
		insert into dbo.Bill
			(DateCheckIn,DateCheckOut,idTable,status)
		values
			(GETDATE(),null,@idTable1,0)

		select @idFirstBill = max(id) from dbo.Bill where idTable = @idTable1 and status =0	
	end
	select @isFirstTablEmty =count(*) from dbo.BillInfo where idBill =@idFirstBill


	if(@idSecondBill is null)
	begin 

		insert into dbo.Bill
			(DateCheckIn,DateCheckOut,idTable,status)
		values
			(GETDATE(),null,@idTable2,0)

		select @idSecondBill = max(id) from dbo.Bill where idTable = @idTable2 and status =0
		
		set @isSecondTablEmty = 1
	end
	select @isSecondTablEmty = count(*) from dbo.BillInfo where idBill = @idSecondBill


	select id into IDBillInfoTable from dbo.BillInfo where idBill =@idSecondBill
	
	update dbo.BillInfo set idBill = @idSecondBill where idBill = @idFirstBill

	update BillInfo set idBill = @idFirstBill where id in (select * from IDBillInfoTable)
	--- trường hợp giả sử cái bàn đó chưa có Bill thì sao


	drop table IDBillInfoTable
	if(@isFirstTablEmty = 0)
		update dbo.TableRoom set status = N'Trống' where  id=@idTable2
	if(@isSecondTablEmty = 0)
		update dbo.TableRoom set status = N'Trống' where  id=@idTable1
end
go

select * from TableRoom
select * from Bill
select * from BillInfo
select* from RoomCategory
go

EXEC dbo.USP_SwitchTable @idTable1 =8, @idTable2 =5

update dbo.TableRoom set status=N'Trống'
go

alter table dbo.Bill add totalPrice float



delete Bill
delete BillInfo
go
create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
---> danh mục hóa đơn mà mình muốn xuất ra
	select t.name as [Tên Phòng],b.totalPrice as [Tổng Tiền], DateCheckIn as [Ngày Vào], DateCheckOut as [Ngày ra], discount as [Giảm Giá]
	from dbo.Bill as b,dbo.TableRoom as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status =1
	and t.id = b.idTable 
end
go

create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int
	select  @isRightPass = count(*) from dbo.Account where USERName = @userName and PassWord = @password

	if(@isRightPass = 1)
	begin
		if(@newPassword = null and  @newPassword ='')
		begin
			update dbo.Account set DisplayName =@displayName where UserName = @userName
		end
		else
			update dbo.Account set DisplayName =@displayName , PassWord =@newPassword where UserName = @userName
	end
end
go

select * from Bill
select * from BillInfo
select * from account 