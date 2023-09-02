using Application.Interfaces.Services;
using Application.ViewModel.Question;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("discipline/chemistry")]
public class ChemistryController : BaseController
{
	private readonly IMultipleService _multipleService;

	public ChemistryController(IMultipleService multipleService) => _multipleService = multipleService;

	[HttpGet]
	public override ViewResult Index() => View(_multipleService.GetChemistry());
}
