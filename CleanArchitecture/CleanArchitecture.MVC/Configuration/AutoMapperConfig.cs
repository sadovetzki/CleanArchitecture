using AutoMapper;
using CleanArchitecture.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.MVC.Configuration
{
	public static class AutoMapperConfig
	{
		public static void RegisterAutoMapper(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(AutoMapperConfiguration));
			AutoMapperConfiguration.RegisterMappings();
		}
	}
}
