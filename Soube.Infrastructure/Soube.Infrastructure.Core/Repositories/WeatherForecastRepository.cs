using Microsoft.EntityFrameworkCore;
using Soube.Domain.Interface.IRepositories;
using Soube.Domain.Models;
using Soube.Infrastructure.ADO;

namespace Soube.Infrastructure.Core.Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository
{
    private readonly SoubeContext _context;

    public WeatherForecastRepository(SoubeContext context) => _context = context;

    public async Task<IEnumerable<WeatherForecastModel>> GetAllAsync()
    {
        return await _context.WeatherForecast
            .Select(item => new WeatherForecastModel
            {
                Id = item.Id,
                Date = DateOnly.FromDateTime(item.Date),
                TemperatureC = item.Temperature,
                Summary = item.Summary
            })
            .ToArrayAsync();
    }
}
