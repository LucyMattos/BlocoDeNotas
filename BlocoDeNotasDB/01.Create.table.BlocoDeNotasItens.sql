USE [BlocoDeNotas]
GO
PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Criação da tabela nm_table.');
IF EXISTS(
    SELECT TOP(1) 1
    FROM sys.all_objects 
    WHERE Object_ID = Object_ID(N'BlocoDeNotasItens'))
BEGIN
	PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Script já executado!');
	RETURN;
END

--INICIO DO SCRIPT
--incluir script nesse trecho


CREATE TABLE BlocoDeNotasItens
( 
	Id INT primary key identity,
	IdBlocoDeNotas INT NOT NULL,
	Titulo VARCHAR (100) NOT NULL,
	Descricao VARCHAR (600) NOT NULL
)



--FIM DO SCRIPT

PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Executado com sucesso.');