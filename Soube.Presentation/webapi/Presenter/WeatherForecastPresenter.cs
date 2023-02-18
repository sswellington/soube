using Soube.Domain.Interface.IPresenter;
using Soube.Domain.Models;

namespace webapi.Presenter;

public class WeatherForecastPresenter : IWeatherForecastPresenter
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecastModel> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
