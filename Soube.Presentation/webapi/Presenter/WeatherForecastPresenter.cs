using Soube.Domain.Interface.IBusiness;
using Soube.Domain.Interface.IPresenter;
using Soube.Domain.Models;

namespace webapi.Presenter;

public class WeatherForecastPresenter : IWeatherForecastPresenter
{
    private readonly IWeatherForecastBll _weatherForecastBll;

    public WeatherForecastPresenter(IWeatherForecastBll weatherForecastBll)
    {
        _weatherForecastBll = weatherForecastBll;
    }

    public async Task<IEnumerable<WeatherForecastModel>> GetAllAsync()
    {
        return await _weatherForecastBll.GetAllAsync();
    }
}
