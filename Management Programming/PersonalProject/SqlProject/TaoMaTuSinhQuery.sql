CREATE DATABASE TEST1
USE TEST1
GO

USE QLCF


create table Ban
	(
		BanID	smallint	not null	identity(1,1)
		,MaBan	char(7)		not null	primary key
		,MoTa	nvarchar(50)
	)
GO

create proc procThemBan
		@MoTa nvarchar(50)
	as
	begin
		Declare @MaBan char(7)
		DECLARE @Test INT = 0
		Set @MaBan=(select IDENT_CURRENT('Ban'))

		if exists (select * from Ban where BanID=@MaBan) 
			SET @MaBan=@MaBan+1
			SET @MaBan='BA'+REPLICATE('0',2-LEN(@MaBan))+@MaBan
			INSERT into Ban values(@MaBan,@MoTa)
		IF EXISTS (select IDENT_CURRENT('Ban'))
			DBCC CHECKIDENT('Ban', RESEED, 0)
	end
go
	exec procThemBan N'Mô tả 1'
	exec procThemBan N'Mô tả 2'
	exec procThemBan N'Mô tả 3'
	exec procThemBan N'Mô tả 4'
	exec procThemBan N'Mô tả 5'
GO

create proc procThemBan2
		@MoTa nvarchar(50)
	as
	begin
		Declare @MaBan char(7)
		DECLARE @Test INT = 0
		Set @MaBan=(select IDENT_CURRENT('Ban'))

		if exists (select * from Ban where BanID=@MaBan) 
			SET @MaBan=@MaBan+1
			SET @MaBan='BA'+REPLICATE('0',2-LEN(@MaBan))+@MaBan
			INSERT into Ban values(@MaBan,@MoTa)
	end
GO
go
	exec procThemBan2 N'Mô tả 1'
	exec procThemBan2 N'Mô tả 2'
	exec procThemBan2 N'Mô tả 3'
	exec procThemBan2 N'Mô tả 4'
	exec procThemBan2 N'Mô tả 5'
SELECT * FROM dbo.Ban
DBCC CHECKIDENT('Ban', RESEED, 0)
DELETE dbo.Ban WHERE MaBan = 'BA01'

DROP PROC dbo.procThemBan2
DROP TABLE dbo.Ban
