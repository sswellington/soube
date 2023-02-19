stateDiagram
    [*] --> Inativa
    Inativa --> Ativa : criar/editar questão
    Ativa --> Inativa : remover questão
    Ativa --> Resolvida : questão respondida corretamente
    Ativa --> Errada : questão respondida incorretamente
    Errada --> Ativa : refazer questão
    Resolvida --> Ativa : refazer questão
