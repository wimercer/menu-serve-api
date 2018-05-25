declare @dbname varchar(max)
set @dbname = 'menu-serve'

use [Master]
go

if exists
	(	
	select 
		* 
	from 
		sys.databases 
	where
		name = [@dbname]
	)

drop database [@dbname]
go

create database [menu-serve] 