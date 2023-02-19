diagrama de componentes que representa as principais classes e seus relacionamentos no sistema de questões e simulados:

        +-------------------+
        |      Aluno        |
        +-------------------+
        | nome              |
        | email             |
        | senha             |
        | login             |
        | historicoNotas    |
        | perfilDificuldade |
        | questoesFavoritas |
        +-------------------+
                 |
        +--------+--------+
        |      Simulado   |
        +----------------+
        | nome           |
        | dataCriacao    |
        | tempoMaximo    |
        | numQuestoes    |
        | notaMaxima     |
        | notaObtida     |
        +----------------+
                 |
        +--------+--------+
        |       Questao    |
        +-----------------+
        | id              |
        | enunciado       |
        | gabarito        |
        | nivel           |
        | materia         |
        | imagem          |
        +-----------------+
                 |
        +--------+--------+
        |      Materia    |
        +----------------+
        | nome           |
        +----------------+
                 |
        +--------+--------+
        |      Ranking    |
        +----------------+
        | listaAlunos    |
        | listaPontuacoes|
        | dataAtualizacao|
        | numPosicoes    |
        | metodoOrdenacao|
        +----------------+


No diagrama, podemos ver que a classe Questão é composta pelos atributos id, enunciado, gabarito, nivel, materia e imagem, e que ela tem um relacionamento de composição com a classe Simulado. A classe Simulado, por sua vez, é composta pelos atributos nome, dataCriacao, tempoMaximo, numQuestoes, notaMaxima e notaObtida, e tem um relacionamento de agregação com a classe Questão. A classe Aluno é composta pelos atributos nome, email, senha, login, historicoNotas, perfilDificuldade e questoesFavoritas, e tem um relacionamento de agregação com a classe Simulado. A classe Matéria é composta pelo atributo nome e tem um relacionamento de composição com a classe Questão. Finalmente, a classe Ranking é composta pelos atributos listaAlunos, listaPontuacoes, dataAtualizacao, numPosicoes e metodoOrdenacao, e tem um relacionamento de agregação com a classe Aluno.