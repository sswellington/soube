using Application.Entities;

namespace Infrastructure.Database.MockDatabase.Questions;

public record Chemistry()
{
	public static QuestionEntity Get()
	{
		return new QuestionEntity(discipline: "Chemistry")
		{
			Schooling = 'M',
			Organizer = "FUVEST",
			Area = "Química",
			Subarea = "geral",
			Topic = "básico",
			Keyword = "hidrocarbonetos-propelente",
			EntranceExam = true,
			Address = "https://acervo.fuvest.br/fuvest/2014/fuv2014_1fase_prova_V.pdf",
			NotebookDescription = "Página 10 de 26 V - Questão 32",
			ApplicationDate = new DateOnly(2013,11,24),

			Year = 2014,
			Correct = 'A',
			Statement = "O rótulo de uma lata de desodorante em aerosol apresenta, entre outras, as seguintes informações: “Propelente: gás butano. Mantenha longe do fogo”. A principal razão dessa advertência é:",
			OptionA = "A) O aumento da temperatura faz aumentar a pressão do gás no interior da lata, o que pode causar uma explosão.",
			OptionB = "B) A lata é feita de alumínio, que, pelo aquecimento, pode reagir com o oxigênio do ar.",
			OptionC = "C) O aquecimento provoca o aumento do volume da lata, com a consequente condensação do gás em seu interior.",
			OptionD = "D) O aumento da temperatura provoca a polimerização do gás butano, inutilizando o produto.",
			OptionE = "E) A lata pode se derreter e reagir com as substâncias contidas em seu interior, inutilizando o produto."
		};
	}
}