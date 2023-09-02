using Application.ViewModel.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Web.Controllers;
public class HomeController : BaseController
{
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
