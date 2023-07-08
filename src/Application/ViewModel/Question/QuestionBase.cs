namespace Application.ViewModel.Question;
public abstract record QuestionBase
{
	public string Organizer { get; set; } = "Banca";
	public string Statement { get; set; } = "Enunciado";
	public uint Year { get; set; } = 2000;
}
