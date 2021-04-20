------------------------------------  Project ----------------------------------------------------------
CREATE DATABASE TSTBKhachSan
GO
USE TSTBKhachSan
GO
USE QLCF
------------------------------------BoPhan ------------------------------------------------
CREATE TABLE BoPhan
(
	ID INT IDENTITY,
	MaBP NVARCHAR(20) PRIMARY KEY,
	TenBP NVARCHAR(100)
)
GO
CREATE PROC USP_ThemBoPhan
		@TenBP NVARCHAR(50)
	AS
	BEGIN
		DECLARE @MaBP NVARCHAR(20)
		SET @MaBP=(SELECT IDENT_CURRENT('dbo.BoPhan'))
		IF EXISTS (SELECT * FROM dbo.BoPhan WHERE ID = @MaBP)
			SET @MaBP=@MaBP+1
			SET @MaBP='BP'+REPLICATE('0',2-LEN(@MaBP))+@MaBP
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
GO

-------------------------------------ChucVu ------------------------------------------------
DROP TABLE dbo.ChucVu
DROP PROC dbo.USP_ThemChucVu
CREATE TABLE ChucVu
(
	ID INT IDENTITY,
	MaCV NVARCHAR(20) PRIMARY KEY,
	TenCV NVARCHAR(100)
)
GO
CREATE PROC USP_ThemChucVu
		@TenCV NVARCHAR(50)
	AS
	BEGIN
		DECLARE @MaCV NVARCHAR(20)
		SET @MaCV=(SELECT IDENT_CURRENT('dbo.ChucVu'))
		IF EXISTS (SELECT * FROM dbo.ChucVu WHERE ID = @MaCV)
			SET @MaCV=@MaCV+1
			SET @MaCV='CV'+REPLICATE('0',2-LEN(@MaCV))+@MaCV
			INSERT INTO dbo.ChucVu VALUES(@MaCV,@TenCV)
	END
GO
EXEC dbo.USP_ThemChucVu @TenCV = N'Admin'
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí Sảnh'
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí Phòng'
SELECT * FROM dbo.ChucVu
GO
-------------------------------------DanhMuc ------------------------------------------------

CREATE TABLE DanhMuc
(
	ID INT IDENTITY,
	MaDanhMuc NVARCHAR(20) PRIMARY KEY,
	TenDanhMuc NVARCHAR(255)
)
GO
CREATE PROC USP_ThemDanhMuc
		@TenDanhMuc NVARCHAR(50)
	AS
	BEGIN
		DECLARE @MaDanhMuc NVARCHAR(20)
		SET @MaDanhMuc=(SELECT IDENT_CURRENT('dbo.DanhMuc'))
		IF EXISTS (SELECT * FROM dbo.DanhMuc WHERE ID = @MaDanhMuc)
			SET @MaDanhMuc=@MaDanhMuc+1
			SET @MaDanhMuc='DM'+REPLICATE('0',2-LEN(@MaDanhMuc))+@MaDanhMuc
			INSERT INTO dbo.DanhMuc VALUES(@MaDanhMuc,@TenDanhMuc)
	END
GO
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Thiết bị vệ sinh'
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Bàn'
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Ghế'
GO
SELECT * FROM dbo.DanhMuc
GO
-------------------------------------NhanVien ------------------------------------------------
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
GO

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
		SET @MaNV=(SELECT IDENT_CURRENT('dbo.NhanVien'))
		IF EXISTS (SELECT * FROM dbo.NhanVien WHERE ID = @MaNV)
			SET @MaNV=@MaNV+1
			SET @MaNV='NV'+REPLICATE('0',2-LEN(@MaNV))+@MaNV
			INSERT INTO dbo.NhanVien VALUES(@MaNV,@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Email,@TonGiao,@CMND,@MaBP,@MaCV)
	END
GO
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nhân viên 1',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'123456',@Email = N'nv1@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP01',@MaCV = N'CV01'
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nhân viên 2',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'123456',@Email = N'nv1@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP01',@MaCV = N'CV01'
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nhân viên 3',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'123456',@Email = N'nv1@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP01',@MaCV = N'CV01'
SELECT * FROM dbo.NhanVien
GO
-------------------------------------NhaCungCap ------------------------------------------------

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
GO
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
		SET @MaNCC=(SELECT IDENT_CURRENT('dbo.NhaCungCap'))
		IF EXISTS (SELECT * FROM dbo.NhaCungCap WHERE ID = @MaNCC)
			SET @MaNCC=@MaNCC+1
			SET @MaNCC='NCC'+REPLICATE('0',2-LEN(@MaNCC))+@MaNCC
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
GO


