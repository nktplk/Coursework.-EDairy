create table Register(
	IDUser int identity(1,1) not null,
	LoginUser varchar(50) not null,
	PasswordUser varchar(50) not null,
	IsAdmin bit
)

select * from Register

create table MainGrid(
	IDStudent int identity(1,1) not null,
	StudentGroup varchar(50) not null,
	FullName varchar(50) not null,
	Math float not null,
	Eng float not null,
	Inf float not null,
	GPA as ((Math + Eng + Inf) / 3) persisted
)

drop table MainGrid

insert into MainGrid values ('014302', 'Nikita Poloyko', 10, 8, 7)

select * from MainGrid

