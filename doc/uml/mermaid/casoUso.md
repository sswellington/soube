Possível identificar as funcionalidades que podem ser realizadas em cada uma das classes, bem como as relações entre elas. Por exemplo, a classe Simulado tem um relacionamento de agregação com a classe Questão, o que significa que um simulado é composto por uma ou mais questões. Já a classe Aluno tem um relacionamento de agregação com a classe Simulado, o que significa que um aluno pode ter um ou mais simulados associados a ele.


                                      +---------------+
                                      |   Gerenciar   |
                                      |    Questão    |
                                      +---------------+
                                      |  Criar Questão|
                                      |  Editar Questão|
                                      |  Remover Questão|
                                      |  Buscar Questão|
                                      +---------------+
                                             |
                                             |
+---------------+          +---------------+|     +---------------+
|  Gerenciar    |          |  Gerenciar    ||     |   Gerenciar   |
|   Simulado    |--------->|   Questão     |+---->|    Aluno      |
+---------------+          +---------------+|     +---------------+
|  Gerar Simulado|          |  Associar     ||     |  Criar Aluno  |
|  Calcular Nota |          |   Questão     ||     |  Editar Aluno |
|  Buscar Simulado|         |  ao Simulado  ||     |  Remover Aluno|
|  Remover Simulado|        +---------------+|     |  Buscar Aluno |
|  Buscar Questões|                          |     +---------------+
+---------------+                            |
                                             |
                                             |
                                      +---------------+
                                      |   Gerenciar   |
                                      |    Matéria    |
                                      +---------------+
                                      |  Criar Matéria|
                                      |  Editar Matéria|
                                      |  Remover Matéria|
                                      |  Buscar Matéria|
                                      +---------------+
                                             |
                                             |
                                      +---------------+
                                      |   Gerenciar   |
                                      |    Ranking    |
                                      +---------------+
                                      |  Gerar Ranking|
                                      |  Atualizar Ranking|
                                      |  Buscar Ranking|
                                      +---------------+
                                             |
                                             |
                                      +---------------+
                                      |   Autenticar  |
                                      |    Usuário    |
                                      +---------------+
                                      |   Fazer Login |
                                      |  Fazer Logout |
                                      +---------------+

---

graph TD
A[Aluno] -->|faz simulado| B(Simulado)
B -->|contém| C(Questão)
D[Matéria] -->|tem| C
E[Ranking] -->|mostra pontuações| A
E -->|mostra ranking| F(Professor)
