USE TEST1
GO

CREATE TABLE GiangVien(
	Magv NVARCHAR(10),
	Tengv NVARCHAR(100)
)
GO

TRUNCATE TABLE SinhVien

SELECT * FROM SinhVien

INSERT SinhVien(Masv, Tensv)VALUES (N'SV1',N'Trần Minh Trí')

INSERT SinhVien(Masv, Tensv)VALUES (N'DTH185413',N'Trần Minh Trí')

INSERT SinhVien(Masv, Tensv)VALUES (N'DTH185413',N'Trần Minh Trí')

INSERT SinhVien(Masv, Tensv)VALUES (N'DTH185413',N'Trần Minh Trí')

UPDATE SinhVien SET Masv = N'SS'
DELETE SinhVien WHERE Tensv = N''

DROP TABLE GiangVien


