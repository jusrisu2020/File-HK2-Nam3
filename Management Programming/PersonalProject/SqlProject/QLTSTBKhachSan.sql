CREATE DATABASE TSTBKhachSan
GO

USE TSTBKhachSan
GO

-- Tài khoản
-- Quản lí Nhân viên
-- Quản lí bộ phận
-- THIẾT BỊ
--Quản lí nhà cung cấp
-- Chi tiết bàn giao
-- Phiếu thanh Lý thiết bị
-- Báo cáo thiết bị hỏng
--------------------------------------------------- CREATE TABLE

CREATE TABLE TaiKhoan
(
	MaTK NVARCHAR(100) PRIMARY KEY,						
	HinhAnh image,
	MaNV int identity,									
	TenTK NVARCHAR(100) not null,
	Pass NVARCHAR(100) not null,
	Email NVARCHAR(100) not null,
	TrangThai NVARCHAR(100) not null,							
	LoaiNguoiDung NVARCHAR(100) not null,						
	MaBoPhan NVARCHAR(100),
	BoPhan NVARCHAR(100) not null,
	ChucVu NVARCHAR(100) not null,
)
GO

CREATE TABLE NhanVien
(
	MaNV INT IDENTITY PRIMARY KEY,						
	HoTen NVARCHAR(100) not null ,
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	DiaChi NVARCHAR(100) not null,
	SDT NVARCHAR(100) not null,
	Email NVARCHAR(100),
	TonGiao NVARCHAR(100),
	CMND NVARCHAR(100) not NULL,
    BoPhan NVARCHAR(100) not null,
	ChucVu NVARCHAR(100) NOT null
)
GO

BEGIN TRANSACTION
GO

CREATE TABLE QLBoPhan
(
	MaBP VARCHAR(10) PRIMARY KEY DEFAULT AUTO_IDKH(),
	TenBoPhan NVARCHAR(100),
	MaNVQL NVARCHAR(100),
	TenNVQL NVARCHAR(100)
)
GO
ROLLBACK

INSERT INTO dbo.QLBoPhan
(
    TenBoPhan,
    MaNVQL,
    TenNVQL
)
VALUES
(   N'Bộ phận sảnh', -- TenBoPhan - nvarchar(100)
    N'NV1', -- MaNVQL - nvarchar(100)
    N'Nhân viên 1'  -- TenNVQL - nvarchar(100)
    )
SELECT * FROM QLBoPhan

DROP TABLE dbo.QLBoPhan
GO

CREATE FUNCTION AUTO_IDKH()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @Mabp VARCHAR(10)
	IF (SELECT COUNT(MaBP) FROM dbo.QLBoPhan) = 0
		SET @Mabp = '0'
	ELSE
		SELECT @Mabp = CASE
			WHEN @Mabp >= 0 and @Mabp < 9 THEN 'BP0' + CONVERT(VARCHAR, CONVERT(INT, @Mabp) + 1)
			WHEN @Mabp >= 9 THEN 'BP' + CONVERT(VARCHAR, CONVERT(INT, @Mabp) + 1)
		END
	RETURN @Mabp
END

DROP FUNCTION dbo.AUTO_IDKH

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
GO

CREATE TABLE QLNhaCungCap
(
	MaNCC INT IDENTITY PRIMARY KEY,
	TenNCC NVARCHAR(100),								
	TenCongTy NVARCHAR(100),
	DiaChi NVARCHAR(100),
	SDT INT,
	Email NVARCHAR(100)
)
GO

create table ChiTietBanGiao
(
	MaBanGiao INT IDENTITY,
	NgayBanGiao DATE,
	MaTBBanGiao INT,														-- FK
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
	MaPhieuThanhLy INT IDENTITY PRIMARY KEY,
	NgayThanhLy date,
	MaTB INT,													
	TenTB NVARCHAR(100),
	SoLuong INT,
	DonGia INT,
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

SELECT * FROM dbo.NhanVien
SELECT * FROM dbo.TaiKhoan



SELECT * FROM BaoCaoTBHong
SELECT * FROM ChiTietBanGiao
SELECT * FROM PhieuThanhLyTB
SELECT * FROM QLBoPhan
SELECT * FROM QLNhaCungCap
SELECT * FROM QLNhanVien
SELECT * FROM TaiKhoan
SELECT * FROM ThietBi














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