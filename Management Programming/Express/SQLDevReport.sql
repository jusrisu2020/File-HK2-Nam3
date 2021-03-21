CREATE DATABASE ReportDoanhSo
GO

USE ReportDoanhSo
GO

CREATE TABLE DoanhSo
(
	MaHD NVARCHAR(100),
	MaSP NVARCHAR(100),
	SanPham NVARCHAR(100),
	GiaVon INT,
	GiaBan INT,
	LoiNhuan INT
)
GO

INSERT DoanhSo(MaHD, MaSP, SanPham, GiaVon, GiaBan, LoiNhuan) VALUES (N'HD1', N'SP1', N'Dell', 1200, 1500, NULL)
INSERT DoanhSo(MaHD, MaSP, SanPham, GiaVon, GiaBan, LoiNhuan) VALUES (N'HD2', N'SP2', N'Asus', 1000, 1400, NULL)
INSERT DoanhSo(MaHD, MaSP, SanPham, GiaVon, GiaBan, LoiNhuan) VALUES (N'HD3', N'SP3', N'HP', 1100, 1400, NULL)
INSERT DoanhSo(MaHD, MaSP, SanPham, GiaVon, GiaBan, LoiNhuan) VALUES (N'HD4', N'SP4', N'Acer', 1200, 1500, NULL)

SELECT * FROM DoanhSo