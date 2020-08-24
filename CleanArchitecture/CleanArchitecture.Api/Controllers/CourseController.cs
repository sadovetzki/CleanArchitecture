using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly ICourseService courseService;

		public CourseController(ICourseService courseService)
		{
			this.courseService = courseService;
		}

		[HttpPost]
		public IActionResult CreateCourse([FromBody] CourseViewModel courseViewModel)
		{
			courseService.CreateCourse(courseViewModel);

			return Ok(courseViewModel);
		}

		[HttpGet]
		public ActionResult GetCourses()
		{
			var courses = courseService.GetCourses();
			return Ok(courses);
		}
	}
}
