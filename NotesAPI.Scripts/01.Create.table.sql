USE [NotasDB]
GO
PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Criação da tabela nm_table.');
IF EXISTS(
    SELECT TOP(1) 1
    FROM sys.all_objects 
    WHERE Object_ID = Object_ID(N'NotasDB'))
BEGIN
	PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Script já executado!');
	RETURN;
END

--INICIO DO SCRIPT
--incluir script nesse trecho


CREATE TABLE [dbo].[BlocoDeNotas] (
          [Id] INT NOT NULL IDENTITY,
          [Titulo] VARCHAR(150) NOT NULL,
          CONSTRAINT [PK_BlocoDeNotas] PRIMARY KEY ([Id])
);
	  
	  
CREATE TABLE [dbo].[BlocoDeNotasItens] (
    [Id] INT NOT NULL IDENTITY,
    [IdBlocoDeNotas] INT NOT NULL,
    [Titulo] VARCHAR(150) NOT NULL,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_BlocoDeNotasItens] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BlocoDeNotasItens_BlocoDeNotas_IdBlocoDeNotas] FOREIGN KEY ([IdBlocoDeNotas]) REFERENCES [dbo].[BlocoDeNotas] ([Id]) ON DELETE NO ACTION
);
	  
	  



--FIM DO SCRIPT

PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Executado com sucesso.');