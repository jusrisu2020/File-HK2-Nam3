USE TSTBKhachSan
GO

--PROC Đăng nhập
CREATE PROC USP_DangNhap
	@TenTK NVARCHAR(100),
	@Pass NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE @TenTK = TenTK AND  @Pass = Pass
END
EXEC USP_DangNhap N'ad', N'1'
GO

--PROC Select Tất cả tài khoản
CREATE PROC USP_SelectATaiKhoan
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan
END
GO
EXEC USP_SelectATaiKhoan
GO