-------------------------------------HoaDonMuaTB ------------------------------------------------
CREATE TABLE HoaDonMuaTB
(
	Id INT IDENTITY,
	MaHDMua NVARCHAR(20) PRIMARY KEY,
	NgayMuaTB DATE,
	MaNV NVARCHAR(20) CONSTRAINT FK_HoaDonMuaTB_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	MaNCC NVARCHAR(20) CONSTRAINT FK_HoaDonMuaTB_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC)
)
GO
CREATE PROC USP_ThemHoaDonMuaTB
		@NgayMuaTB DATE,
		@MaNV NVARCHAR(20),
		@MaNCC NVARCHAR(20)
	AS
	BEGIN
		DECLARE @MaHDMua NVARCHAR(20)
		SET @MaHDMua=(SELECT IDENT_CURRENT('dbo.HoaDonMuaTB'))
		IF EXISTS (SELECT * FROM dbo.HoaDonMuaTB WHERE ID = @MaHDMua)
			SET @MaHDMua=@MaHDMua+1
			SET @MaHDMua='HDM'+REPLICATE('0',2-LEN(@MaHDMua))+@MaHDMua
			INSERT INTO dbo.HoaDonMuaTB VALUES(@MaHDMua,@NgayMuaTB,@MaNV,@MaNCC)
	END
GO

EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV02',@MaNCC = 'NCC01'
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV03',@MaNCC = 'NCC02'
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV03',@MaNCC = 'NCC02'
GO
SELECT * FROM HoaDonMuaTB
GO
-------------------------------------HoaDonMuaTB ------------------------------------------------
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
GO
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

EXEC dbo.USP_ThemChiTietHoaDonMuaTB @MaHDMua = N'HDM01',@TenTB = N'Ghế Dài',@MaDanhMuc = N'DM01',@MaBP = N'BP01',
									@DonVi = 'Cái',@SoLuong = 1 ,@DonGia = 200
EXEC dbo.USP_ThemChiTietHoaDonMuaTB @MaHDMua = N'HDM02',@TenTB = N'Ghế Dài thòng',@MaDanhMuc = N'DM01',@MaBP = N'BP01',
									@DonVi = 'Cái',@SoLuong = 2 ,@DonGia = 500


SELECT * FROM dbo.ChiTietHoaDonMuaTB
GO

-------------------------------------TaiKhoan ------------------------------------------------
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
GO
CREATE PROC USP_ThemTaiKhoan
		@MaNV NVARCHAR(20),
		@TenTK NVARCHAR(100),
		@Pass NVARCHAR(100),
		@Email NVARCHAR(100),
		@TrangThai NVARCHAR(100),
		@LoaiND NVARCHAR(100)
	AS
	BEGIN
		DECLARE @MaTK NVARCHAR(20)
		SET @MaTK=(SELECT IDENT_CURRENT('dbo.TaiKhoan'))
		IF EXISTS (SELECT * FROM dbo.TaiKhoan WHERE ID = @MaTK)
			SET @MaTK=@MaTK+1
			SET @MaTK='TK'+REPLICATE('0',2-LEN(@MaTK))+@MaTK
			INSERT INTO dbo.TaiKhoan VALUES(@MaTK,@MaNV,@TenTK,@Pass,@Email,@TrangThai,@LoaiND)
	END
GO
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV01',@TenTK = N'Nv1',@Pass=N'1',@Email = N'nv1@gmail.com',@TrangThai= N'Đang Hoạt Động',@LoaiND = N'User'
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV01',@TenTK = N'Nv2',@Pass=N'2',@Email = N'nv2@gmail.com',@TrangThai= N'Đang Hoạt Động',@LoaiND = N'User'
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV01',@TenTK = N'Nv3',@Pass=N'3',@Email = N'nv3@gmail.com',@TrangThai= N'Đang Hoạt Động',@LoaiND = N'User'
GO
CREATE PROC USP_SelectTaiKhoan
	@TenTK NVARCHAR(100),
	@Pass NVARCHAR(100)
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE TenTK = @TenTK AND Pass = @Pass
END
EXEC USP_SelectTaiKhoan N'nv1', N'1'
GO
-------------------------------------------------ThietBi chưa thêm---------------------------------
CREATE TABLE ThietBi
(
	Id INT IDENTITY,
	MaTB NVARCHAR(20) PRIMARY KEY,
	TenTB NVARCHAR(255),
	DonVi NVARCHAR(50),
	SoLuongHienHuu INT,
	MaDanhMuc NVARCHAR(20) CONSTRAINT FK_ThietBi_DanhMuc FOREIGN KEY (MaDanhMuc) REFERENCES dbo.DanhMuc(MaDanhMuc) ,
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






