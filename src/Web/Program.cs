using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var loggerConfiguration = new LoggerConfiguration()
	.Enrich.WithProperty("Version", "1.0.0")
	.WriteTo.Console();

var app = builder.Build();

#region Environment
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
#endregion Environment

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

Log.Information("running the application");
app.Run();
Log.Information("finished");