using Serilog;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

Extensions.DependencyInjection(builder.Services);

builder.Services.AddControllersWithViews();

var app = builder.Build();

Extensions.Environment(app);

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();

Log.Information("finished");