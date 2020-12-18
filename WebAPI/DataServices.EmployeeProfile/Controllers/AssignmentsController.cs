﻿using DataServices.Core.Application.Interfaces;
using DataServices.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace DataServices.WebAPI.EmployeeProfile.Controllers
{
	/// <summary>
	/// AssignmentController
	/// </summary>
	[Route("api/employees/{employeeId}/assignments")]
	[ApiController]
	
	public class AssignmentsController : ControllerBase
	{
		private ILoggerManager _logger;
		private IRepositoryWrapper _repository;
		/// <summary>
		/// Documentation for AssignmentController goes here
		/// </summary>
		/// <param name="logger"></param>
		/// <param name="repository"></param>
		public AssignmentsController(ILoggerManager logger,
			IRepositoryWrapper repository)
		{
			_logger = logger;
			_repository = repository;
		}
		/// <summary>
		/// Documentation for GetAssignmentsForEmployee goes here
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult GetAssignmentsForEmployee(Guid employeeId, [FromQuery] AssignmentParameters parameters)
		{
			var assignments = _repository.Assignment.GetAssignmentsByEmployee(employeeId, parameters);

			var metadata = new
			{
				assignments.TotalCount,
				assignments.PageSize,
				assignments.CurrentPage,
				assignments.TotalPages,
				assignments.HasNext,
				assignments.HasPrevious
			};

			Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

			_logger.LogInfo($"Returned {assignments.TotalCount} assignments from database.");

			return Ok(assignments);
		}
		/// <summary>
		/// Documentation for GetAssignmentForEmployee goes here
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="id"></param>
		/// <param name="fields"></param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public IActionResult GetAssignmentForEmployee(Guid employeeId, Guid id, [FromQuery] string fields)
		{
			var assignment = _repository.Assignment.GetAssignmentByEmployee(employeeId, id, fields);

			if (assignment == default(Entity))
			{
				_logger.LogError($"Assignment with id: {id}, hasn't been found in db.");
				return NotFound();
			}

			return Ok(assignment);
		}
	}
}
