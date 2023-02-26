﻿using Soube.Domain.Models;

namespace Soube.Domain.Interface.IRepositories;

public interface IWeatherForecastRepository
{
    /// <summary>
    /// Retorna uma lista de previsões de tempo em um intervalo de cinco dias.
    /// </summary>
    /// <returns>Uma lista de objetos WeatherForecastModel que contém informações de previsão do tempo.</returns>
    Task<IEnumerable<WeatherForecastModel>> GetAllAsync();
}
