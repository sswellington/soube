using Application.Entities;

namespace Application.ViewModel.Question;

public sealed record MultipleViewModel
(
	char Correct,
	string Organizer,
	string Statement,
	string OptionA,
	string OptionB,
	string OptionC,
	string OptionD,
	string OptionE,
	uint Year
)
{
	public static MultipleViewModel Entity2ViewModel(QuestionEntity entity)
	{
		return new MultipleViewModel
		(
			Year: entity.Year,
			Organizer: entity.Organizer,
			Statement: entity.Statement,
			Correct: entity!.Correct,
			OptionA: entity.OptionA,
			OptionB: entity.OptionB,
			OptionC: entity.OptionC,
			OptionD: entity.OptionD,
			OptionE: entity.OptionA
		);
	}
}
