using Soube.Domain.Interface.IPresenter;
using webapi.Presenter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IWeatherForecastPresenter, WeatherForecastPresenter>();

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
