using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics;

namespace Web.Controllers;
public class HomeController : Controller
{
	public IActionResult Index()
	{
		Log.Information("Page Visited: Home");
		return View();
	}

	public IActionResult Privacy()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
