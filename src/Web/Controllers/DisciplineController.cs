using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Web.Controllers;

[Route("discipline")]
public class DisciplineController : Controller
{
	public IActionResult Index()
	{
		Log.Information("Page Visited: Discipline");
		return View();
	}
}
