CREATE TABLE [dbo].[Aluno]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Score] INT NOT NULL DEFAULT 0,
	[QuestoesRealizadas] INT NOT NULL DEFAULT 0,
	[QuestoesAcertadas] INT NOT NULL DEFAULT 0,
	[PessoaFisicaId] INT NOT NULL FOREIGN KEY REFERENCES PessoaFisica(Id),
)
