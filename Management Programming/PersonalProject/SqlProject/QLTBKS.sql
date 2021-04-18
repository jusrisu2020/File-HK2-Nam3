------------------------------------  Project ----------------------------------------------------------
CREATE DATABASE TSTBKhachSan
GO
USE TSTBKhachSan
GO

-------------------------------------	Table Tài Khoản ------------------------------------------------
CREATE TABLE BoPhan
(
	ID INT IDENTITY,
	MaBP NVARCHAR(20) PRIMARY KEY,
	TenBP NVARCHAR(100)
)

CREATE TABLE ChucVu
(
	ID INT IDENTITY,
	MaCV NVARCHAR(20) PRIMARY KEY,
	TenCV NVARCHAR(100)
)

CREATE TABLE DanhMuc
(
	ID INT IDENTITY,
	MaDanhMuc NVARCHAR(20) PRIMARY KEY,
	TenDanhMuc NVARCHAR(255)
)


CREATE TABLE NhanVien
(
	ID INT IDENTITY,
	MaNV NVARCHAR(20) PRIMARY KEY,
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(50),
	Email NVARCHAR(50),
	TonGiao NVARCHAR(50),
	CMND NVARCHAR(50),
	MaBP NVARCHAR(20) CONSTRAINT FK_NhanVien_BoPhan FOREIGN KEY(MaBP) REFERENCES  dbo.BoPhan(MaBP),
	MaCV NVARCHAR(20) CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY(MaCV) REFERENCES  dbo.ChucVu(MaCV)
)

CREATE TABLE NhaCungCap
(
	Id INT IDENTITY,
	MaNCC NVARCHAR(20) PRIMARY KEY,
	TenNCC NVARCHAR(255),
	SDT NVARCHAR(50),
	DiaChi NVARCHAR(300),
	Email NVARCHAR(50),
	STK NVARCHAR(50),
	TenCongTy NVARCHAR(300)
)

CREATE TABLE HoaDonMuaTB
(
	Id INT IDENTITY,
	MaHDMua NVARCHAR(20) PRIMARY KEY,
	NgayMuaTB DATE,
	MaNV NVARCHAR(20) CONSTRAINT FK_HoaDonMuaTB_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	MaNCC NVARCHAR(20) CONSTRAINT FK_HoaDonMuaTB_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC)
)

CREATE TABLE ChiTietHoaDonMuaTB
(
	MaHDMua NVARCHAR(20) CONSTRAINT FK_ChiTietHoaDonMuaTB_HoaDonMuaTB FOREIGN KEY(MaHDMua) REFERENCES dbo.HoaDonMuaTB(MaHDMua),
	TenTB NVARCHAR(255),
	MaDanhMuc NVARCHAR(20) CONSTRAINT FK_ChiTietHoaDonMuaTB_DanhMuc FOREIGN KEY(MaDanhMuc) REFERENCES dbo.DanhMuc(MaDanhMuc),
	MaBP NVARCHAR(20) CONSTRAINT FK_ChiTietHoaDonMuaTB_BoPhan FOREIGN KEY(MaBP) REFERENCES dbo.BoPhan(MaBP),
	DonVi NVARCHAR(255),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT
)

CREATE TABLE TaiKhoan
(
	Id INT IDENTITY,
	MaTK NVARCHAR(20) PRIMARY KEY,
	MaNV NVARCHAR(20) CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	TenTK NVARCHAR(100),
	Pass NVARCHAR(100),
	Email NVARCHAR(100),
	TrangThai NVARCHAR(100),
	LoaiND NVARCHAR(100)
)

CREATE TABLE ThietBi
(
	Id INT IDENTITY,
	MaTB NVARCHAR(20) PRIMARY KEY,
	TenTB NVARCHAR(255),
	DonVi NVARCHAR(50),
	SoLuongHienHuu INT,
	MaDanhMuc NVARCHAR(20) CONSTRAINT FK_ThietBi_DanhMuc FOREIGN KEY (MaDanhMuc) REFERENCES dbo.NhanVien(MaNV) ,
	MaBP NVARCHAR(20) CONSTRAINT FK_ThietBi_BoPhan FOREIGN KEY(MaBP) REFERENCES dbo.BoPhan(MaBP),
	ThoiGianBH DATE,
	TinhTrangTB NVARCHAR(50),
	MaNCC NVARCHAR(20) CONSTRAINT FK_ThietBi_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
	MaHDMuaTB NVARCHAR(20) CONSTRAINT FK_ThietBi_HoaDonMuaTB FOREIGN KEY(MaHDMuaTB) REFERENCES dbo.HoaDonMuaTB(MaHDMua),
	GhiChu NVARCHAR(300)
)

