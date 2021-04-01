CREATE DATABASE qlnv2
ON 
  PRIMARY   ( NAME = qlnv_dat, 
	FILENAME = 'D:\qlnvdat.mdf', 
        SIZE = 10, 
        MAXSIZE = 50,  
        FILEGROWTH = 5 ) 
 LOG ON 
	( NAME = qlnv_log,
         FILENAME = 'D:\qlnvlog.ldf', 
         SIZE = 2MB, 
         MAXSIZE = 10MB, 
         FILEGROWTH = 1MB ) 
 GO 

use qlnv2;

create table phong 
(
	maphong char(3) PRIMARY KEY,
	Tenphong nvarchar(40) NOT NULL,
	Diachi nchar (50),
	tel char(10)
)

create table DMNN 
(
	Mann char(2) PRIMARY KEY,
	Tennn char (10)
)

create table nhanvien 
(
	Manv char(5) PRIMARY KEY,
	Hoten nchar (40),
	Gioitinh char(3),
	Ngaysinh datetime,
	Luong Int,
	Maphong char(3) FOREIGN KEY REFERENCES phong(maphong),
	SDT char (10), 
	NgayBC datetime
)

create table TDNN 
(
	Manv char(5) FOREIGN KEY REFERENCES nhanvien(Manv),
	Mann char (2) FOREIGN KEY REFERENCES DMNN(Mann),
	TDo char(1)
)

alter table phong
alter column tenphong nchar(40)


Insert into phong (maphong, tenphong, diachi, Tel)
values
('HCA', N'Hành chính tổng hợp', N'123, Láng Hạ, Đống Đa Hà Nội', 048585793)

Insert into phong 
values
('KDA', N'Kinh doanh', N'123, Láng Hạ, Đống Đa Hà Nội', 048574943)

Insert into phong 
values
('KTA', N'Kỹ thuật', N'123, Láng Hạ, Đống Đa Hà Nội', 048574944)

Insert into phong 
values
('QTA', N'Quản trị', N'123, Láng Hạ, Đống Đa Hà Nội', 048574945)

select * from phong

insert into DMNN
values (01, 'Anh')

insert into DMNN
values (02, 'Nga')

insert into DMNN
values (03, 'Phap')

insert into DMNN
values (04, 'Nhat')

insert into DMNN
values (05, 'Trung Quoc')

insert into DMNN
values (06, 'Han Quoc')

insert into nhanvien
values
('HC001', N'Nguyễn Thị Hà','Nu',	8/27/1950,	2500000,'HCA', NULL, 	2/8/1975)

select * from nhanvien

update nhanvien
set ngaysinh='1950-8-27'
where manv='HC001'

update nhanvien
set ngaybc='2-8-1975'
where manv='HC001'

update nhanvien
set ngaybc='8-2-1975'
where manv='HC001'

insert into nhanvien
values
('HC002',	N'Trần Văn Nam',	'Nam',	'6/12/1975',	3000000,	'HCA',	NULL, 	'6/8/1997')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('HC003',	N'Nguyễn Thanh Huyền',	'Nu',	'7/3/1978',	1500000,	'HCA',	 	'9/24/1999')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KD001',	N'Lê Tuyết Anh',	'Nu',	'2/3/1977',	2500000,	'KDA',	 	'10/2/2001')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KD002',	N'Nguyễn Anh Tú',	'Nam',	'7/4/1942',	2600000,	'KDA',	 	'9/24/1999')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KD003',	N'Phạm An Thái',	'Nam',	'5/9/1977',	1600000,	'KDA',	 	'9/24/1999')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KD004',	N'Lê Văn Hải',	'Nam',	'1/2/1976',	2700000,	'KDA',	 	'6/8/1997')

