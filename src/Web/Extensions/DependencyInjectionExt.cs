using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Services;
using Infrastructure.DataAccess.Repositories;

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
		services.AddSingleton<IQuestionRepository, QuestionRepository>();
	}

	private static void Services(IServiceCollection services)
	{
		services.AddSingleton<IMultipleService, MultipleService>();
	}
}
