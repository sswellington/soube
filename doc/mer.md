# Modelo Entidade Relacionamento

## Questão

A classe Questão pode ter atributos como o enunciado, o gabarito, o nível de dificuldade, a matéria a que pertence, e possivelmente uma imagem ou figura associada à questão. Pode ter métodos para criar, editar, remover e recuperar questões. Essa classe pode ter um relacionamento de composição com a classe Simulado.

+-------------+---------+
| Atributo    | Tipo    |
|-------------|---------|
| id          | PK      |
| enunciado   | Texto   |
| alternativa | Texto   |
| gabarito    | Texto   |
| nivel       | inteiro |   
| materia     | texto   |
| imagem      | image   |
| simulado_id | FK      |
+-------------+---------+


Nesse modelo, a classe Questão possui uma chave primária id e os atributos enunciado, gabarito, nivel, materia e imagem. Além disso, há uma chave estrangeira simulado_id que faz referência à classe Simulado, indicando uma relação de composição entre elas.

Note que a classe Questão pode ter métodos para criar, editar, remover e recuperar questões, mas esses métodos não estão representados no modelo entidade-relacionamento, pois se tratam de aspectos da implementação da classe e não da sua estrutura.

## Simulado

A classe Simulado pode ter atributos como o nome do simulado, a lista de questões, a data de criação, o tempo máximo permitido para realização do simulado, o número de questões, a nota máxima possível, e a nota obtida pelo aluno. Essa classe pode ter métodos para gerar um simulado a partir de um conjunto de questões, calcular a nota do aluno, e recuperar informações sobre o simulado. Essa classe pode ter um relacionamento de agregação com a classe Questão.

+------------+
|  Simulado  |
+------------+
| id         |
| nome       |
| data_criacao |
| tempo_maximo |
| num_questoes |
| nota_maxima |
| nota_obtida |
+------------+

+-----------------+
| SimuladoQuestão |
+-----------------+
| simulado_id (FK)|
| questao_id (FK) |
+-----------------+

A relação entre Simulado e Questão é uma agregação, modelada por uma tabela de associação chamada SimuladoQuestão, que armazena as chaves estrangeiras das duas classes para relacioná-las. A classe Simulado tem uma lista de questões associadas a ela, representada pelo relacionamento de agregação com a classe Questão.


## Pessoa

| Atributo   | Tipo     | Restição |
|------------|----------|----------|
| id         | integer  | PK       |
| cpf        | string   | PK       |
| nome       | varchar  | not null |
| sobrenome  | varchar  | not null |
| nascimento | datetime | not null |

## Endereço

| Atributo     | Tipo    |
|--------------|---------|
| id           | integer |
| rua          | varchar |
| numero       | varchar |
| complemento  | varchar |
| bairro       | varchar |
| cidade       | varchar |
| estado       | varchar |
| cep          | varchar |

## Contato

| Atributo   | Tipo    |
|------------|---------|
| id         | integer |
| tipo       | varchar |
| valor      | varchar |
| pessoa_id  | integer |

### Relacionamento
Pessoa tem um ou mais endereços (relação 1:N)
Pessoa tem um ou mais contatos (relação 1:N)
Endereço pertence a uma única pessoa (relação N:1)
Contato pertence a uma única pessoa (relação N:1)

## Aluno

A classe Aluno pode ter atributos como o nome, o e-mail, a senha, o login, o histórico de notas, o perfil de dificuldades e as questões favoritas do aluno. Pode ter métodos para cadastrar, editar, remover e recuperar um aluno. Essa classe pode ter um relacionamento de agregação com a classe Simulado.

| Atributo              | Tipo    						|
|-----------------------|-------------------------------|
| id		 			| Inteiro, Chave Primária		|
| nome		 			| Varchar(100), Not Null		|
| email		 			| Varchar(100), Not Null		|
| senha		 			| Varchar(20), Not Null			|
| login		 			| Varchar(20), Not Null			|
| perfil_dificuldades	| Varchar(50)					|
| simulados_realizados	| Lista de Simulados, agregação	|
| historico_notas		| Lista de Notas				|
| questoes_favoritas	| Lista de Questões				|

## Matéria

A classe Matéria pode ter atributos como o nome da matéria e a lista de questões associadas àquela matéria. Pode ter métodos para criar, editar, remover e recuperar matérias. Essa classe pode ter um relacionamento de composição com a classe Questão.

+------------+
|   Matéria  |
+------------+
| id         |
| nome       |
+------------+

+-------------------+
|  Matéria_Questão  |
+-------------------+
| id                |
| materia_id (FK)   |
| questao_id (FK)   |
+-------------------+


## Ranking

A classe Ranking pode ter atributos como a lista de alunos e suas pontuações, a data de atualização, o número de posições exibidas e o método de ordenação. Essa classe pode ter métodos para gerar um ranking a partir das notas dos alunos, atualizar o ranking e recuperar informações sobre ele. Essa classe pode ter um relacionamento de agregação com a classe Aluno.

| Atributo              | Tipo    						|
|-----------------------|-------------------------------|
| alunos_pontuacoes		| Lista de Alunos e Pontuações, Agregação
| data_atualizacao		| Data e Hora, Not Null
| num_posicoes_exibidas	| Inteiro, Not Null
| metodo_ordenacao		| Varchar(50), Not Null