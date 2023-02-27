CREATE TABLE [SimuladoQuestao]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [SimuladoId] INT FOREIGN KEY REFERENCES [Simulado]([Id]),
    [QuestaoId] INT FOREIGN KEY REFERENCES [Questao]([Id]), 
    [AlunoId] INT FOREIGN KEY REFERENCES [Aluno]([Id])
)
