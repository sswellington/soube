CREATE TABLE [dbo].[PessoaJuridica]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CNPJ] VARCHAR(14) NULL,
	[Fantasia] VARCHAR(80) NULL,
	[RazaoSocial] VARCHAR(50) NULL,
	[DataInicioAtividade] DATETIME NULL,
	[DescricaoSituacaoCadastral] VARCHAR(20) NULL,
	[Matriz] BIT NULL DEFAULT 1,
	[PessoaId] INT NOT NULL FOREIGN KEY REFERENCES Pessoa(Id)
)