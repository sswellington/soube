using Application.ViewModel.Question;

namespace Application.Interfaces.Services;
public interface IMultipleService
{
	MultipleViewModel GetChemistry();
	MultipleViewModel GetPhysical();
	MultipleViewModel GetSoftwareEngineering();
}
