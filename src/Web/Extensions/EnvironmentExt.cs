using Serilog;

namespace Web.Extensions;

public static partial class Extensions
{
	public static void Environment(WebApplication app)
	{
		if (app.Environment.IsDevelopment())
			Log.Information("building the application in Development");

		if (!app.Environment.IsDevelopment())
		{
			Log.Information("building the application");
			app.UseExceptionHandler("/Home/Error");
			app.UseHsts();
		}
	}
}
