using Application.Interfaces.Services;
using Application.Services;

namespace Web.Extensions;

public static partial class Extensions
{
	public static void DependencyInjection(IServiceCollection services)
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
