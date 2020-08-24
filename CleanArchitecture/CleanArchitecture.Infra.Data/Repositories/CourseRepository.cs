using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System.Linq;

namespace CleanArchitecture.Infra.Data.Repositories
{
	public class CourseRepository : ICourseRepository
	{
		private readonly UniversityDbContext context;

		public CourseRepository(UniversityDbContext context)
		{
			this.context = context;
		}

		public void Add(Course course)
		{
			context.Courses.Add(course);
			context.SaveChanges();
		}

		public IQueryable<Course> GetCourses()
		{
			return context.Courses;
		}
	}
}
