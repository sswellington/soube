CREATE TABLE [Materia]
(
    [Id] INT PRIMARY KEY,
    [Nome] VARCHAR(40),
    [ImagemURL] VARCHAR(800),
    [Escolaridade] INT,
    [Nivel] INT,
    [SituacaoId] INT NOT NULL FOREIGN KEY REFERENCES Situacao(Id)
)
