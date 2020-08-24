using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;

using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
	public class CourseService : ICourseService
	{
		private readonly ICourseRepository	_courseRepository;
		private readonly IMeditorHandler	_bus;
		private readonly IMapper			_autoMapper;

		public CourseService(ICourseRepository courseRepository, IMeditorHandler bus, IMapper autoMapper)
		{
			this._courseRepository = courseRepository;
			this._bus = bus;
			this._autoMapper = autoMapper;
		}

		public void CreateCourse(CourseViewModel courseViewModel)
		{
			_bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
		}

		public IEnumerable<CourseViewModel> GetCourses()
		{
			return _courseRepository.GetCourses()
									.ProjectTo<CourseViewModel>(
										this._autoMapper.ConfigurationProvider
									);
		}
	}
}
