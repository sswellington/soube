namespace Application.Entities;

public sealed record QuestionEntity
{
	public readonly string Id;
	public DateTime CreationDate { get; } = DateTime.Now;
	public bool Expired { get; set; } = false;

	#region knowledge area
	public string Discipline { get; set; } = "empty";
	public string Topic { get; set; } = "empty";
	public string Keyword { get; set; } = "empty";
	/** Schooling
	// E = Fundamental
	// H = Médio
	// U = Graduado
	// S = Especialização
	// M = Mestrado
	// D = doutarado
	**/
	public char Schooling { get; set; } = 'E';
	public string Area { get; set; } = "empty";
	public string Subarea { get; set; } = "empty";
	#endregion knowledge area

	#region organizer
	public string Organizer { get; set; } = "empty";
	public string NotebookDescription { get; set; } = "empty";
	public uint Year { get; set; } = 1942;
	public DateOnly ApplicationDate { get; set; } = new DateOnly(1942, 12, 31);
	public string Address { get; set; } = "empty";
	public bool PublicTender { get; set; } = false;
	public bool EntranceExam { get; set; } = false;
	#endregion organizer

	#region statistic
	public uint Incidence { get; set; } = 0;
	public uint Hit { get; set; } = 0;
	public uint Miss { get; set; } = 0;
	#endregion statistic

	#region options
	public char Correct { get; set; } = 'W';
	public string Resolution { get; set; } = "empty";
	public string Statement { get; set; } = "empty";
	public string OptionA { get; set; } = "empty";
	public string OptionB { get; set; } = "empty";
	public string OptionC { get; set; } = "empty";
	public string OptionD { get; set; } = "empty";
	public string OptionE { get; set; } = "empty";
	#endregion options

	public QuestionEntity(string discipline = "empty")
	{
		Discipline = discipline;
		Id = PrimaryKeyGenerator();
	}

	public string PrimaryKeyGenerator()
	{
		return Discipline.ToLower() + "-" + Guid.NewGuid();
	}
}
