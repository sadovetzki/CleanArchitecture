using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.CommandHandlers;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Bus;
using CleanArchitecture.Infra.Data.Context;
using CleanArchitecture.Infra.Data.Repositories;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Domain InMemoryBus MediatR:
			services.AddScoped<IMeditorHandler, InMemoryBus>();

			// Domain Handlers
			services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

			// Application layer:
			services.AddScoped<ICourseService, CourseService>();

			// Infra.Data layer:
			services.AddScoped<ICourseRepository, CourseRepository>();
			services.AddScoped<UniversityDbContext>();
		}
	}
}
