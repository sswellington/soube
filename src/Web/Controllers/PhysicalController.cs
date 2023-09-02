using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("discipline/physical")]
public class PhysicalController : BaseController
{
	private readonly IMultipleService _multipleService;

	public PhysicalController(IMultipleService multipleService) => _multipleService = multipleService;

	[HttpGet]
	public override ViewResult Index() => View(_multipleService.GetPhysical());
}
