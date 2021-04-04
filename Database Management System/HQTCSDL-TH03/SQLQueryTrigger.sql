ALTER TRIGGER UTGTenPhong ON dbo.Phong FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @KTTenPhong NCHAR(40), @Tenphong NCHAR(40)
	SELECT COUNT(Tenphong) FROM Phong WHERE Tenphong = Inserted.@Tenphong
	IF(@KTTenPhong > 0)
		PRINT 'Lỗi'
END
GO

DROP TRIGGER dbo.UTGTenPhong

INSERT INTO dbo.Phong
(
    Maphong,
    Tenphong,
    Diachi,
    Tel
)
VALUES
(   'KCA',  -- Maphong - char(3)
    N'Kinh doanh', -- Tenphong - nchar(40)
    N'sasa', -- Diachi - nchar(50)
    'dsds'   -- Tel - char(10)
    )

	SELECT * FROM dbo.Phong

DELETE FROM dbo.Phong WHERE Maphong = 'kdd' OR Maphong = 'kds'