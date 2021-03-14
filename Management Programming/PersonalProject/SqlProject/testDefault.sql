create database testDefault
go

use testDefault
go

create table test1
(
	MaTest nvarchar(100) primary key,
	Name nvarchar(200) default N'Trần Minh Trí'
)

insert into test1 (MaTest,Name) values(N'T1',N'dsds')
insert into test1 (MaTest) values(N'T3')
SELECT * FROM test1