namespace Application.Aggregates;

public class SchoolingAggregates
{
	Dictionary<char, string> educationalLevels = new Dictionary<char, string>()
	{
		{ 'E', "Fundamental" },
		{ 'H', "Médio" },
		{ 'U', "Graduado" },
		{ 'S', "Especialização" },
		{ 'M', "Mestrado" },
		{ 'D', "Doutorado" }
	};
}