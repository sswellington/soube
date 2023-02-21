using Soube.Domain.Models;

namespace Soube.Domain.Interface.IBusiness;

public interface IWeatherForecastBll
{
    /// <summary>
    /// Retorna uma lista de previsões de tempo em um intervalo de cinco dias.
    /// </summary>
    /// <returns>Uma lista de objetos WeatherForecastModel que contém informações de previsão do tempo.</returns>
    IEnumerable<WeatherForecastModel> Get();
}
