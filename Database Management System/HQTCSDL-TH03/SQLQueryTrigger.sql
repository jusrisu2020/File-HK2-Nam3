CREATE TRIGGER UTGInsertNhanVien
ON dbo.Nhanvien FOR INSERT
AS
BEGIN
	PRINT 'Trigger'
	SELECT * FROM dbo.Nhanvien
END
GO


DROP TRIGGER UTGInsertNhanVien
INSERT INTO dbo.Nhanvien
(
    Manv,
    Hoten,
    Gioitinh,
    Ngaysinh,
    Luong,
    Maphong,
    SDT,
    Ngaybc
)
VALUES
(   'NV5',        -- Manv - char(5)
    N'Nhân viên 2',       -- Hoten - nchar(40)
    'Nam',        -- Gioitinh - char(3)
    '12/03/1999', -- Ngaysinh - datetime
    1200000,         -- Luong - int
    'KDA',        -- Maphong - char(3)
    NULL,        -- SDT - char(10)
    '12/03/2000'  -- Ngaybc - datetime
    )