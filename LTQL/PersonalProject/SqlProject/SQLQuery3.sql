create database TSTBKhachSans
go

use TSTBKhachSans
go


-- Tài khoản
-- Quản lí Nhân viên
-- Quản lí bộ phận
-- THIẾT BỊ
--Quản lí nhà cung cấp
-- Chi tiết bàn giao
-- Phiếu thanh Lý thiết bị
-- Báo cáo thiết bị hỏng
	

create table TaiKhoan
(
	MaTK nvarchar(100) primary key,						-- TK01 ->...
	HinhAnh image,
	MaNV int identity,									--UNIQUE
	TenTK nvarchar (250) not null,
	Pass nvarchar(250) not null,
	Email nvarchar (250) not null,
	TrangThai nvarchar(100) not null,							-- Khóa || Mở
	LoaiNguoiDung nvarchar(100) not null,						-- Admin || User Managerment
	MaBoPhan nvarchar(100),
	BoPhan nvarchar (250) not null,
	ChucVu nvarchar(100) not null,
)
go

ALTER TABLE TaiKhoan 
ADD CONSTRAINT FkBoPhan
FOREIGN KEY (BoPhan) REFERENCES QLBoPhan(TenBoPhan);

create table QLBoPhan
(
	MaBP nvarchar(100) primary key,
	TenBoPhan nvarchar (250) not null,
)
go