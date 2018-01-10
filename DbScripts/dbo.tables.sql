CREATE TABLE [dbo].[Company]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Phone] NCHAR(10) NULL, 
    [Street] NVARCHAR(150) NULL, 
    [Country] VARBINARY(50) NULL, 
    [PostCode] NCHAR(10) NULL, 
    [CIF] NCHAR(10) NULL, 
    [Order] INT FOREIGN KEY
)
