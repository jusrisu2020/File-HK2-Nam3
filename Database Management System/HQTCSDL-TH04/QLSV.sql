CREATE DATABASE QLSV
ON PRIMARY
  ( NAME='QLSV_data',
    FILENAME=
       'c:\temp\QLSV.mdf',
    SIZE=4MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB)
LOG ON
  ( NAME='QLSV_log',
    FILENAME =
       'c:\temp\QLSV.ldf',
    SIZE=1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB);
GO

USE QLSV;
CREATE TABLE Khoa (
	MaKhoa char(4) NOT NULL PRIMARY KEY,
	TenKhoa nvarchar(30) NOT NULL,
	DiaChi nvarchar(50) NULL,
	DienThoai varchar(10)
);
CREATE TABLE SinhVien (
	MaSV char(8) NOT NULL PRIMARY KEY,
	HoTen nvarchar(30) NOT NULL,
	NgaySinh Datetime,
	MaKhoa char(4) REFERENCES Khoa (MaKhoa)
);

CREATE TABLE MonHoc (
	MaMon varchar(5) NOT NULL PRIMARY KEY,
	TenMon nvarchar(30) NOT NULL,
	SoTinChi SmallInt,
	TenGV nvarchar(30)
);

CREATE TABLE DangKyHoc (
	MaSV char (8),
	MaMon varchar(5),
	HocKy smallInt
);

USE QLSV
INSERT INTO Khoa VALUES ('TOAN', N'Toán - Tin', N'Nhà C','37547325');
INSERT INTO Khoa VALUES ('CNTT', N'Công nghệ thông tin', N'Nhà C','37547100')
INSERT INTO Khoa (MaKhoa,TenKhoa,DiaChi) VALUES ('DIAL',N'Địa lý',N'Nhà A1')
INSERT INTO Khoa(MaKhoa,TenKhoa,DiaChi) VALUES ('HOAH', N'Hóa học',N'Nhà A2')	

INSERT INTO SinhVien VALUES ('K6100001',N'Phạm Văn Bình', '1990-2-24','TOAN')
INSERT INTO SinhVien VALUES ('K6100002',N'Nguyễn Thị Hoài','1991-4-12','CNTT')
INSERT INTO SinhVien VALUES('K6100003',N'Trần Ngọc','1990-4-15','DIAL')
INSERT INTO SinhVien VALUES('K6100004',N'Nguyễn Tấn Dũng','1992-2-3','CNTT')
INSERT INTO SinhVien VALUES('K6100005',N'Trương Tấn Sang','1990-12-4','DIAL')
INSERT INTO SinhVien VALUES('K6100006',N'Nguyễn Sinh Hùng','1992-3-3','HOAH')

INSERT INTO Monhoc VALUES('GT1',N'Giải tích 1',2,N'Đỗ Đức Thái')
INSERT INTO Monhoc VALUES('DSTT',N'Đại số tuyến tính',3,N'Nguyễn Văn Trào')
INSERT INTO Monhoc VALUES('HH',N'Hình học Afin',2,N'Nguyễn Doãn Tuấn')
INSERT INTO Monhoc VALUES('XSTK',N'Xác suất thống kê',2,N'Đỗ Đức Thái')

INSERT INTO DangKyHoc VALUES('K6100001','GT1',1)
INSERT INTO DangKyHoc VALUES('K6100001','DSTT',2)
INSERT INTO DangKyHoc VALUES('K6100001','HH',	1)
INSERT INTO DangKyHoc VALUES('K6100002','DSTT',1)
INSERT INTO DangKyHoc VALUES('K6100002','XSTK',2)
INSERT INTO DangKyHoc VALUES('K6100002','GT1',1)
INSERT INTO DangKyHoc VALUES('K6100003','HH',1)
INSERT INTO DangKyHoc VALUES('K6100003','GT1',1)
INSERT INTO DangKyHoc VALUES('K6100003','XSTK',	2)
INSERT INTO DangKyHoc VALUES('K6100004','XSTK',3)
INSERT INTO DangKyHoc VALUES('K6100004','DSTT',3)
INSERT INTO DangKyHoc VALUES('K6100004','DSTT',1)
INSERT INTO DangKyHoc VALUES('K6100004','DSTT',1)


SELECT * FROM dbo.Khoa
SELECT * FROM dbo.SinhVien
SELECT * FROM dbo.Monhoc
SELECT * FROM DangKyHoc
GO
-------------------------------------------------------------
-----------------------------------------------------A
CREATE PROC DSMonHoc
	@Tensv NVARCHAR(100)
AS
BEGIN
    SELECT MH.TenMon 
	FROM dbo.MonHoc AS MH, DangKyHoc AS DKH, dbo.SinhVien AS SV 
	WHERE DKH.MaSV = SV.MaSV AND DKH.MaMon = MH.MaMon AND SV.HoTen = @Tensv
END
EXEC DSMonHoc N'Nguyễn Thị Hoài'
GO

