CREATE TABLE GenresBooksListTable (
    ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [GenreName] varchar(255),
    IsActive bit default 1,
);

INSERT INTO GenresBooksListTable ([GenreName])
VALUES ('Technology'),
	   ('Fashion'),
	   ('Architecture'),
	   ('Fashion'),
	   ('Food'),
	   ('Technology'),
	   ('Lifestyle'),
	   ('Art'),
	   ('Adventure')