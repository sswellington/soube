namespace Application.Entities;

public sealed record QuestionEntity
{
	public readonly string Id;
	public string Discipline { get; set; } = "empty";

	public char Correct { get; set; } = 'W';
	public string Organizer { get; set; } = "empty";
	public string Statement { get; set; } = "empty";
	public string OptionA { get; set; } = "empty";
	public string OptionB { get; set; } = "empty";
	public string OptionC { get; set; } = "empty";
	public string OptionD { get; set; } = "empty";
	public string OptionE { get; set; } = "empty";
	public uint Year { get; set; } = 1942;

	public QuestionEntity(string discipline = "empty", string organizer = "empty")
	{
		Discipline = discipline;
		Organizer = organizer;
		this.Id = PrimaryKeyGenerator();
	}

	public string PrimaryKeyGenerator()
	{
		return Discipline.ToLower()
			+ "-" + Organizer.ToLower()
			+ "-" + Guid.NewGuid();
	}
}
