using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
	public class CourseService : ICourseService
	{
		private readonly ICourseRepository _courseRepository;
		private readonly IMeditorHandler _bus;

		public CourseService(ICourseRepository courseRepository, IMeditorHandler bus)
		{
			this._courseRepository = courseRepository;
			this._bus = bus;
		}

		public void CreateCourse(CourseViewModel courseViewModel)
		{
			var command = new CreateCourseCommand(
				courseViewModel.Name,
				courseViewModel.Description,
				courseViewModel.ImageUrl);

			_bus.SendCommand(command);
		}

		public CourseViewModel GetCourses()
		{
			return new CourseViewModel
			{
				Courses = this._courseRepository.GetCourses()
			};
		}
	}
}
