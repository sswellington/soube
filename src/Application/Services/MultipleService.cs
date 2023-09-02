using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.ViewModel.Question;

namespace Application.Services;

public sealed class MultipleService : IMultipleService
{
	private readonly IQuestionRepository _questionRepository;

	public MultipleService(IQuestionRepository questionRepository)
	{
		_questionRepository = questionRepository;
	}

	public MultipleViewModel GetChemistry()
	{
		var query = _questionRepository.GetAll().FirstOrDefault(q => q.Discipline == "Chemistry");
		return MultipleViewModel.Entity2ViewModel(query!);
	}

	public MultipleViewModel GetPhysical()
	{
		var query = _questionRepository.GetAll().FirstOrDefault(q => q.Discipline == "Physical");
		return MultipleViewModel.Entity2ViewModel(query!);
	}

	public MultipleViewModel GetSoftwareEngineering()
	{
		var query = _questionRepository.GetAll().FirstOrDefault(q => q.Discipline == "Software Engineering");
		return MultipleViewModel.Entity2ViewModel(query!);
	}
}