CREATE TABLE BaoCaoTBHong
(
	Id INT IDENTITY,
	MaBC NVARCHAR(20) PRIMARY KEY,
	MaTB NVARCHAR(20) CONSTRAINT FK_BaoCaoTBHong_ThietBi FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB),
	MaNV NVARCHAR(20) CONSTRAINT FK_BaoCaoTBHong_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	NgayBC DATE,
	PhuongThucPhat NVARCHAR(50),
	TienPhat INT
)

CREATE TABLE XuLyTB
(
	Id INT IDENTITY,
	MaXuLyTB NVARCHAR(20) PRIMARY KEY,
	MaNV NVARCHAR(20) CONSTRAINT FK_XuLyTB_NhanVien FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV),
	NgayXuLy DATE
)

CREATE TABLE ChiTietXuLyTB
(
	MaXuLyTB NVARCHAR(20) CONSTRAINT FK_ChiTietXuLyTB_XuLyTB FOREIGN KEY(MaXuLyTB) REFERENCES dbo.XuLyTB(MaXuLyTB),
	NgayXuLy DATE,
	PhuongThucXuLy NVARCHAR(50),
	MaTB NVARCHAR(20) CONSTRAINT FK_ChiTietXuLyTB_ThietBi FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB),
	TenTB NVARCHAR(50),
	DonVi NVARCHAR(50),
	SoLuong INT,
	DonGia INT,
	ThanhTien INT,
	NguoiMua NVARCHAR(50)
)

CREATE TABLE PhieuBanGiao
(
	Id INT IDENTITY,
	MaBG NVARCHAR(20) PRIMARY KEY,
	MaNVBG NVARCHAR(20) CONSTRAINT FK_PhieuBanGiao_NhanVienBG FOREIGN KEY(MaNVBG) REFERENCES dbo.NhanVien(MaNV),
	MaNVNhan NVARCHAR(20) CONSTRAINT FK_PhieuBanGiao_NhanVienNhan FOREIGN KEY(MaNVNhan) REFERENCES dbo.NhanVien(MaNV),
	NgayMuon DATE,
	MaTB NVARCHAR(20) CONSTRAINT FK_PhieuBanGiao_ThietBi FOREIGN KEY(MaTB) REFERENCES dbo.ThietBi(MaTB),
	TenTB NVARCHAR(255),
	MaDanhMuc NVARCHAR(20) CONSTRAINT FK_PhieuBanGiao_DanhMuc FOREIGN KEY(MaDanhMuc) REFERENCES dbo.DanhMuc(MaDanhMuc),
	MaBPTB NVARCHAR(20) CONSTRAINT FK_PhieuBanGiao_BoPhan FOREIGN KEY(MaBPTB) REFERENCES dbo.BoPhan(MaBP),
	DonVi NVARCHAR(50),
	SoLuong INT,
	TinhTrang NVARCHAR(50)
)

------------------------------------- STORE PROC INSERT----------------------------------------
-- SELECT * FROM BoPhan 
-- SELECT * FROM ChucVu
-- SELECT * FROM DanhMuc
-- SELECT * FROM NhanVien
-- SELECT * FROM NhaCungCap
--HoaDonMuaTB
--ChiTietHoaDonMuaTB
--TaiKhoan
--ThietBi
--BaoCaoTBHong
--XuLyTB
--ChiTietXuLyTB
--PhieuBanGiao
----------------------------------PROC Thêm Bộ Phận--------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.ChucVu', RESEED, 0)
GO
CREATE PROC USP_ThemBoPhan
		@TenBP NVARCHAR(50)
	AS
	BEGIN
		DECLARE @MaBP NVARCHAR(20)
		SET @MaBP=(SELECT IDENT_CURRENT('BoPhan'))+1
		IF EXISTS (SELECT * FROM dbo.BoPhan WHERE MaBP = @MaBP) 
			SET @MaBP=@MaBP+1
			SET @MaBP='BP'+REPLICATE('0',2)+@MaBP
			INSERT INTO dbo.BoPhan VALUES(@MaBP,@TenBP)
	END
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Sảnh đón tiếp'
EXEC dbo.USP_ThemBoPhan @TenBP = N'Buồng phòng'
EXEC dbo.USP_ThemBoPhan @TenBP = N'Khu vực Bar'
EXEC dbo.USP_ThemBoPhan @TenBP = N'Khu vực Bếp'
EXEC dbo.USP_ThemBoPhan @TenBP = N'Nhà Hàng'
EXEC dbo.USP_ThemBoPhan @TenBP = N'Khu vực khác'
GO
SELECT * FROM dbo.BoPhan
---------------------------------------------------PROC Thêm Chức vụ---------------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.ChucVu', RESEED, 0)
CREATE PROC USP_ThemChucVu
		@TenCV NVARCHAR(100)
	AS
	BEGIN
		DECLARE @MaCV NVARCHAR(20)
		SET @MaCV=(SELECT IDENT_CURRENT('ChucVu'))+1
		IF EXISTS (SELECT * FROM dbo.ChucVu WHERE MaCV = @MaCV) 
			SET @MaCV=@MaCV+1
			SET @MaCV='CV'+REPLICATE('0',2)+@MaCV
			INSERT INTO dbo.ChucVu VALUES(@MaCV,@TenCV)
	END
