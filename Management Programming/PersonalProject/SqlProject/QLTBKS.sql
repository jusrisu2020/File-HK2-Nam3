------------------------------------  Project ----------------------------------------------------------
CREATE DATABASE TSTBKhachSan
GO
USE TSTBKhachSan
GO
------------------------------------  Function TimKiemGanDung ----------------------------------------------------------
CREATE FUNCTION dbo.fuConvertToUnsign1 ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput IF @strInput = '' 
		RETURN @strInput DECLARE @RT NVARCHAR(4000) 
		DECLARE @SIGN_CHARS NCHAR(136) 
		DECLARE @UNSIGN_CHARS NCHAR (136) 
		SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế 
							ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý 
							ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ 
							ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
		SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee 
							iiiiiooooooooooooooouuuuuuuuuuyyyyy 
							AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII 
							OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
		DECLARE @COUNTER INT 
		DECLARE @COUNTER1 INT 
		SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
		BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
		BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
	ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = REPLACE(@strInput,' ','-') 
	RETURN @strInput 
END
GO
------------------------------------BoPhan ------------------------------------------------
CREATE TABLE BoPhan
(
	ID INT IDENTITY,
	MaBP NVARCHAR(20) PRIMARY KEY,
	TenBP NVARCHAR(100),
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
CREATE PROC USP_SelectBoPhan
AS SELECT * FROM dbo.BoPhan
GO
EXEC USP_SelectBoPhan
GO
--------------------	Tìm kiếm gần đúng
CREATE PROC USP_TKTenBoPhan
	@TenBP NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.BoPhan WHERE dbo.fuConvertToUnsign1(TenBP) LIKE N'%'+dbo.fuConvertToUnsign1(@TenBP)+'%'
END
GO
EXEC USP_TKTenBoPhan N'a'
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

EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Trần Long Kiên',@SDT = N'147258',@DiaChi = 'TP.HCM',
						  @Email = N'longkien@gmail.com',@STK = N'123456',@TenCongTy = N'Công ty bàn ghế Long Kiên'
EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Hải Lý',@SDT = N'111111',@DiaChi = 'Cà Mau',
						  @Email = N'haily@gmail.com',@STK = N'222222',@TenCongTy = N'Công ty Hải lý'
GO
CREATE PROC USP_SelectNhaCungCap
AS SELECT * FROM dbo.NhaCungCap
GO
EXEC USP_SelectNhaCungCap
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

EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Bàn'
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Ghế'
EXEC dbo.USP_ThemDanhMuc @TenDanhMuc = N'Thiết bị vệ sinh'
GO

CREATE PROC USP_SelectDanhMuc
AS SELECT * FROM dbo.DanhMuc
GO
EXEC USP_SelectDanhMuc
GO
-------------------------------------ChucVu ------------------------------------------------
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
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí'
EXEC dbo.USP_ThemChucVu @TenCV = N'Nhân viên khu vực'
GO

CREATE PROC USP_SelectChucVu
AS SELECT * FROM dbo.ChucVu
GO
EXEC USP_SelectChucVu
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
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nguyễn Văn Lâm',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'012345',@Email = N'lam@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP01',@MaCV = N'CV01'
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nguyễn Thành Nam',@GioiTinh = N'Nam',@NgaySinh = '1/2/1990',
						  @DiaChi = N'Cần Thơ',@SDT = N'111222',@Email = N'nam@gmail.com',
						  @TonGiao = N'Thiên Chúa',@CMND = N'121212',@MaBP = N'BP02',@MaCV = N'CV02'
EXEC dbo.USP_ThemNhanVien @HoTen = N'Lý Nhã Kỳ',@GioiTinh = N'Nữ',@NgaySinh = '1/3/1990',
						  @DiaChi = N'Long An',@SDT = N'22221111',@Email = N'ky@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'1212111',@MaBP = N'BP03',@MaCV = N'CV03'
GO
CREATE PROC USP_SelectNhanVien
AS SELECT * FROM dbo.NhanVien
GO
EXEC dbo.USP_SelectNhanVien
GO
--------------------------------------------------------Tài khoản

DROP TABLE dbo.TaiKhoan
DROP PROC USP_ThemTaiKhoan

CREATE TABLE TaiKhoan
(
	Id INT IDENTITY,
	MaTK NVARCHAR(20) PRIMARY KEY,
	MaNV NVARCHAR(20) CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	TenTK NVARCHAR(100),
	TenHienThi NVARCHAR(100),
	Pass NVARCHAR(100),
	MaCV NVARCHAR(20) CONSTRAINT FK_TaiKhoan_ChucVu FOREIGN KEY(MaCV) REFERENCES dbo.ChucVu(MaCV)
)
GO

CREATE PROC USP_ThemTaiKhoan
		@MaNV NVARCHAR(20),
		@TenTK NVARCHAR(100),
		@TenHienThi NVARCHAR(100),
		@Pass NVARCHAR(100),
		@MaCV NVARCHAR(20)
	AS
	BEGIN
		DECLARE @MaTK NVARCHAR(20)
		SET @MaTK=(SELECT IDENT_CURRENT('dbo.TaiKhoan'))
		IF EXISTS (SELECT * FROM dbo.TaiKhoan WHERE ID = @MaTK)
			SET @MaTK=@MaTK+1
			SET @MaTK='TK'+REPLICATE('0',2-LEN(@MaTK))+@MaTK
			INSERT INTO dbo.TaiKhoan VALUES(@MaTK,@MaNV,@TenTK,@TenHienThi,@Pass,@MaCV)
	END
GO
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV01',@TenTK = N'ad',@TenHienThi='Tricua',@Pass=N'1', @MaCV = N'CV01'
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV02',@TenTK = N'tk1',@TenHienThi='Tricua1',@Pass=N'1', @MaCV = N'CV02'
EXEC dbo.USP_ThemTaiKhoan @MaNV = 'NV02',@TenTK = N'tk2',@TenHienThi='Tricua2',@Pass=N'1', @MaCV = N'CV01'
GO
CREATE PROC USP_DangNhap
	@TenTK NVARCHAR(100),
	@Pass NVARCHAR(100)
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE @TenTK = TenTK AND  @Pass = Pass
END
GO
EXEC USP_DangNhap N'ad', N'1'
GO
SELECT *FROM dbo.TaiKhoan WHERE TenTK = 'ad';
--PROC Select Tất cả tài khoản
CREATE PROC USP_SelectATaiKhoan
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan
END
GO
EXEC USP_SelectATaiKhoan
GO

CREATE PROC USP_UpdateTaiKhoan
	@TenTK NVARCHAR(100),
	@TenHienThi NVARCHAR(100),
	@Pass NVARCHAR(100),
	@newPass NVARCHAR(100)
AS
BEGIN
	DECLARE @RightPass INT = 0

	SELECT @RightPass = COUNT(*)FROM dbo.TaiKhoan WHERE TenTK = @TenTK AND Pass = @Pass;

	IF(@RightPass = 1)
	BEGIN
	    IF(@newPass = NULL OR @newPass = '')
		BEGIN
		    UPDATE dbo.TaiKhoan SET TenHienThi = @TenHienThi WHERE TenTK = @TenTK
		END
		ELSE
		    UPDATE dbo.TaiKhoan SET TenHienThi = @TenHienThi, Pass = @newPass WHERE TenTK = @TenTK 
	END
END
GO

EXEC USP_UpdateTaiKhoan @TenTK,@TenHienThi,@Pass,@newPass



EXEC USP_UpdateTaiKhoan @TenTK = 'ad',@TenHienThi='trtr',@Pass='1',@newPass='2'

SELECT * FROM dbo.TaiKhoan
-------------------------------------HoaDonMuaTB CHƯA ------------------------------------------------
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

EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV01',@MaNCC = 'NCC01'
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV01',@MaNCC = 'NCC01'
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV01',@MaNCC = 'NCC01'
GO
SELECT * FROM HoaDonMuaTB
GO
-------------------------------------ChiTietHoaDonMuaTB ------------------------------------------------
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
GO
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
		SET @MaTB=(SELECT IDENT_CURRENT('dbo.ThietBi'))
		IF EXISTS (SELECT * FROM dbo.ThietBi WHERE ID = @MaTB)
			SET @MaTB=@MaTB+1
			SET @MaTB='TB'+REPLICATE('0',2-LEN(@MaTB))+@MaTB
			INSERT INTO dbo.ThietBi VALUES(@MaTB,@TenTB,@DonVi,@SoLuongHienHuu,@MaDanhMuc,@MaBP,@ThoiGianBH,
			@TinhTrangTB,@MaNCC,@MaHDMuaTB,@GhiChu)
	END
GO
EXEC dbo.USP_ThemThietBi @TenTB = N'Ghế tiếp khách',@DonVi = N'bộ',@SoLuongHienHuu = 10,
						  @MaDanhMuc = N'DM02',@MaBP = N'BP01',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= N'Tốt',@MaNCC='NCC01',@MaHDMuaTB='HDM10',@GhiChu=N''
EXEC dbo.USP_ThemThietBi @TenTB = N'Bàn tiếp khách',@DonVi = N'bộ',@SoLuongHienHuu = 10,
						  @MaDanhMuc = N'DM01',@MaBP = N'BP02',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= N'Tốt',@MaNCC='NCC01',@MaHDMuaTB='HDM10',@GhiChu=N''
EXEC dbo.USP_ThemThietBi @TenTB = N'Bàn tiếp khách',@DonVi = N'bộ',@SoLuongHienHuu = 10,
						  @MaDanhMuc = N'DM02',@MaBP = N'BP02',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= N'Tốt',@MaNCC='NCC01',@MaHDMuaTB='HDM10',@GhiChu=N''
GO

SELECT * FROM dbo.ThietBi WHERE MaDanhMuc = 'DM01';
CREATE PROC USP_SelectAThietBi
AS SELECT * FROM dbo.ThietBi
EXEC USP_SelectAThietBi

SELECT * FROM dbo.ThietBi WHERE MaBP = 'BP01';
SELECT * FROM dbo.DanhMuc
SELECT * FROM dbo.BoPhan
SELECT * FROM dbo.NhaCungCap
SELECT * FROM dbo.HoaDonMuaTB

-------------------------------------------------ThietBi chưa thêm---------------------------------

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
-------------------------------------------------XuLyTB chưa thêm---------------------------------

CREATE TABLE XuLyTB
(
	Id INT IDENTITY,
	MaXuLyTB NVARCHAR(20) PRIMARY KEY,
	MaNV NVARCHAR(20) CONSTRAINT FK_XuLyTB_NhanVien FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV),
	NgayXuLy DATE
)
-------------------------------------------------ChiTietXuLyTB chưa thêm---------------------------------

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
-------------------------------------------------PhieuBanGiao chưa thêm---------------------------------

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







