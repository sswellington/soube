using Application.Entities;
using Infrastructure.Database.MockDatabase.Questions;

namespace Infrastructure.Database;

public sealed record MockDb
{
	public static IEnumerable<QuestionEntity> GetQuestions()
	{
		return MockQuestion.GetQuestions();
	}
}
