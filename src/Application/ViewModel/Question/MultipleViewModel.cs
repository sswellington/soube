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
);
