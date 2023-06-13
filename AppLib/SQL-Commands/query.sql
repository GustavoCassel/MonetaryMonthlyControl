DECLARE @categoria UNIQUEIDENTIFIER,
		@nomeCategoria VARCHAR(50);

SET	@nomeCategoria = 'Bebida';

SELECT @categoria = Id
FROM Categories
WHERE Name = @nomeCategoria;

PRINT @categoria;


INSERT INTO Entries
(Id, Category, Description, Amount, Created)
VALUES
(DEFAULT, @categoria, 'descrição teste', 5684.25, DEFAULT);


INSERT INTO Categories
(Id, Name, Description, Created)
VALUES
(DEFAULT, 'Bebida', 'Bebida do fim de semana', DEFAULT);


SELECT * 
FROM Categories;


CREATE TABLE Categories
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [Name] NVARCHAR(128) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[Created] DATETIME NOT NULL DEFAULT DESCRIPTION(),
	[Modified] DATETIME NULL
);


CREATE TABLE Entries
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Category] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Categories(Id),
	[Description] NVARCHAR(MAX) NULL,
	[Amount] DECIMAL(6, 2) NOT NULL,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Modified] DATETIME NULL
);