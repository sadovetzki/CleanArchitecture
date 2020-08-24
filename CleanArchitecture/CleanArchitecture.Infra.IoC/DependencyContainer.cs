using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Application layer:
			services.AddScoped<ICourseService, CourseService>();

			// Infra.Data layer:
			services.AddScoped<ICourseRepository, CourseRepository>();
		}
	}
}
