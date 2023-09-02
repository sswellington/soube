using Application.Entities;

namespace Infrastructure.Database.MockDatabase.Questions;

public record SoftwareEngineering
{
	public static QuestionEntity Get()
	{
		return new QuestionEntity(discipline: "Software Engineering")
		{
			Schooling = 'U',
			Organizer = "CEBRASPE",
			Area = "Engenharia de Software",
			Subarea = "Ciclo de vida",
			Topic = "modelo cascata",
			Keyword = "ciclo_de_vida-modelo_cascata-waterfall",
			PublicTender = true,
			Address = "https://cdn.cebraspe.org.br/concursos/serpro_21/arquivos/MATRIZ_CARGO_2.PDF",
			NotebookDescription = "Página 4 - Questão 66",
			ApplicationDate = new DateOnly(2021, 06, 06),
			Year = 2021,
			Correct = 'E',
			Resolution = "Os requisitos são definidos na primeira etapa do modelo cascata",
			Statement = "No modelo em cascata, dada a dificuldade natural para estabelecer todos os requisitos na fase inicial do projeto, os requisitos são definidos ao longo de todas as fases, acomodando-se gradualmente as incertezas e eventuais mudanças do projeto."
		};
	}
}