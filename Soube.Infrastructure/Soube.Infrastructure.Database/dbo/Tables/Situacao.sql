﻿CREATE TABLE [dbo].[Situacao]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Criado] DATETIME NOT NULL DEFAULT GETDATE(),
    [CriadoPor] INT NOT NULL DEFAULT 0, 
    [Atualizado] DATETIME NOT NULL,
    [AtualizadoPor] INT NOT NULL DEFAULT 0,
    [Ativo] BIT NOT NULL DEFAULT 1,
    [AdministradorId] INT NOT NULL FOREIGN KEY REFERENCES PessoaFisica(Id)
)
