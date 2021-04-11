USE ProjectPrototype1
go
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




