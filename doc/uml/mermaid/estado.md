 diagrama de estado compatível com as classes e relacionamentos descritos:


                  +---------------+
                  |     Questão   |
                  +---------------+
                  |   id          |
                  |   enunciado   |
                  |   gabarito    |
                  |   nivel       |
                  |   materia     |
                  |   imagem      |
                  |   simulado_id |----------+
                  +---------------+          |
                        |                   |
                        |                   |
                        |                   |
                        v                   |
                  +---------------+          |
                  |   Simulado    |          |
                  +---------------+          |
                  |   nome        |          |
                  |   data_criacao|          |
                  |   tempo_maximo|          |
                  |   num_questoes|          |
                  |   nota_maxima |          |
                  |   nota_obtida |          |
                  |   questoes[]  |<---------+
                  +---------------+
                        |
                        |
                        |
                        v
                  +---------------+
                  |     Aluno     |
                  +---------------+
                  |   nome        |
                  |   email       |
                  |   senha       |
                  |   login       |
                  |   notas[]     |
                  |   perfil      |
                  |   favoritas[] |
                  |   simulados[] |<------+
                  +---------------+       |
                        |                   |
                        |                   |
                        |                   |
                        v                   |
                  +---------------+          |
                  |     Ranking   |          |
                  +---------------+          |
                  |   alunos[]    |<---------+
                  |   pontuacoes[]|
                  |   data_atual  |
                  |   num_posicoes|
                  |   ordem       |
                  +---------------+
                        |
                        |
                        |
                        v
                  +---------------+
                  |     Matéria   |
                  +---------------+
                  |   nome        |
                  |   questoes[]  |
                  +---------------+


Observe que no diagrama foram representados apenas os atributos principais de cada classe e seus relacionamentos mais importantes. Além disso, foram incluídas algumas cardinalidades para indicar quantas instâncias de uma classe podem estar relacionadas a instâncias de outra classe. No entanto, outras informações e detalhes sobre o sistema podem ser adicionados, dependendo do escopo e das necessidades do projeto.
