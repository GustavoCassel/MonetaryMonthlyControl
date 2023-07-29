--INSERT INTO MyDatabase.dbo.Categories
--VALUES
--( DEFAULT, 'Gastos com o Gol', DEFAULT, null, 'Carro' );

--SELECT *
--FROM MyDatabase.dbo.Categories;

--CREATE DATABASE IF NOT EXISTS
--DROP DATABASE IF EXISTS [@Database]
/*
USE [MonetaryControl]

IF NOT EXISTS
    (
        SELECT TABLE_NAME
        FROM @Database.INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_NAME = '@TableName'
    )
    BEGIN
    CREATE TABLE [@TableName]
    (
        [Id] INT NOT NULL IDENTITY(1,1),
        [Description] VARCHAR(128) NOT NULL,
        [Amount] DECIMAL(9,2) NOT NULL,
        PRIMARY KEY (Id)
    )
    END;

    IF NOT EXISTS
    (
        SELECT name
        FROM sys.databases
        WHERE name = '{Resources.DatabaseName}'
    )
    CREATE DATABASE {Resources.DatabaseName}
    ON PRIMARY
    (
        NAME = {Resources.DatabaseName},
        FILENAME = '{AttachDBPath}\{Resources.DatabaseName}.mdf'
    )
    LOG ON
    (
        NAME = {Resources.DatabaseName}_log,
        FILENAME = '{AttachDBPath}\{Resources.DatabaseName}_log.ldf'
    );
*/