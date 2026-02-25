use bottlestory
GO

create table users (
	username varchar(25) primary key,
	passwordHash varchar(100) not null,
	accountType varchar(25) not null
);
GO