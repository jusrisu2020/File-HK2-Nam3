create database TSTBKhachSan
go

use TSTBKhachSan
go


-- Tài khoản
-- Nhân viên
-- THIẾT BỊ
-- Quản lí bộ phận

-- phiếu chi trả 
-- Quản lí cấp phát thiết bị
	

go

create table TaiKhoan
(
	MaTK nvarchar(100) primary key,						-- TK01 ->...
	HinhAnh image,
	HoTen nvarchar (250),
	TenTK nvarchar (250),
	Pass nvarchar(250),
	Email nvarchar (250),
	TrangThai nvarchar(100),							-- Khóa || Mở
	LoaiNguoiDung nvarchar(100),
	BoPhan nvarchar (250)								-- FK chưa set
)
go

create table QLNhanVien
(
	MaNV int identity primary key,						-- 001
	HoTen nvarchar (250),
	BoPhan nvarchar (250),
	ChucVu nvarchar(250),		
	NgaySinh date,
	DiaChi nvarchar(100),
	SDT int,
	Email nvarchar (250),
	TonGiao nvarchar (250),
	CMND int
)
go

create table QLBoPhan
(
	MaBP nvarchar(100),
	TenBoPhan nvarchar (250) primary key,
)
go

create table ThietBi(
	MaTB nvarchar (10) PRIMARY KEY,
	TenTB nvarchar (255),
	DonVi nvarchar (30),
	SoLuong int,
	DanhMuc nvarchar (255),
	DonGia int,
	TongGiaTri int,
	TGBaoHanh date,
	TinhTrangTB nvarchar (30),
	BoPhan nvarchar (255),
	NCC nvarchar (255),
	NgayMuaTB date,
	GhiChu nvarchar(255)
)
go

create table QLLichSu
(
	MaLS
	LoaiLS				--Mượn or trả
	NgayMuonTB
	NgayTraTB
	TinhTrangMuon
	TinhTrangTra

)
go

create table ChiTietMuon(
	Mã cấp phát, ngày bàn giao, số biên bản, 
	mã thiết bị(FK-QLTB), tên thiết bị(FK-QLTB),
	
	Mã người bàn giao
	người bàn giao:
	

	Mã người tiếp nhận
	người tiếp nhận nhân viên trong bộ phận or ngoài bộ phận.

	nơi tiếp nhận, 
	tình trạng thiết bị.
)
go

create table ChiTietTra(
	MaTB nvarchar (10) PRIMARY KEY,
	TenTB nvarchar (255),
	DonVi nvarchar (30),
	SoLuong int,
	DanhMuc nvarchar (255),
	GiaTri int,
	TGBaoHanh date,
	TinhTrangTB nvarchar (30),
	BoPhan nvarchar (255),
	NCC nvarchar (255),
	NgayMuaTB date,
	GhiChu nvarchar(255)
)
go
SELECT * FROM ThietBi
SELECT * FROM TaiKhoan
