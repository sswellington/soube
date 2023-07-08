namespace Application.ViewModel.Question;
public sealed record MultipleViewModel : QuestionBase
{
	public char Correct { get; set; }
	public string A { get; set; }
	public string B { get; set; }
	public string C { get; set; }
	public string D { get; set; }
	public string E { get; set; }
}
