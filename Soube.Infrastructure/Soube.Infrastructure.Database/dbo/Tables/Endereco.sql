CREATE TABLE [dbo].[Endereco]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CEP] VARCHAR(8) NULL, 
    [Nome] VARCHAR(80) NOT NULL,
    [Pais] VARCHAR(50) NOT NULL DEFAULT 'Brasil',
    [UF] CHAR(2) NULL,
    [Cidade] VARCHAR(50) NULL, 
    [Bairro] VARCHAR(30) NULL, 
    [Numero] VARCHAR(10) NULL, 
    [Complemento] VARCHAR(50) NULL, 
    [ZonaUrbana] BIT NULL DEFAULT 1,
)
