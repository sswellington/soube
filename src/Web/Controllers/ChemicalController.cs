using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Web.Controllers;

[Route("discipline/chemical")]
public class ChemicalController : BaseController
{
	private readonly IMultipleService _multipleService;

	public ChemicalController(IMultipleService multipleService) => _multipleService = multipleService;

	[HttpGet]
	public IActionResult Index()
	{
		Log.Information("Page Visited: Chemical");
		var result = _multipleService.GetQuestion();
		return View(result);
	}
}
