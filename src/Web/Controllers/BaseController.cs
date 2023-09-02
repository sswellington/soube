using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
public abstract class BaseController : Controller
{
	[HttpGet]
	public virtual ViewResult Index()
	{
		return View();
	}

	[HttpGet]
	[Route("ping")]
	public ActionResult<string> Ping()
	{
		const string pong = "pong";
		return pong;
	}
}
