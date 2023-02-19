sequenceDiagram
    participant Aluno
    participant Simulado
    participant Questão
    participant Ranking

    Aluno ->> Simulado: Realiza simulado
    Simulado ->> Questão: Responde questão
    Simulado ->> Aluno: Retorna resultado
    Aluno ->> Ranking: Visualiza ranking
