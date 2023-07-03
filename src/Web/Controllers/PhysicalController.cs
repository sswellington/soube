using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Web.Controllers;

[Route("discipline/phisical")]
public class PhysicalController : Controller
{
	public IActionResult Index()
	{
		Log.Information("Page Visited: Phisical");
		return View();
	}
}