select * from nhanvien 

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KD005',	N'Nguyễn Phương Minh',	'Nam',	'1/2/1980',	2000000,	'KDA',	 	'10/2/2001')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT001',	'Trần Đình Khâm',	'Nam',	'12/2/1981',	2700000,	'KTA',	 	'1/1/2005')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT002',	N'Nguyễn Mạnh Hùng',	'Nam',	'8/16/1980',	2300000,	'KTA'	 ,	'1/1/2005')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT003',	N'Phạm Thanh Sơn',	'Nam',	'8/20/1984',	2000000,	'KTA'	 ,	'1/1/2005')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT004',	N'Vũ Thị Hoài',	'Nu',	'12/5/1980',	2500000,	'KTA',	 	'10/2/2001')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT005',	N'Nguyễn Thu Lan',	'Nu',	'10/5/1977',	3000000,	'KTA',	 	'10/2/2001')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT006',	N'Trần Hoài Nam',	'Nam',	'7/2/1978',	2800000,	'KTA',	 	'6/8/1997')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT007',	N'Hoàng Nam Sơn',	'Nam',	'12/3/1940',	3000000,	'KTA',	 	'7/2/1965')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT008',	N'Lê Thu Trang',	'Nu',	'7/6/1950',	2500000,	'KTA'	, 	'8/2/1968')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT009',	N'Khúc Nam Hải',	'Nam',	'7/22/1980',	2000000,	'KTA',	 	'1/1/2005')

