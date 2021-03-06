create database TSTBKhachSan
go

use TSTBKhachSan
go

create table ThietBi(
	MaTB nvarchar (10) PRIMARY KEY,
	TenTB nvarchar (255),
	DonVi nvarchar (30),
	SoLuong int,
	DanhMuc nvarchar (255),
	GiaTri int,
	TGBaoHanh date,
	TinhTrangTB nvarchar (30),
	TinhTrangCPTB nvarchar (30),
	BoPhanCP nvarchar (255),
	DiaDiemCP nvarchar (30),
	NCC nvarchar (255),
	NgayMuaTB date
)
go


SELECT * FROM ThietBi

