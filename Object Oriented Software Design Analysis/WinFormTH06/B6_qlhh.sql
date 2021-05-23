Use Master
GO
    IF exists(Select name From sys.databases Where name='QLHH' )
    DROP Database QLHH
GO
    Create Database QLHH
GO

USE QLHH;

CREATE TABLE CUA_HANG(
	MaCH int primary key identity(1,1),
	Ten nvarchar(100) not null,
	Dien_thoai varchar(20),
	Dia_chi nvarchar(100)
) 
GO

CREATE TABLE LOAI_HANG(
	MaLH int primary key identity(1,1),
	Ten nvarchar(100) not null
) 
GO

CREATE TABLE MAT_HANG(
	MaMH int primary key identity(1,1),
	Ten nvarchar(100) not null,
	Don_gia int,
	So_luong_ton smallint,
	MaLH int not null foreign key(MaLH) references LOAI_HANG(MaLH)
) 
GO

-- Dữ liệu bảng CUA_HANG
INSERT INTO CUA_HANG(Ten, Dien_thoai, Dia_chi) VALUES(N'Cửa hàng tự chọn TUTI','076-3841190',N'710 Hà Hoàng Hổ');

-- Dữ liệu bảng LOAI_HANG
INSERT INTO LOAI_HANG(Ten) VALUES(N'Hóa mỹ phẩm');
INSERT INTO LOAI_HANG(Ten) VALUES(N'Bánh kẹo');
INSERT INTO LOAI_HANG(Ten) VALUES(N'Nước giải khát');

-- Dữ liệu bảng MAT_HANG
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Dầu gội Pantene ngăn rụng tóc 450ml',79000,17,1);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Kem đánh răng P/S ngừa sâu răng 180g',23000,35,1);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Bánh bông lan cuốn Solite kem hộp 20 cái',40000,23,2);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Bột giặt Omo hương ngàn hoa 800g',30000,30,1);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Snack khoai tây vị muối O’star 28g',7000,50,2);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Nước khoáng Lavie 500ml',3500,108,3);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Nước giải khát CocaCola lon cao 330ml',8000,36,3);
INSERT INTO MAT_HANG(Ten,Don_gia,So_luong_ton,MaLH) VALUES(N'Bánh xốp Richeese Nabati phô mai 58g',5500,25,2);

GO

SELECT * FROM MAT_HANG;