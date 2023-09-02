using Application.Entities;

namespace Infrastructure.Database.MockDatabase.Questions;

public record Physical()
{
	public static QuestionEntity Get()
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
			ApplicationDate = new DateOnly(2016, 11, 05),
			Year = 2016,
			Correct = 'C',
			Resolution = "P=Q/Δt = m.c.ΔT/Δt"
			             + "Ao se referir à relação de fluxo de água, o que se deseja é mΔt, logo:"
			             + "m/Δt = P/c.ΔT = 2.10^6/4.10^3.3 = 500/3 = 166,7 kg/s",
			Statement =
				"Durante a primeira fase do projeto de uma usina de geração de energia elétrica, os engenheiros da equipe de avaliação de impactos ambientais procuram saber se esse projeto está de acordo com as normas ambientais. A nova planta estará localizada à beira de um rio, cuja temperatura média da água é de 25ºC, e usará a sua água somente para refrigeração. O projeto pretende que a usina opere com 1,0 MW de potência elétrica e, em razão de restrições técnicas, o dobro dessa potência será dissipada por seu sistema de arrefecimento, na forma de calor. Para atender a resolução número 430, de 13 de maio de 2011, do Conselho Nacional do Meio Ambiente, com uma ampla margem de segurança, os engenheiros determinaram que a água só poderá ser devolvida ao rio com um aumento de temperatura de, no máximo, 3°C em relação à temperatura da água do rio captada pelo sistema de arrefecimento. Considere o calor específico da água igual a 4 kJ/(kg ºC). Para atender essa determinação, o valor mínimo do fluxo de água, em kg/s, para a refrigeração da usina deve ser mais próximo de:",
			OptionA = "A) 42",
			OptionB = "B) 84",
			OptionC = "C) 167",
			OptionD = "D) 250",
			OptionE = "E) 500"
		};
	}
}