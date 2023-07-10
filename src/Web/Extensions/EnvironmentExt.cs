using Serilog;

namespace Web.Extensions;

public static partial class Extensions
{
	public static void Environment(WebApplication app)
	{
		var loggerConfiguration = new LoggerConfiguration()
			.Enrich.WithProperty("Version", "1.0.0")
			.WriteTo.Console();

		if (app.Environment.IsDevelopment())
		{
			loggerConfiguration.MinimumLevel.Verbose();
			Log.Logger = loggerConfiguration.CreateLogger();
			Log.Information("building the application in Development");
		}
		if (app.Environment.IsStaging())
		{
			loggerConfiguration.MinimumLevel.Verbose();
			Log.Logger = loggerConfiguration.CreateLogger();
			Log.Information("building the application in Staging");
			app.UseExceptionHandler("/Home/Error");
			app.UseHsts();

		}
		if (app.Environment.IsProduction())
		{
			loggerConfiguration.MinimumLevel.Information();
			Log.Logger = loggerConfiguration.CreateLogger();
			Log.Information("building the Production");
			app.UseExceptionHandler("/Home/Error");
			app.UseHsts();
		}
	}
}