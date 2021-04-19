USE TSTBKhachSan
GO


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
--DBCC CHECKIDENT ('dbo.BoPhan', RESEED, 0)
DELETE dbo.BoPhan
DROP PROC USP_ThemBoPhan
DROP TABLE dbo.BoPhan
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
---------------------------------------------------PROC Thêm Chức vụ---------------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.ChucVu', RESEED, 0)
DELETE dbo.ChucVu
DROP TABLE ChucVu
GO
DROP PROC dbo.USP_ThemChucVu
CREATE PROC USP_ThemChucVu
		@TenCV NVARCHAR(100)
	AS
	BEGIN
		DECLARE @MaCV NVARCHAR(20)
		SET @MaCV=(SELECT IDENT_CURRENT('ChucVu'))+1
		IF EXISTS (SELECT * FROM dbo.ChucVu WHERE ID = @MaCV) 
			SET @MaCV=@MaCV+1
			SET @MaCV='CV'+REPLICATE('0',2)+@MaCV
			INSERT INTO dbo.ChucVu VALUES(@MaCV,@TenCV)
	END
GO
EXEC dbo.USP_ThemChucVu @TenCV = N'Admin'
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí Sảnh'
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí Phòng'

SELECT * FROM dbo.ChucVu
DROP PROC dbo.USP_ThemChucVu
GO
----------------------------------PROC Thêm Danh Mục--------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.DanhMuc', RESEED, 0)
DELETE dbo.DanhMuc
go
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
DELETE dbo.NhanVien
go
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
DROP PROC dbo.USP_ThemNhanVien
GO
-------------------------------------PROC Thêm Nhà cung cấp----------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.NhaCungCap', RESEED, 0)
DELETE dbo.NhaCungCap
go
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
DROP PROC dbo.USP_ThemNhaCungCap
GO
-------------------------------------PROC Thêm HoaDonMuaTB----------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.HoaDonMuaTB', RESEED, 0)
DELETE dbo.HoaDonMuaTB
go
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

-------------------------------------	PROC Thêm Tài Khoản ------------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.TaiKhoan', RESEED, 0)
DROP TABLE dbo.TaiKhoan
DELETE dbo.TaiKhoan
GO
DROP PROC USP_ThemTaiKhoan
go
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
		SET @MaTK=(SELECT IDENT_CURRENT('TaiKhoan'))+1
		IF EXISTS (SELECT * FROM dbo.TaiKhoan WHERE MaTK = @MaTK) 
			SET @MaTK=@MaTK+1
			SET @MaTK='TK'+REPLICATE('0',2)+@MaTK
			INSERT INTO dbo.TaiKhoan VALUES(@MaTK,@MaNV,@TenTK,@Pass,@Email,@TrangThai,@LoaiND)
	END
GO

EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV001',@TenTK = N'Nv1',@Pass=N'1',@Email = N'nv1@gmail.com',@TrangThai= N'Đang Hoạt Động',@LoaiND = N'User'
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV002',@TenTK = N'Nv2',@Pass=N'2',@Email = N'nv2@gmail.com',@TrangThai= N'Đang Hoạt Động',@LoaiND = N'User'
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV003',@TenTK = N'Nv3',@Pass=N'3',@Email = N'nv3@gmail.com',@TrangThai= N'Đang Hoạt Động',@LoaiND = N'User'

SELECT * FROM dbo.TaiKhoan

-------------------------------------	PROC Thêm Thiết bị ------------------------------------------------
--Cần xử lí trong c#, nếu reset tất cả data trong bảng thì set lại mã = 1 khi thêm mới
--DBCC CHECKIDENT ('dbo.ThietBi', RESEED, 0)
DROP TABLE dbo.ThietBi
GO
DROP PROC USP_ThemThietBi
go
CREATE PROC USP_ThemThietBi
		@TenTB NVARCHAR(255),
		@DonVi NVARCHAR(50),
		@SoLuongHienHuu INT,
		@MaDanhMuc NVARCHAR(20),
		@MaBP NVARCHAR(20),
		@ThoiGianBH DATE,
		@TinhTrangTB NVARCHAR(50),
		@MaNCC NVARCHAR(20),
		@MaHDMuaTB NVARCHAR(20),
		@GhiChu NVARCHAR(300)

	AS
	BEGIN
		DECLARE @MaTB NVARCHAR(20)
		SET @MaTB=(SELECT IDENT_CURRENT('ThietBi'))+1
		IF EXISTS (SELECT * FROM dbo.ThietBi WHERE MaTB = @MaTB) 
			SET @MaTB=@MaTB+1
			SET @MaTB='TB'+REPLICATE('0',2)+@MaTB
			INSERT INTO dbo.ThietBi VALUES(@MaTB,@TenTB,@DonVi,@SoLuongHienHuu,@MaDanhMuc,@MaBP,@ThoiGianBH,@TinhTrangTB,@MaNCC,@MaHDMuaTB,@GhiChu)
	END
GO

EXEC dbo.USP_ThemThietBi @TenTB = N'Ghế số 1',@DonVi = N'Cái',@SoLuongHienHuu = 2,@MaDanhMuc = N'DM002',@MaBP = N'BP001',
						 @ThoiGianBH = '2023/04/19',@TinhTrangTB = 'Tốt',@MaNCC = 'NCC001',@MaHDMuaTB = 'HDM001',@GhiChu = ''

SELECt * FROM dbo.BoPhan
SELECT * FROM dbo.TaiKhoan
SELECT * FROM dbo.NhanVien
SELECT * FROM dbo.DanhMuc
