using Application.Entities;

namespace Infrastructure.Database.MockDatabase.Questions;

public record MockQuestion()
{
	protected static QuestionEntity GetQuestionEntityIsNew()
	{
		return new QuestionEntity();
	}

	public static IEnumerable<QuestionEntity> GetQuestions()
	{
		return new List<QuestionEntity>
		{
			Chemistry.Get(),
			SoftwareEngineering.Get(),
			Physical.Get(),
			GetQuestionEntityIsNew()
		};
	}
}