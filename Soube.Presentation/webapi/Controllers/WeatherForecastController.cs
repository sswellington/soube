using Microsoft.AspNetCore.Mvc;
using Soube.Domain.Interface.IPresenter;
using Soube.Domain.Models;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastPresenter _weatherForecastPresenter;

    public WeatherForecastController(IWeatherForecastPresenter weatherForecastPresenter)
    {
        _weatherForecastPresenter = weatherForecastPresenter;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecastModel> Get()
    {
        return _weatherForecastPresenter.Get();
    }
}
