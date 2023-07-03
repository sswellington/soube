using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Web.Controllers;

[Route("discipline/biology")]
public class BiologyController : BaseController
{
	public IActionResult Index()
	{
		Log.Information("Page Visited: Biology");
		return View();
	}
}
