CREATE TABLE [dbo].[PessoaFisica]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CPF] CHAR(11) NOT NULL,
    [RG] VARCHAR(13) NOT NULL,
    [Passaporte] CHAR(8) NOT NULL,
    [Nacionalidade] VARCHAR(50) NOT NULL DEFAULT 'Brasileira', 
    [Naturalidade] VARCHAR(50) NULL,
    [EstadoCivil] VARCHAR(20) NOT NULL DEFAULT 'Solteiro',
    [Sexo] CHAR(1) NOT NULL,
    [Genero] VARCHAR(20) NULL,
    [DataNascimento] DATETIME NULL, 
	[PessoaId] INT NOT NULL FOREIGN KEY REFERENCES Pessoa(Id)
)
