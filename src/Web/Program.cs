using Serilog;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

Extensions.DependencyInjection(builder.Services);

builder.Services.AddControllersWithViews();

var app = builder.Build();

Extensions.Environment(app);

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