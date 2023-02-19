@startuml

class Questão {
    -id: int
    -enunciado: string
    -gabarito: string
    -nivel: string
    -materia: string
    -imagem: string
}

class Simulado {
    -nome: string
    -data_criacao: date
    -tempo_maximo: int
    -num_questoes: int
    -nota_maxima: int
    -nota_obtida: int
}

class Aluno {
    -nome: string
    -email: string
    -senha: string
    -login: string
    -historico_notas: list
    -perfil_dificuldades: list
    -questoes_favoritas: list
}

class Matéria {
    -nome: string
}

class Ranking {
    -data_atualizacao: date
    -num_posicoes_exibidas: int
    -metodo_ordenacao: string
}

class SimuladoQuestão {
    -simulado_id: int
    -questao_id: int
}

Questão -- Simulado : composição
Simulado *-- Questão : agregação
Simulado *-- Aluno : agregação
Matéria -- Questão : composição
Ranking *-- Aluno : agregação
@enduml