﻿using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
	public class CourseService : ICourseService
	{
		private readonly ICourseRepository _courseRepository;

		public CourseService(ICourseRepository courseRepository)
		{
			this._courseRepository = courseRepository;
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
