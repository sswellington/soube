using Application.Entities;
using Application.Interfaces.Repositories;

namespace Infrastructure.DataAccess.Repositories;

//TODO: implementar
// QuestionEntity GetQuestion(string id)
// IEnumerable<QuestionEntity> GetEntranceExam(string discipline, string organizer)
// IEnumerable<QuestionEntity> GetEntranceExam(string discipline, string organizer)
// IEnumerable<QuestionEntity> GetPublicTender(string discipline, string organizer)

public class QuestionRepository : BaseRepository<QuestionEntity>, IQuestionRepository
{
}
