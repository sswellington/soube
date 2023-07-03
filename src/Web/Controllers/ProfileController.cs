using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Web.Controllers;

[Route("profile")]
public class ProfileController : Controller
{
	public IActionResult Index()
	{
		Log.Information("Page Visited: Profile");
		return View();
	}
}
