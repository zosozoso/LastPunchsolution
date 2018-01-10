

CREATE TABLE Company (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(255) NOT NULL,
	Phone varchar(10),
	Street varchar(255),
	Country varchar(255),
	PostCode varchar(10),
	FIC varchar(20)	
); 


