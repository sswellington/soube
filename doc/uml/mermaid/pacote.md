+----------------+          +----------------+          +----------------+          +---------------+
|     Questão    |----------|   Simulado     |          |     Aluno      |          |    Matéria    |
+----------------+          +----------------+          +----------------+          +---------------+
| - id           |          | - nome         |          | - nome         |          | - nome        |
| - enunciado    |          | - data_criacao |          | - email        |          | - questões[] |
| - gabarito     |          | - tempo_maximo |          | - senha        |          +---------------+
| - nivel        |          | - num_questoes |          | - login        |
| - materia      |          | - nota_maxima  |          | - notas[]      |
| - imagem       |          | - nota_obtida  |          | - perfil      |
| - simulado_id  |          | +gerarSimulado|          | - questoes_fav|
+----------------+          | +calcularNota  |          +----------------+
                             | +recuperarInfo |
                             +----------------+

+----------------+          +---------------+
|    Ranking     |          |    Endereço   |
+----------------+          +---------------+
| - lista_alunos |          | - rua         |
| - data_atualiz.|          | - numero      |
| - num_posicoes |          | - complemento |
| - ordenacao    |          | - cidade      |
| +gerarRanking  |          | - estado      |
| +atualizarRank.|          | - pais        |
| +recuperarInfo |          +---------------+
+----------------+


Note que a classe Endereço mencionada na relação Pessoa tem um ou mais endereços não está presente no diagrama, pois ela não foi descrita no enunciado da questão. Além disso, as classes possuem apenas os atributos e métodos mencionados no enunciado, portanto podem haver outras informações relevantes que não foram incluídas aqui.