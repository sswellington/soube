using Soube.Domain.Models;
using System.Collections.Generic;

namespace Soube.Domain.Interface.IPresenter;

public interface IWeatherForecastPresenter
{
    /// <summary>
    /// Retorna uma lista de previsões de tempo em um intervalo de cinco dias.
    /// </summary>
    /// <returns>Uma lista de objetos WeatherForecastModel que contém informações de previsão do tempo.</returns>
    IEnumerable<WeatherForecastModel> Get();
}
