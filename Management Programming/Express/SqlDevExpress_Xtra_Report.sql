CREATE DATABASE XtraReport
GO
USE XtraReport
GO
CREATE TABLE Reports
(
	id int identity primary key,
	sanpham nvarchar (250),
	gia int,
	soluong int,
	hoadon int,
	ngaytao	date
)
go

--Add value

Insert into Reports(sanpham,gia,soluong,hoadon,ngaytao) values (N'Bánh Bao', 5000,1,1,'10-2-2021')
Insert into Reports(sanpham,gia,soluong,hoadon,ngaytao) values (N'Bánh Chuối', 3000,1,1,'10-3-2021');
Insert into Reports(sanpham,gia,soluong,hoadon,ngaytao) values (N'Kẹo dừa', 15000,1,1,'10-4-2021');
Insert into Reports(sanpham,gia,soluong,hoadon,ngaytao) values (N'Mức bí', 5000,1,1,'10-5-2021');
Insert into Reports(sanpham,gia,soluong,hoadon,ngaytao) values (N'Mức Thèo Leo', 5000,1,1,'10-6-2021');


SELECT * FROM Reports