------------------------------------------------------B
CREATE PROC DSSinhvien 
	@MonHoc NVARCHAR(100),
	@HocKy INT
AS
BEGIN
    SELECT SV.MaSV,SV.HoTen, K.TenKhoa
	FROM dbo.MonHoc AS MH, DangKyHoc AS DKH, dbo.SinhVien AS SV , dbo.Khoa AS K
	WHERE K.MaKhoa = SV.MaKhoa AND SV.MaSV = DKH.MaSV AND MH.MaMon = DKH.MaMon AND MH.TenMon = @MonHoc AND DKH.HocKy = @HocKy
END
EXEC DSSinhvien N'Đại số tuyến tính', 3
DROP PROC dbo.DSSinhvien
SELECT * FROM dbo.MonHoc
SELECT * FROM DangKyHoc
GO
----------------------------------------------C
CREATE VIEW DSSinhvientheokhoa
AS
SELECT TOP(99.99) PERCENT SV.MaSV, SV.HoTen, SV.NgaySinh, K.TenKhoa 
FROM dbo.SinhVien AS SV, dbo.Khoa AS K
WHERE K.MaKhoa = SV.MaKhoa ORDER BY K.TenKhoa, SV.HoTen

SELECT * FROM DSSinhvientheokhoa
GO
----------------------------------------D
CREATE FUNCTION SoluongSV(@TenKhoa NVARCHAR(100))
RETURNS int
AS
 BEGIN
	 DECLARE @SoLuongSV INT
	 SELECT @SoLuongSV = COUNT(SV.MASV) FROM dbo.SinhVien AS SV, dbo.Khoa AS K
	 WHERE K.MaKhoa = SV.MaKhoa AND K.TenKhoa = @TenKhoa
	 RETURN @SoLuongSV
 END

 DROP FUNCTION SoluongSV
 SELECT dbo.SoluongSV(N'Công nghệ thông tin') AS SLSV
 SELECT * FROM dbo.Khoa
 SELECT * FROM dbo.SinhVien
 GO
-----------------------------------------E
--EA
CREATE FUNCTION UF_DSMonhoc(@TenSV NVARCHAR(100))
RETURNS TABLE RETURN

SELECT MH.TenMon 
FROM dbo.MonHoc AS MH, DangKyHoc AS DKH, dbo.SinhVien AS SV 
WHERE DKH.MaSV = SV.MaSV AND DKH.MaMon = MH.MaMon AND SV.HoTen = @Tensv

SELECT * FROM UF_DSMonhoc(N'Nguyễn Thị Hoài')
--EB
CREATE FUNCTION UF_DSSinhvien(@MonHoc NVARCHAR(100), @HocKy int)
RETURNS TABLE RETURN

SELECT SV.MaSV,SV.HoTen, K.TenKhoa
FROM dbo.MonHoc AS MH, DangKyHoc AS DKH, dbo.SinhVien AS SV , dbo.Khoa AS K
WHERE K.MaKhoa = SV.MaKhoa AND SV.MaSV = DKH.MaSV AND MH.MaMon = DKH.MaMon AND MH.TenMon = @MonHoc AND DKH.HocKy = @HocKy

SELECT * FROM UF_DSSinhvien(N'Đại số tuyến tính',1)
GO
SELECT * FROM MonHoc
SELECT * FROM dbo.SinhVien
SELECT * FROM  dbo.DangKyHoc

-----------------------------------------------------F
SELECT TOP 1 WITH TIES SV.HoTen, COUNT(MH.MaMon)
FROM dbo.SinhVien AS SV, dbo.DangKyHoc AS DKH, KHOA AS K, dbo.MonHoc AS MH
WHERE SV.MaSV = DKH.MaSV AND SV.MaKhoa = K.MaKhoa AND DKH.MaMon = MH.MaMon
GROUP BY SV.HoTen
ORDER BY COUNT(MH.MaMon) DESC
----------------------------------------------------G
SELECT TOP 1 WITH TIES SV.HoTen, COUNT(MH.MaMon)
FROM dbo.SinhVien AS SV, dbo.DangKyHoc AS DKH, KHOA AS K, dbo.MonHoc AS MH
WHERE SV.MaSV = DKH.MaSV AND SV.MaKhoa = K.MaKhoa AND DKH.MaMon = MH.MaMon
GROUP BY SV.HoTen
ORDER BY COUNT(MH.MaMon) ASC
---------------------------------------------------H

CREATE LOGIN Tricua
WITH PASSWORD = '123'
CREATE USER Tricua
FOR LOGIN Tricua

CREATE LOGIN ass
WITH PASSWORD = '111' MUST_CHANGE,
CHECK_EXPIRATION = ON;
CREATE USER ass
FOR LOGIN ass

CREATE LOGIN aaa
WITH PASSWORD = '111' MUST_CHANGE,
CHECK_EXPIRATION = ON;
CREATE USER aaa
FOR LOGIN aaa

GRANT SELECT, INSERT ON dbo.SinhVien TO Tricua



	







