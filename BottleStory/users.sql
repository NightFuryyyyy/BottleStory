use bottlestory
GO


INSERT INTO users (username, passwordHash, )
VALUES ('abcd', '$2a$11$YAz4As1I2MvLqH0RbgHMSuYs7BAE.bJEt4OmpZ.3Lhhl8glICUQeG', 'admin');
GO

INSERT INTO users (username, passwordHash, accountType)
VALUES ('efgh', '$2a$11$nQrjP2brSUp4.eMvzeLgyuBjQxBY185I2a0.mF45PtFzYvHZMcXcW', 'user');
GO