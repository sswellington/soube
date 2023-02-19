

+----------------------------------+
|           Classe Questão         |
+----------------------------------+
| - id: int                        |
| - enunciado: string              |
| - gabarito: string               |
| - nivel: int                     |
| - materia: Matéria               |
| - imagem: string                 |
| - simulado_id: int (FK)          |
+----------------------------------+
| + criar_questao()                |
| + editar_questao()               |
| + remover_questao()              |
| + recuperar_questao()            |
+----------------------------------+

+----------------------------------+
|           Classe Simulado        |
+----------------------------------+
| - id: int                        |
| - nome: string                   |
| - data_criacao: datetime         |
| - tempo_maximo: int              |
| - num_questoes: int              |
| - nota_maxima: int               |
| - nota_obtida: int               |
| - questoes: list(Questão)        |
+----------------------------------+
| + gerar_simulado()               |
| + calcular_nota()                |
| + recuperar_simulado()           |
+----------------------------------+

+----------------------------------+
|           Classe Aluno           |
+----------------------------------+
| - id: int                        |
| - nome: string                   |
| - email: string                  |
| - senha: string                  |
| - login: string                  |
| - historico_notas: list(Simulado)|
| - perfil_dificuldades: string    |
| - questoes_favoritas: list(Questão)|
+----------------------------------+
| + cadastrar_aluno()              |
| + editar_aluno()                 |
| + remover_aluno()                |
| + recuperar_aluno()              |
+----------------------------------+

+----------------------------------+
|           Classe Matéria         |
+----------------------------------+
| - id: int                        |
| - nome: string                   |
| - questoes: list(Questão)        |
+----------------------------------+
| + criar_materia()                |
| + editar_materia()               |
| + remover_materia()              |
| + recuperar_materia()            |
+----------------------------------+

+----------------------------------+
|           Classe Ranking         |
+----------------------------------+
| - id: int                        |
| - lista_alunos_pontuacoes: list(Aluno)|
| - data_atualizacao: datetime     |
| - num_posicoes_exibidas: int      |
| - metodo_ordenacao: string       |
+----------------------------------+
| + gerar_ranking()                |
| + atualizar_ranking()            |
| + recuperar_ranking()            |
+----------------------------------+

Observações:

    A relação entre Simulado e Questão é uma agregação, modelada por uma tabela de associação chamada SimuladoQuestão, que armazena as chaves estrangeiras das duas classes para relacioná-las. A classe Simulado tem uma lista de questões associadas a ela, representada pelo relacionamento de agregação com a classe Questão.

    A relação entre Pessoa e Endereço e entre Pessoa e Contato é uma relação de composição, modelada pela classe Pessoa tendo uma lista de endereços e contatos associados a ela.

    A classe Ranking tem um relacionamento de agregação com a classe Aluno, representando que a classe Ranking tem uma lista de alunos associados a ela.

    Note que os métodos para criar, editar, remover e recuperar objetos das classes Questão, Simulado, Aluno e Matéria estão representados no diagrama de implementação, diferentemente do modelo entidade