create database TSTBKhachSan
go

use TSTBKhachSan
go


-- Tài khoản
-- Quản lí Nhân viên
-- Quản lí bộ phận
-- THIẾT BỊ
--Quản lí nhà cung cấp
-- Chi tiết bàn giao
-- Phiếu thanh Lý thiết bị
-- Báo cáo thiết bị hỏng
	
SELECT * FROM TaiKhoan

INSERT dbo.TaiKhoan
(
    MaTK,
    HinhAnh,
    TenTK,
    Pass,
    Email,
    TrangThai,
    LoaiNguoiDung,
    MaBoPhan,
    BoPhan,
    ChucVu
)
VALUES
(   N'',  -- MaTK - nvarchar(100)
    NULL, -- HinhAnh - image
    N'',  -- TenTK - nvarchar(250)
    N'',  -- Pass - nvarchar(250)
    N'',  -- Email - nvarchar(250)
    N'',  -- TrangThai - nvarchar(100)
    N'',  -- LoaiNguoiDung - nvarchar(100)
    N'',  -- MaBoPhan - nvarchar(100)
    N'',  -- BoPhan - nvarchar(250)
    N''   -- ChucVu - nvarchar(100)
    )
CREATE PROC USPInsertTaiKhoan
	@matk nvarchar(100), 
	@hinhanh image ,
	@tenTK nvarchar(250),
	@pass nvarchar(250),
	@email nvarchar(250),
	@trangthai nvarchar(100),
	@loainguoidung nvarchar(100),
	@mabophan nvarchar(100),
	@bophan nvarchar(250),
	@chucvu nvarchar(100)
AS
BEGIN
	INSERT dbo.TaiKhoan
	(
	    MaTK,
	    HinhAnh,
	    TenTK,
	    Pass,
	    Email,
	    TrangThai,
	    LoaiNguoiDung,
	    MaBoPhan,
	    BoPhan,
	    ChucVu
	)
	VALUES
	(   @matk,
		@hinhanh,
		@tenTK,
		@pass,
		@email,
		@trangthai,
		@loainguoidung,
		@mabophan,
		@bophan,
		@chucvu
	    )
END
GO
EXEC USPInsertTaiKhoan 
		@matk = N'TK1',
		@hinhanh = NULL,
		@tenTK = N'Admin',
		@pass = N'1',
		@email = N'ad1@gmail.com',
		@trangthai = N'Đang hoạt động',
		@loainguoidung = N'Admin',
		@mabophan = NULL,
		@bophan = N'0',
		@chucvu = N'Admin'

SELECT * FROM dbo.TaiKhoan

create table TaiKhoan
(
	MaTK nvarchar(100) primary key,						-- TK01 ->...
	HinhAnh image,
	MaNV int identity,									--UNIQUE
	TenTK nvarchar (250) not null,
	Pass nvarchar(250) not null,
	Email nvarchar (250) not null,
	TrangThai nvarchar(100) not null,							-- Khóa || Đang hoạt động
	LoaiNguoiDung nvarchar(100) not null,						-- Admin || User Managerment
	MaBoPhan nvarchar(100),
	BoPhan nvarchar (250) not null,
	ChucVu nvarchar(100) not null,
)
go

create table QLNhanVien
(
	MaNV int identity primary key,						-- 001
	HoTen nvarchar(255) not null ,
	BoPhan nvarchar (250) not null,
	ChucVu nvarchar(250) not null,								-- Quản lí hay nhân viên.
	NgaySinh date,
	DiaChi nvarchar(100) not null,
	SDT int not null,
	Email nvarchar (250),
	TonGiao nvarchar (250),
	CMND int not null
)
go


SELECT * FROM QLNhanVien
SELECT * FROM TaiKhoan

ALTER TABLE TaiKhoan 
ADD CONSTRAINT FkMaNV 
FOREIGN KEY (MaNV) REFERENCES QLNhanVien(MaNV);

ALTER TABLE TaiKhoan 
ADD CONSTRAINT FkBoPhan
FOREIGN KEY (BoPhan) REFERENCES QLBoPhan(TenBoPhan);

create table QLBoPhan
(
	MaBP nvarchar(100) primary key,
	TenBoPhan nvarchar (250) not null,
)
go

create table ThietBi
(
	MaTB  int identity  PRIMARY KEY,
	TenTB nvarchar (255) not null,
	DonVi nvarchar (30) not null,
	SoLuong int not null,
	DanhMuc nvarchar (255) not null,
	DonGia int not null,
	TongGiaTri int not null,
	TGBaoHanh date,
	TinhTrangTB nvarchar (30) not null, 
	BoPhan nvarchar (255) not null,
	NCC nvarchar (255) not null,
	NgayMuaTB date,
	GhiChu nvarchar(255)
)
go

create table QLNhaCungCap
(
	MaNCC int identity primary key,
	TenNCC nvarchar (250) not null,								
	TenCongTy nvarchar(250),
	DiaChi nvarchar(100),
	SDT int not null,
	Email nvarchar (250),
)
go

create table ChiTietBanGiao
(
	MaBanGiao int identity primary key,
	NgayBanGiao date,
	MaTBBanGiao int,														-- FK
	TenThietBi nvarchar(250) ,
	MaNVBanGiao int,
	NhanVienBanGiao nvarchar(250),											-- FK
	BoPhanBanGiao nvarchar(250),
	MaNVTiepNhan int,														-- FK
	NguoiTiepNhan nvarchar(250),
	BoPhanTiepNhan nvarchar(250),
	NoiTiepNhan nvarchar(250),
	TinhTrangTBBanGiao nvarchar(250)
)
go

create table PhieuThanhLyTB
(
	MaPhieuThanhLy int identity  primary key,
	NgayThanhLy date,
	MaTB int,																--FK
	TenTB nvarchar (250),
	SoLuong int,
	DonGia int,
	TinhTrangTB nvarchar(250),
	DanhMuc nvarchar(250),
	BoPhan nvarchar(250),
	MaNVThanhLy int,
	TenNV nvarchar(250),
	NguoiMua nvarchar(250),
	SDTNguoiMua nvarchar(250),
	TongGiaTri int,
)
go
create table BaoCaoTBHong
(
	MaBaoCao int identity primary key,
	MaThietBi int,															--FK	
	TenTB nvarchar(250),
	LyDo nvarchar(500),
	MaNVPhatHien int,														--FK
	TenNVPhatHien nvarchar(250),
	BoiThuong int,
)

SELECT * FROM BaoCaoTBHong
SELECT * FROM ChiTietBanGiao
SELECT * FROM PhieuThanhLyTB
SELECT * FROM QLBoPhan
SELECT * FROM QLNhaCungCap
SELECT * FROM QLNhanVien
SELECT * FROM TaiKhoan
SELECT * FROM ThietBi

-- INSERT DATA

INSERT BaoCaoTBHong (MaBaoCao,MaThietBi,TenTB,LyDo,MaNVPhatHien,TenNVPhatHien,BoiThuong) 
VALUES 
(
	
)
INSERT QLBoPhan(MaBP,TenBoPhan) 
VALUES 
(
	N'BP01', N'Sảnh đón tiếp'
)