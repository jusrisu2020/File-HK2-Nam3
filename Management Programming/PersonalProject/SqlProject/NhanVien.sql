USE TSTBKhachSan
GO

CREATE PROC USP_SelectNhanVien
AS SELECT * FROM dbo.NhanVien
GO
EXEC dbo.USP_SelectNhanVien