GO
EXEC dbo.USP_ThemChucVu @TenCV = N'Admin'
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí Sảnh'
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí Phòng'

SELECT * FROM dbo.ChucVu


DELETE dbo.ChucVu
DROP PROC dbo.USP_ThemChucVu
GO
----------------------------------PROC Thêm Danh Mục--------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.DanhMuc', RESEED, 0)
CREATE PROC USP_ThemDanhMuc
		@TenDanhMuc NVARCHAR(100)
	AS
	BEGIN
		DECLARE @MaDanhMuc NVARCHAR(20)
		SET @MaDanhMuc=(SELECT IDENT_CURRENT('DanhMuc'))+1
		IF EXISTS (SELECT * FROM dbo.DanhMuc WHERE MaDanhMuc = @MaDanhMuc) 
			SET @MaDanhMuc=@MaDanhMuc+1
			SET @MaDanhMuc='DM'+REPLICATE('0',2)+@MaDanhMuc
			INSERT INTO dbo.DanhMuc VALUES(@MaDanhMuc,@TenDanhMuc)
	END
GO
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Thiết bị vệ sinh'
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Bàn'
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Ghế'

SELECT * FROM dbo.DanhMuc

DELETE dbo.DanhMuc
DROP PROC dbo.USP_ThemDanhMuc
GO
-------------------------------------PROC Thêm Nhân viên----------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.NhanVien', RESEED, 0)
CREATE PROC USP_ThemNhanVien
		@HoTen NVARCHAR(50),
		@GioiTinh NVARCHAR(5),
		@NgaySinh DATE,
		@DiaChi NVARCHAR(50),
		@SDT NVARCHAR(50),
		@Email NVARCHAR(50),
		@TonGiao NVARCHAR(50),
		@CMND NVARCHAR(50),
		@MaBP NVARCHAR(20),
		@MaCV NVARCHAR(20)
	AS
	BEGIN
		DECLARE @MaNV NVARCHAR(20)
		SET @MaNV=(SELECT IDENT_CURRENT('NhanVien'))+1
		IF EXISTS (SELECT * FROM dbo.NhanVien WHERE MaNV = @MaNV) 
			SET @MaNV=@MaNV+1
			SET @MaNV='NV'+REPLICATE('0',2)+@MaNV
			INSERT INTO dbo.NhanVien VALUES(@MaNV,@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Email,@TonGiao,@CMND,@MaBP,@MaCV)
	END
GO
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nhân viên 1',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'123456',@Email = N'nv1@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP001',@MaCV = N'CV002'
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nhân viên 2',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'123456',@Email = N'nv1@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP001',@MaCV = N'CV002'
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nhân viên 3',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'123456',@Email = N'nv1@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP001',@MaCV = N'CV002'

