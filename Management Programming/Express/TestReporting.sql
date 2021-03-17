CREATE DATABASE TestReporting
go

use TestReporting
go

create table MonHoc
(
	MaMH int primary key,
	TenMH nvarchar(50) not null
)
go

create table SinhVien
(
	MaSV int primary key,
	TenSV nvarchar(100) null
)
go

create table SinhVienDiem
(
	id int primary key,
	MaSV int not null,--FK
	MaMH int not null,--FK
	Diem float not null

	constraint FKMaSV foreign key(MaSV) references SinhVien(MaSV),
	constraint FKMaMH foreign key(MaMH) references MonHoc(MaMH)
)
go

--INSERT INTO SINHVIEN VALUES
insert into SinhVien(MaSV,TenSV) values (1,N'Trần Minh Trí')
insert into SinhVien(MaSV,TenSV) values (2,N'Trần Công Minh')


--INSERT INTO MonHoc Values
insert into MonHoc(MaMH,TenMH) values (1,N'Toán')
insert into MonHoc(MaMH,TenMH) values (2,N'Lý')
insert into MonHoc(MaMH,TenMH) values (3,N'Hóa')

--INSERT INTO SinhVienDiem Values
insert into SinhVienDiem(id,MaSV,MaMH,Diem) values (1,1,1,5)
insert into SinhVienDiem(id,MaSV,MaMH,Diem) values (2,1,3,7)
insert into SinhVienDiem(id,MaSV,MaMH,Diem) values (3,2,2,9)
insert into SinhVienDiem(id,MaSV,MaMH,Diem) values (4,2,1,10)
insert into SinhVienDiem(id,MaSV,MaMH,Diem) values (5,2,3,8)



select * from MonHoc,SinhVien,SinhVienDiem
select * From MonHoc
select * From SinhVienDiem
select * From SinhVien

select sv.MaSV, TenSV, TenMH, Diem from MonHoc as m, SinhVien as sv, SinhVienDiem as svd where m.MaMH = svd.MaMH and sv.MaSV= svd.MaSV