USE TEST1
GO

CREATE TABLE KhachHang
(
	makh NVARCHAR(100) PRIMARY KEY,
	tenkh NVARCHAR(100),
	taikhoan int
)
GO

DROP TABLE dbo.KhachHang


SELECT * FROM dbo.KhachHang
GO

CREATE PROC USP_InsertKH
	@makh nvarchar(100),
	@tenkh nvarchar(100),
	@taikhoan int
AS
BEGIN
	INSERT INTO dbo.KhachHang(makh,tenkh,taikhoan)
	VALUES
	(@makh, @tenkh, @taikhoan)

	IF (SELECT COUNT(makh) FROM dbo.KhachHang)
		SET @makh = N'KH'
		
END
GO

EXEC USP_InsertKH N'KH001', N'Khách hàng 1', 1000

SELECT * FROM dbo.KhachHang

CREATE TABLE Nhanvien
(
	manv INT,
	tennv NVARCHAR(100),
	luong int
)

create table Ban
	(
		BanID	smallint	not null	identity(1,1)
		,MaBan	char(7)		not null	primary key
		,MoTa	nvarchar(50)	not null	unique
	)
GO
create proc procThemBan
		@MoTa nvarchar(50)
	as
	begin
		Declare @BanMa char(7)
		Set @BanMa=(select IDENT_CURRENT('Ban'))
		if exists (select * from Ban where BanID=@BanMa) Set @BanMa=@BanMa+1
		Set @BanMa='BA'+REPLICATE('0',5-LEN(@BanMa))+@BanMa
		insert into Ban values(@BanMa,@MoTa)
	end
go
	exec procThemBan N'Mô tả 1'
	exec procThemBan N'Mô tả 2'
	exec procThemBan N'Mô tả 3'
	exec procThemBan N'Mô tả 4'
	exec procThemBan N'Mô tả 5'
GO

SELECT * FROM dbo.Ban
DROP TABLE dbo.Nhanvien
INSERT INTO dbo.Nhanvien
(
    tennv,
    luong
)
VALUES
(   N'Nhan vien 2', -- tennv - nvarchar(100)
    1000  -- luong - int
    )

	SELECT * FROM dbo.Nhanvien

	DELETE dbo.Nhanvien WHERE manv = 1