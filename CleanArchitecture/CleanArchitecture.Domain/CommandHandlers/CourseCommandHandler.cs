﻿using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.CommandHandlers
{
	public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
	{
		private readonly ICourseRepository _courseRepository;

		public CourseCommandHandler(ICourseRepository courseRepository)
		{
			this._courseRepository = courseRepository;
		}

		public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
		{
			var course = new Course()
			{
				Name = request.Name,
				Description = request.Description,
				ImageUrl = request.ImageUrl
			};

			this._courseRepository.Add(course);

			return Task.FromResult(true);
		}
	}
}
