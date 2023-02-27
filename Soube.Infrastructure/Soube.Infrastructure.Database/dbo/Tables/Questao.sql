CREATE TABLE [Questao]
(
	[Id] INT PRIMARY KEY,
	[Enunciado] VARCHAR(800),
	[Alternativa] VARCHAR(200),
	[Gabarito] VARCHAR(40),
	[Comentario] VARCHAR(200),
	[Ano] DATE NOT NULL,
	[SimuladoId] INT FOREIGN KEY REFERENCES Simulado(Id),
	[MateriaId] INT FOREIGN KEY REFERENCES Materia(Id), 
    [BancaId] INT NOT NULL FOREIGN KEY REFERENCES PessoaJuridica(Id),
    [SituacaoId] INT NOT NULL FOREIGN KEY REFERENCES Situacao(Id)
)