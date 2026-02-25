CREATE DATABASE BottleStory;
GO

USE bottlestory
GO

CREATE TABLE users (
	username varchar(25) primary key,
	passwordHash varchar(100) not null,
	accountType varchar(25) not null
);
GO

INSERT INTO users VALUES ('abcd', '$2a$11$YAz4As1I2MvLqH0RbgHMSuYs7BAE.bJEt4OmpZ.3Lhhl8glICUQeG', 'admin');
GO

INSERT INTO users VALUES ('efgh', '$2a$11$nQrjP2brSUp4.eMvzeLgyuBjQxBY185I2a0.mF45PtFzYvHZMcXcW', 'user');
GO