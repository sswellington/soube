using Application.Interfaces.Services;
using Application.Services;

namespace Web.Configuration;

public static class DependencyInjectionConfig
{
	public static void Configure(IServiceCollection services)
	{
		Repositories(services);
		Services(services);

		services.AddHttpContextAccessor();
	}

	private static void Repositories(IServiceCollection services)
	{
	}

	private static void Services(IServiceCollection services)
	{
		services.AddSingleton<IMultipleService, MultipleService>();
	}
}
