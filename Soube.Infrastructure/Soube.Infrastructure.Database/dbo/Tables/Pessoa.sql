CREATE TABLE [dbo].[Pessoa]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(50) NULL, 
    [Descricao] VARCHAR(50) NULL, 
    [Telefone] VARCHAR(50) NULL, 
    [Celular] VARCHAR(13) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Credencial] INT NOT NULL DEFAULT 0,
    [EnderecoId] INT NOT NULL FOREIGN KEY REFERENCES Endereco(Id),
    [SituacaoId] INT NOT NULL FOREIGN KEY REFERENCES Situacao(Id),
    [AutenticarId] INT NOT NULL FOREIGN KEY REFERENCES Autenticar(Id)
)
