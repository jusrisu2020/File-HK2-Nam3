Create database LinkBoPhan
go

use LinkBoPhan
go

create table TaiKhoan
(
	MaTK nvarchar(100) primary key,	
	MaBP nvarchar(100),
	BoPhan nvarchar (250) not null,
)
go


create table QLNhanVien
(
	MaNV int identity primary key,	
	MaBP nvarchar(100),
	BoPhan nvarchar (250) not null
)
go

create table QLBoPhan
(
	MaBP nvarchar(100) primary key,
	BoPhan nvarchar (250) not null,
)
go

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_TKBP
  FOREIGN KEY (MaBP)
  REFERENCES QLBoPhan (MaBP);

  ALTER TABLE QLNhanVien
ADD CONSTRAINT fk_NVBP
  FOREIGN KEY (MaBP)
  REFERENCES QLBoPhan (MaBP);