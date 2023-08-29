using Application.Entities;

namespace Infrastructure.Database;

public sealed record FakeDatabase
{
	public static QuestionEntity GetQuestionEntityIsNew()
	{
		return new QuestionEntity();
	}

	public static IEnumerable<QuestionEntity> GetQuestions()
	{
		List<QuestionEntity> data = new()
		{
			GetQuestionAboutChemistry(),
			GetQuestionAboutSoftwareEngineering(),
			GetQuestionAboutPhysical()
		};
		return data;
	}

	public static QuestionEntity GetQuestionAboutSoftwareEngineering()
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

	public static QuestionEntity GetQuestionAboutChemistry()
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

	public static QuestionEntity GetQuestionAboutPhysical()
	{
		return new QuestionEntity(discipline: "Physical")
		{
			Schooling = 'M',
			Area = "Física",
			Organizer = "ENEM",
			Subarea = "termodinâmica",
			Topic = "efeito joule",
			Keyword = "efeitojoule-calorimetria-termodinamica",
			EntranceExam = true,
			Address = "https://download.inep.gov.br/educacao_basica/enem/provas/2016/2016_PV_impresso_D1_CD1.pdf",
			NotebookDescription = "Questão 54 da prova azul do primeiro dia do ENEM 2016",
			ApplicationDate = new DateOnly(2016,11,05),

			Year = 2016,
			Correct = 'C',
			Resolution = "P=Q/Δt = m.c.ΔT/Δt"
			             + "Ao se referir à relação de fluxo de água, o que se deseja é mΔt, logo:"
			             + "m/Δt = P/c.ΔT = 2.10^6/4.10^3.3 = 500/3 = 166,7 kg/s",
			Statement = "Durante a primeira fase do projeto de uma usina de geração de energia elétrica, os engenheiros da equipe de avaliação de impactos ambientais procuram saber se esse projeto está de acordo com as normas ambientais. A nova planta estará localizada à beira de um rio, cuja temperatura média da água é de 25ºC, e usará a sua água somente para refrigeração. O projeto pretende que a usina opere com 1,0 MW de potência elétrica e, em razão de restrições técnicas, o dobro dessa potência será dissipada por seu sistema de arrefecimento, na forma de calor. Para atender a resolução número 430, de 13 de maio de 2011, do Conselho Nacional do Meio Ambiente, com uma ampla margem de segurança, os engenheiros determinaram que a água só poderá ser devolvida ao rio com um aumento de temperatura de, no máximo, 3°C em relação à temperatura da água do rio captada pelo sistema de arrefecimento. Considere o calor específico da água igual a 4 kJ/(kg ºC). Para atender essa determinação, o valor mínimo do fluxo de água, em kg/s, para a refrigeração da usina deve ser mais próximo de:",
			OptionA = "A) 42",
			OptionB = "B) 84",
			OptionC = "C) 167",
			OptionD = "D) 250",
			OptionE = "E) 500"
		};
	}
}