SELECT * FROM dbo.NhanVien
DELETE dbo.NhanVien
DROP PROC dbo.USP_ThemNhanVien
GO
-------------------------------------PROC Thêm Nhà cung cấp----------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.NhaCungCap', RESEED, 0)
CREATE PROC USP_ThemNhaCungCap
		@TenNCC NVARCHAR(255),
		@SDT NVARCHAR(50),
		@DiaChi NVARCHAR(300),
		@Email NVARCHAR(50),
		@STK NVARCHAR(50),
		@TenCongTy NVARCHAR(300)
	AS
	BEGIN
		DECLARE @MaNCC NVARCHAR(20)
		SET @MaNCC=(SELECT IDENT_CURRENT('NhaCungCap'))+1
		IF EXISTS (SELECT * FROM dbo.NhaCungCap WHERE MaNCC = @MaNCC) 
			SET @MaNCC=@MaNCC+1
			SET @MaNCC='NCC'+REPLICATE('0',2)+@MaNCC
			INSERT INTO dbo.NhaCungCap VALUES(@MaNCC,@TenNCC,@SDT,@DiaChi,@Email,@STK,@TenCongTy)
	END
GO

EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Nhà cung cấp 1',@SDT = N'Nam',@DiaChi = '1/1/1990',
						  @Email = N'An Giang',@STK = N'123456',@TenCongTy = N'nv1@gmail.com'
EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Nhân viên 1',@SDT = N'Nam',@DiaChi = '1/1/1990',
						  @Email = N'An Giang',@STK = N'123456',@TenCongTy = N'nv1@gmail.com'
EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Nhân viên 1',@SDT = N'Nam',@DiaChi = '1/1/1990',
						  @Email = N'An Giang',@STK = N'123456',@TenCongTy = N'nv1@gmail.com'

SELECT * FROM dbo.NhaCungCap
DELETE dbo.NhaCungCap
DROP PROC dbo.USP_ThemNhaCungCap
GO
-------------------------------------PROC Thêm HoaDonMuaTB----------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.HoaDonMuaTB', RESEED, 0)
CREATE PROC USP_ThemHoaDonMuaTB
		@NgayMuaTB DATE,
		@Manv NVARCHAR(20),
		@MaNCC NVARCHAR(20)
	AS
	BEGIN
		DECLARE @MaHDMua NVARCHAR(20)
		SET @MaHDMua=(SELECT IDENT_CURRENT('HoaDonMuaTB'))+1
		IF EXISTS (SELECT * FROM dbo.HoaDonMuaTB WHERE MaHDMua = @MaHDMua) 
			SET @MaHDMua=@MaHDMua+1
			SET @MaHDMua='HDM'+REPLICATE('0',2)+@MaHDMua
			INSERT INTO dbo.HoaDonMuaTB VALUES(@MaHDMua,@NgayMuaTB,@Manv,@MaNCC)
	END
GO

EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV002',@MaNCC = 'NCC001'
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV003',@MaNCC = 'NCC002'
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV003',@MaNCC = 'NCC002'


SELECT * FROM dbo.HoaDonMuaTB
DELETE dbo.HoaDonMuaTB
DROP PROC dbo.USP_ThemHoaDonMuaTB
GO
-------------------------------------PROC Thêm ChiTietHoaDonMuaTB----------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.ChiTietHoaDonMuaTB', RESEED, 0)
CREATE PROC USP_ThemChiTietHoaDonMuaTB
		@MaHDMua NVARCHAR(20),--FK
		@TenTB NVARCHAR(255),
		@MaDanhMuc NVARCHAR(20), --FK
		@MaBP NVARCHAR(20),--FK
		@DonVi NVARCHAR(255),
		@SoLuong INT,
		@DonGia INT
	AS
	BEGIN
		DECLARE @ThanhTien INT
		SET @ThanhTien= @DonGia * @SoLuong
		INSERT INTO dbo.ChiTietHoaDonMuaTB VALUES(@MaHDMua,@TenTB,@MaDanhMuc,@MaBP,@DonVi,@SoLuong,@DonGia,@ThanhTien)
	END
GO

EXEC dbo.USP_ThemChiTietHoaDonMuaTB @MaHDMua = N'HDM001',@TenTB = N'Ghế Dài',@MaDanhMuc = N'DM001',@MaBP = N'BP001',
									@DonVi = 'Cái',@SoLuong = 1 ,@DonGia = 200
EXEC dbo.USP_ThemChiTietHoaDonMuaTB @MaHDMua = N'HDM002',@TenTB = N'Ghế Dài thòng',@MaDanhMuc = N'DM001',@MaBP = N'BP001',
									@DonVi = 'Cái',@SoLuong = 2 ,@DonGia = 500


SELECT * FROM dbo.ChiTietHoaDonMuaTB
DELETE dbo.ChiTietHoaDonMuaTB
DROP PROC USP_ThemChiTietHoaDonMuaTB
GO

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




