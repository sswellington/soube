using Soube.Domain.Interface.IBusiness;
using Soube.Domain.Interface.IRepositories;
using Soube.Domain.Models;

namespace Soube.Application.Business;

public class WeatherForecastBll : IWeatherForecastBll
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;

    public WeatherForecastBll(IWeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }

    public IEnumerable<WeatherForecastModel> Get()
    {
        return _weatherForecastRepository.Get();
    }
}
