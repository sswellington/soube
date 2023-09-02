using Application.Entities;

namespace Application.Interfaces.Repositories;

public interface IQuestionRepository
{
	IEnumerable<QuestionEntity> GetAll();
}