USE [BlocoDeNotas]
GO
PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Criação da tabela nm_table.');
IF EXISTS(
    SELECT TOP(1) 1
    FROM sys.all_objects 
    WHERE Object_ID = Object_ID(N'BlocoDeNotas'))
BEGIN
	PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Script já executado!');
	RETURN;
END

--INICIO DO SCRIPT
--incluir script nesse trecho


CREATE TABLE BlocoDeNotas
( 
	Id INT primary key,
	Titulo VARCHAR (100) NOT NULL
)



--FIM DO SCRIPT

PRINT(DB_NAME() + ' .. ' + CONVERT(VARCHAR, GETDATE(), 20) + '.-. Executado com sucesso.');