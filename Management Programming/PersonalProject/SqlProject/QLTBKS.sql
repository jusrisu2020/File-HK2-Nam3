------------------------------------ Project ----------------------------------------------------------
CREATE DATABASE TSTBKhachSan
GO
USE TSTBKhachSan
GO
-------------------------------------	Table Tài Khoản ------------------------------------------------
CREATE TABLE BoPhan
(
	MaBP INT IDENTITY PRIMARY KEY,
	TenBP NVARCHAR(100)
)

CREATE TABLE ChucVu
(
	MaCV INT IDENTITY PRIMARY KEY,
	TenCV NVARCHAR(100)
)

CREATE TABLE DanhMuc
(
	MaDanhMuc INT IDENTITY PRIMARY KEY,
	TenDanhMuc NVARCHAR(255)
)

CREATE TABLE NhanVien
(
	MaNV INT IDENTITY PRIMARY KEY,
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(50),
	Email NVARCHAR(50),
	TonGiao NVARCHAR(50),
	CMND NVARCHAR(50),
	MaBP INT CONSTRAINT FK_NhanVien_BoPhan FOREIGN KEY(MaBP) REFERENCES  dbo.BoPhan(MaBP),
	MaCV INT CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY(MaCV) REFERENCES  dbo.ChucVu(MaCV)
)

CREATE TABLE NhaCungCap
(
	MaNCC INT IDENTITY PRIMARY KEY,
	TenNCC NVARCHAR(255),
	SDT NVARCHAR(50),
	DiaChi NVARCHAR(300),
	Email NVARCHAR(50),
	STK NVARCHAR(50),
	TenCongTy NVARCHAR(300)
)

CREATE TABLE HoaDonMuaTB
(
	MaHDMua INT IDENTITY PRIMARY KEY,
	NgayMuaTB DATE,
	MaNV INT CONSTRAINT FK_HoaDonMuaTB_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	MaNCC INT CONSTRAINT FK_HoaDonMuaTB_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC)
)

CREATE TABLE ChiTietHoaDonMuaTB
(
	MaHDMua INT CONSTRAINT FK_ChiTietHoaDonMuaTB_HoaDonMuaTB FOREIGN KEY(MaHDMua) REFERENCES dbo.HoaDonMuaTB(MaHDMua),
	TenTB NVARCHAR(255),
	MaDanhMuc INT,
	MaBP INT CONSTRAINT FK_ChiTietHoaDonMuaTB_BoPhan FOREIGN KEY(MaBP) REFERENCES dbo.BoPhan(MaBP),
	DonVi NVARCHAR(255),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT
)

CREATE TABLE TaiKhoan
(
	MaTK INT IDENTITY PRIMARY KEY,
	MaNV INT CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	TenTK NVARCHAR(100),
	Pass NVARCHAR(100),
	Email NVARCHAR(100),
	TrangThai NVARCHAR(100),
	LoaiND NVARCHAR(100)
)

CREATE TABLE ThietBi
(
	MaTB INT IDENTITY PRIMARY KEY,
	TenTB NVARCHAR(255),
	DonVi NVARCHAR(50),
	SoLuongHienHuu INT,
	MaDanhMuc INT CONSTRAINT FK_ThietBi_DanhMuc FOREIGN KEY (MaDanhMuc) REFERENCES dbo.NhanVien(MaNV) ,
	MaBP INT CONSTRAINT FK_ThietBi_BoPhan FOREIGN KEY(MaBP) REFERENCES dbo.BoPhan(MaBP),
	ThoiGianBH DATE,
	TinhTrangTB NVARCHAR(50),
	MaNCC INT CONSTRAINT FK_ThietBi_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
	MaHDMuaTB INT CONSTRAINT FK_ThietBi_HoaDonMuaTB FOREIGN KEY(MaHDMuaTB) REFERENCES dbo.HoaDonMuaTB(MaHDMua),
	GhiChu NVARCHAR(300)
)

CREATE TABLE BaoCaoTBHong
(
	MaBC INT IDENTITY PRIMARY KEY,
	MaTB INT CONSTRAINT FK_BaoCaoTBHong_ThietBi FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB),
	MaNV INT CONSTRAINT FK_BaoCaoTBHong_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	NgayBC DATE,
	PhuongThucPhat NVARCHAR(50),
	TienPhat INT
)

CREATE TABLE XuLyTB
(
	MaXuLyTB INT IDENTITY PRIMARY KEY,
	MaNV INT CONSTRAINT FK_XuLyTB_NhanVien FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV),
	NgayXuLy DATE
)

CREATE TABLE ChiTietXuLyTB
(
	MaXuLyTB INT CONSTRAINT FK_ChiTietXuLyTB_XuLyTB FOREIGN KEY(MaXuLyTB) REFERENCES dbo.XuLyTB(MaXuLyTB),
	NgayXuLy DATE,
	PhuongThucXuLy NVARCHAR(50),
	MaTB INT CONSTRAINT FK_ChiTietXuLyTB_ThietBi FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB),
	TenTB NVARCHAR(50),
	DonVi NVARCHAR(50),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT,
	NguoiMua NVARCHAR(50)
)

CREATE TABLE PhieuBanGiao
(
	MaBG INT IDENTITY PRIMARY KEY,
	MaNVBG INT CONSTRAINT FK_PhieuBanGiao_NhanVienBG FOREIGN KEY(MaNVBG) REFERENCES dbo.NhanVien(MaNV),
	MaNVNhan INT CONSTRAINT FK_PhieuBanGiao_NhanVienNhan FOREIGN KEY(MaNVNhan) REFERENCES dbo.NhanVien(MaNV),
	NgayMuon DATE,
	MaTB INT CONSTRAINT FK_PhieuBanGiao_ThietBi FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB),
	TenTB NVARCHAR(255),
	MaDanhMuc INT CONSTRAINT FK_PhieuBanGiao_DanhMuc FOREIGN KEY(MaDanhMuc) REFERENCES dbo.DanhMuc(MaDanhMuc),
	MaBPTB INT CONSTRAINT FK_PhieuBanGiao_BoPhan FOREIGN KEY(MaBPTB) REFERENCES dbo.BoPhan(MaBP),
	DonVi NVARCHAR(50),
	SoLuong INT,
	TinhTrang NVARCHAR(50)
)
-------------------------------------	Bộ phận ------------------------------------------------
INSERT INTO dbo.BoPhan(TenBP)
VALUES(N'Sảnh Đón Tiếp' -- TenBP - nvarchar(100))
SELECT * FROM dbo.BoPhan

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
INSERT INTO dbo.NhanVien
(
    HoTen,
    GioiTinh,
    NgaySinh,
    DiaChi,
    SDT,
    Email,
    TonGiao,
    CMND,
    MaBP,
    MaCV
)
VALUES
(   N'',       -- HoTen - nvarchar(50)
    N'',       -- GioiTinh - nvarchar(5)
    GETDATE(), -- NgaySinh - date
    N'',       -- DiaChi - nvarchar(50)
    N'',       -- SDT - nvarchar(50)
    N'',       -- Email - nvarchar(50)
    N'',       -- TonGiao - nvarchar(50)
    N'',       -- CMND - nvarchar(50)
    0,         -- MaBP - int
    0          -- MaCV - int
    )
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




