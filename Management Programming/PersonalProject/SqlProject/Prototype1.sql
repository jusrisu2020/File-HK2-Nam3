USE ProjectPrototype1
GO
-------------------------------------	Table Tài Khoản ------------------------------------------------
CREATE TABLE BaoCaoTBHong
(
	MaBC INT IDENTITY PRIMARY KEY,
	MaTB INT,
	MaNV INT,
	NgayBC DATE,
	PhuongThucPhat NVARCHAR(50),
	TienPhat INT
)

CREATE TABLE BoPhan
(
	MaBP INT IDENTITY,
	TenBP NVARCHAR(100)
)
CREATE TABLE ChiTietHoaDonMuaTB
(
	MaHDMua INT IDENTITY,
	TenTB NVARCHAR(255),
	MaDanhMuc INT,
	MaBP INT,
	DonVi NVARCHAR(255),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT
)

CREATE TABLE ChiTietXuLyTB
(
	MaXuLyTB INT IDENTITY,
	NgayXuLy DATE,
	PhuongThucXuLy NVARCHAR(50),
	MaTB INT,
	TenTB NVARCHAR(50),
	DonVi NVARCHAR(50),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT,
	NguoiMua NVARCHAR(50)
)

CREATE TABLE ChucVu
(
	MaCV INT IDENTITY,
	TenCV NVARCHAR(100)
)

CREATE TABLE DanhMuc
(
	MaDanhMuc INT IDENTITY,
	TenDanhMuc NVARCHAR(255)
)

CREATE TABLE HoaDonMuaTB
(
	MaHDMua INT IDENTITY,
	NgayMuaTB DATE,
	MaNV INT,
	MaNCC INT
)

CREATE TABLE NhaCungCap
(
	MaNCC INT IDENTITY,
	TenNCC NVARCHAR(255),
	SDT NVARCHAR(50),
	DiaChi NVARCHAR(300),
	Email NVARCHAR(50),
	STK NVARCHAR(50),
	TenCongTy NVARCHAR(300)
)
CREATE TABLE NhanVien
(
	MaNV INT IDENTITY,
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(50),
	Email NVARCHAR(50),
	TonGiao NVARCHAR(50),
	CMND NVARCHAR(50),
	MaBP INT,
	MaCV INT
)
CREATE TABLE PhieuBanGiao
(
	MaBG INT IDENTITY,
	MaNVBG INT,
	MaNVNhan INT,
	NgayMuon DATE,
	MaTB INT,
	TenTB NVARCHAR(255),
	MaDanhMuc INT,
	MaBPTB INT,
	DonVi NVARCHAR(50),
	SoLuong INT,
	TinhTrang NVARCHAR(50)
)

CREATE TABLE TaiKhoan
(
	MaTK NVARCHAR(100),
	MaNV INT,
	TenTK NVARCHAR(100),
	Pass NVARCHAR(100),
	Email NVARCHAR(100),
	TrangThai NVARCHAR(100),
	LoaiND NVARCHAR(100)
)

CREATE TABLE ThietBi
(
	MaTB INT IDENTITY,
	TenTB NVARCHAR(255),
	DonVi NVARCHAR(50),
	SoLuongHienHuu INT,
	MaDanhMuc INT,
	MaBP INT,
	ThoiGianBH DATE,
	TinhTrangTB NVARCHAR(50),
	MaNCC INT,
	MaHDMuaTB INT,
	GhiChu NVARCHAR(300)
)

CREATE TABLE XuLyTB
(
	MaXuLyTB INT IDENTITY,
	MaNV INT,
	NgayXuLy DATE
)



-------------------------------------	Tài Khoản ------------------------------------------------

BEGIN TRANSACTION
GO
CREATE PROC USPThemTaiKhoan
	@MaTK nvarchar(100),
    @MaNV int,
    @TenTK NVARCHAR(100),
    @Pass NVARCHAR(100)
AS
BEGIN
 INSERT INTO dbo.TaiKhoan(MaTK,MaNV,TenTK,Pass)
 VALUES
 (@MaTK , @MaNV, @TenTK, @Pass)
END
EXEC USPThemTaiKhoan @MaTK = N'TK01',@MaNV = 1, @TenTK = N'ad1', @Pass = N'1'
GO
ROLLBACK
GO

DROP PROC dbo.USPThemTaiKhoan
GO

CREATE PROC USPSelectTaiKhoan
AS
	SELECT * FROM dbo.TaiKhoan
EXEC USPSelectTaiKhoan
GO
-------------------------------------------Nhân viên -----------------------------------------
BEGIN TRANSACTION
GO
CREATE PROC USPThemNhanVien
	@MaNV int,
    @HoTen nvarchar(50),
    @MaBP int,
    @MaCV int
AS
BEGIN
	INSERT INTO dbo.NhanVien
	(
	    MaNV,
	    HoTen,
	    MaBP,
	    MaCV
	)
	VALUES
	(   @MaNV,
		@HoTen,
		@MaBP,
		@MaCV
	    )
END
EXEC USPThemNhanVien 1, N'Nhân Viên 1', @MaBP = 1, @MaCV = 1
GO
ROLLBACK
GO

DROP PROC dbo.USPThemNhanVien


CREATE PROC USPSelectNhanVien
AS
	BEGIN
		SELECT * FROM dbo.NhanVien
	END
EXEC dbo.USPSelectNhanVien
GO

-------------------------------------------Bộ phận -----------------------------------------
BEGIN TRANSACTION
GO
CREATE PROC USPThemBoPhan
	@MaBP INT,
	@TenBP NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.BoPhan(MaBP, TenBP) VALUES(@MaBP,@TenBP)
END
EXEC USPThemBoPhan @MaBP = 1 , @TenBP = N'Sảnh'
GO
ROLLBACK
GO

SELECT * FROM dbo.BoPhan
GO
-------------------------------------------Chức vụ -----------------------------------------

CREATE PROC USPThemChucVu
	@MaCV INT,
	@TenCV NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.ChucVu(MaCV, TenCV) VALUES(@MaCV,@TenCV)
END
EXEC USPThemChucVu @MaCV = 1 , @TenCV = N'Quản Lý Sảnh'
GO
ROLLBACK
GO

DROP PROC dbo.USPThemChucVu

SELECT * FROM dbo.ChucVu




