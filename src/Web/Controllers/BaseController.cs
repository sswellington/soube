using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
public abstract class BaseController : Controller
{
	[HttpGet]
	[Route("ping")]
	public ActionResult<string> Ping()
	{
		const string pong = "pong";
		return pong;
	}
}
