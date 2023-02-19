Note que o diagrama apresenta as classes Questão, Simulado, Aluno, Matéria, Ranking e a classe de associação SimuladoQuestão e RankingAluno. As classes possuem seus respectivos atributos e os relacionamentos entre elas são mostrados por meio das setas. Por exemplo, a classe Simulado possui um relacionamento de agregação com a classe Questão, enquanto a classe Questão possui uma chave estrangeira simulado_id, referenciando a classe Simulado.

Além disso, o diagrama também mostra a relação de agregação entre as classes Aluno e Simulado, onde a classe Aluno pode ter um ou vários simulados. A classe Ranking possui uma agregação com a classe Aluno, onde um ranking é composto por vários alunos. Por fim, a classe Matéria possui uma relação de composição com a classe Questão, onde uma matéria possui uma ou várias questões.


+----------+                        +-------------+
|  Questão |                        |  Simulado    |
+----------+                        +-------------+
| id       |                        | id          |
| enunciado |                        | nome        |
| gabarito  |        1..*  +-------->| data_criacao|
| nivel    |--------->| SimuladoQuestão | tempo_maximo|
| materia  |           | simulado_id | num_questoes|
| imagem   |           | questao_id  | nota_maxima |
+----------+           +-------------+ nota_aluno  |
                                            |
                                            |
                                            |
                                  +---------v----------+
                                  |        Aluno        |
                                  +--------------------+
                                  | id                 |
                                  | nome               |
                                  | email              |
                                  | senha              |
                                  | login              |
                                  | historico_notas    |
                                  | perfil_dificuldades|
                                  | questoes_favoritas |
                                  +--------------------+
                                            |
                                            |
                                            |
                                  +---------v----------+
                                  |       Matéria       |
                                  +--------------------+
                                  | id                 |
                                  | nome               |
                                  +--------------------+
                                            |
                                            |
                                            |
                                  +---------v----------+
                                  |       Ranking       |
                                  +--------------------+
                                  | id                 |
                                  | data_atualizacao   |
                                  | num_posicoes       |
                                  | tipo_ordenacao     |
                                  +--------------------+
                                           |
                                           |
                                           |
                                  +--------v--------+
                                  | RankingAluno    |
                                  +-----------------+
                                  | aluno_id        |
                                  | ranking_id      |
                                  | pontuacao       |
                                  +-----------------+
