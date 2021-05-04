USE TSTBKhachSan
GO

CREATE PROC USP_SelectNhaCungCap
AS SELECT * FROM dbo.NhaCungCap
GO
EXEC USP_SelectNhaCungCap