insert into nhanvien (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
values
('KT010',	N'Phùng Trung Dũng',	'Nam',	'8/28/1978',	2200000,	'KTA'	, 	'9/24/1999')

select * from nhanvien

insert into TDNN
values 
('HC001',	1,	'A')

select * from DMNN

insert into TDNN
values 
('HC001',	02,	'B')

insert into TDNN
values 
('HC002',	01,	'C')

insert into TDNN
values 
('HC002',	03,	'C')
insert into TDNN
values 
('HC003',	01,	'D')

insert into TDNN
values 
('KD001',	01,	'C')
insert into TDNN
values 
('KD001',	02,	'B')

insert into TDNN
values 
('KD002',	01,	'D')
insert into TDNN
values 
('KD002',	2,	'A')

insert into TDNN
values 
('KD003',	01,	'B')

insert into TDNN
values 
('KD003',	02,	'C')

insert into TDNN
values 
('KD004',	01,	'C')

insert into TDNN
values 
('KD004',	04,	'A')


insert into TDNN
values 
('KD004',	05,	'A')

insert into TDNN
values 
('KD005',	01,	'B')

insert into TDNN
values 
('KD005',	02,	'D')

insert into TDNN
values 
('KD005',	03,	'B')

insert into TDNN
values 
('KD005',	04,	'B')

insert into TDNN
values 
('KT001',	01,	'D')

insert into TDNN
values 
('KT001',	04	,'E')

insert into TDNN
values 
('KT002',	01,	'C')

insert into TDNN
values 
('KT002',	02,	'B')

insert into TDNN
values 
('KT003',	01,	'D')

insert into TDNN
values 
('KT003',	03,	'C')

insert into TDNN
values 
('KT004',	01,	'D')

insert into TDNN
values 
('KT005',	01,	'C')


select * from nhanvien
go

--Phần I
--Câu 1 Tạo VIEW NVTRE tuổi nhân viên < 35 tuổi --> KQ: Null
	CREATE VIEW NVTre AS
	SELECT Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc, YEAR(GETDATE()) - YEAR(Ngaysinh) AS Tuoi
	FROM nhanvien 
	WHERE YEAR(GETDATE()) - YEAR(Ngaysinh) < 35
	GO

--DROP VIEW 
	DROP VIEW NVTre

-->Đưa ra danh sách nhân viên có độ tuổi 25 - 30 --> KQ: Null
	SELECT * FROM NVTre WHERE Tuoi >= 25 AND Tuoi <= 30
	GO

-->Sử dụng Insert, Update, Delete
INSERT INTO NVTre (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
VALUES('DH192',	N'Trần Minh Trí', 'Nam','12/2/2000',2700000,'KTA','1/1/2005')

UPDATE NVTre SET Hoten = N'Nguyễn Minh LoanS' WHERE Manv = 'HC001';

DELETE NVTre WHERE Manv = 'DH192'

SELECT * FROM NVTre

--> Xóa view NV_TRE sau đó tạo lại view này với mệnh đề With check option và thực hiện các câu lệnh Insert, Update, Delete trên view này.
	CREATE VIEW NVTre AS
	SELECT Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc, YEAR(GETDATE()) - YEAR(Ngaysinh) AS Tuoi
	FROM nhanvien 
	WHERE YEAR(GETDATE()) - YEAR(Ngaysinh) < 35
	WITH CHECK OPTION;
	GO

	INSERT INTO NVTre (Manv, Hoten, Gioitinh, ngaysinh, luong, maphong, ngaybc)
	VALUES('DH193',	N'Trần Minh Hùng', 'Nam','12/2/2000',2700000,'KTA','1/1/2005')

	UPDATE NVTre SET Hoten = N'Trần Minh Long' WHERE Manv = 'DH193';

	DELETE NVTre WHERE Manv = 'DH192'

	SELECT * FROM NVTre

---Câu 2: Đưa ra danh sách các nhân viên có trình độ tiếng Anh từ loại C trở lên.
CREATE TABLE DSTA
(
	Manv nvarchar(100) PRIMARY KEY,
	Hoten nvarchar(40),
	Ngaysinh datetime,
	Gioitinh nvarchar(3),
	TenPhong nvarchar(100),
	TrinhDo nvarchar(100)
)
GO

DROP TABLE DSTA
DROP VIEW DSTAsVIEW

CREATE VIEW DSTAsVIEW AS
SELECT * FROM DSTA
WITH CHECK OPTION
GO

SELECT * FROM DSTAsVIEW
GO

INSERT INTO DSTAsVIEW(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV1',	N'Nhân viên 1', '11-3-1985' ,'Nam',	'KD',	'A')
INSERT INTO DSTAsVIEW(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV2',	N'Nhân viên 2', '11-3-1975' ,	N'Nữ',	'KT',	'B')
INSERT INTO DSTAsVIEW(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV3',	N'Nhân viên 3', '11-3-1965' ,'Nam',	'LC',	'C')
INSERT INTO DSTAsVIEW(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV4',	N'Nhân viên 4', '11-3-1955' ,'Nam',	'KD',	'A')
INSERT INTO DSTAsVIEW(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV5',	N'Nhân viên 5', '11-3-1999' ,	N'Nữ',	'KD',	'D')
INSERT INTO DSTAsVIEW(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV6',	N'Nhân viên 6', '11-3-1999' ,	N'Nữ',	'KD',	'NULL')

SELECT Manv, Hoten, TrinhDo FROM DSTAsVIEW WHERE TrinhDo >= 'C'
ORDER BY TrinhDo

---	Đưa ra danh sách các nhân viên có trình độ tiếng Anh từ loại C trở lên.
CREATE VIEW TAKD AS
SELECT * FROM DSTA
WITH CHECK OPTION
GO
INSERT INTO TAKD(Manv , Hoten, Ngaysinh, Gioitinh, TenPhong, TrinhDo)
VALUES(N'NV7',	N'Nhân viên 7', '11-3-2000' ,	N'Nam',	'KD',	'NULL')

DELETE TAKD WHERE Manv = N'NV7'

UPDATE TAKD SET Hoten = N'Nhân Viên 8' WHERE Manv = 'NV6'
SELECT * FROM TAKD WHERE TrinhDo <> '0' AND TenPhong = 'KD'



--Phần 2: 
CREATE PROC SPNHANVIEN
(
	@manv char(5),
	@hoten nchar (40),
	@gioitinh char(3),
	@ngaysinh datetime,
	@luong Int,
	@maphong char(3),
	@sdt char (10), 
	@ngaybc datetime
)	
AS
BEGIN
	
EXEC SPNHANVIEN


DROP PROCEDURE SPNHANVIEN


CREATE FUNCTION fuNhanvien
( @Manv char(3) )

RETURNS VARCHAR(50)

AS
BEGIN
DECLARE @nhanvien_name VARCHAR(50);

IF @nhanvien_id < 10
SET @nhanvien_name = 'Smith';
ELSE
SET @nhanvien_name = 'Lawrence';

RETURN @nhanvien_name;

END;
BEGIN TRANSACTION;
ROLLBACK;




