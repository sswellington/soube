using Soube.Application.Business;
using Soube.Domain.Interface.IBusiness;
using Soube.Domain.Interface.IPresenter;
using Soube.Domain.Interface.IRepositories;
using Soube.Infrastructure.Core.Repositories;
using webapi.Presenter;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true);

//builder.Services.AddDbContext<SoubeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#region Dependency Injection
builder.Services.AddScoped<IWeatherForecastPresenter, WeatherForecastPresenter>();
builder.Services.AddScoped<IWeatherForecastBll, WeatherForecastBll>();
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
#endregion Dependency Injection

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
