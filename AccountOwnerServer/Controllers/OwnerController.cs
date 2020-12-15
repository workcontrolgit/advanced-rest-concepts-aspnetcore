using Contracts;
using Entities.Extensions;
using Entities.Helpers;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace AccountEmployeeServer.Controllers
{
	/// <summary>
	/// EmployeeController
	/// </summary>
	[Route("api/employees")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private ILoggerManager _logger;
		private IRepositoryWrapper _repository;
		/// <summary>
		/// EmployeeController
		/// </summary>
		/// <param name="logger"></param>
		/// <param name="repository"></param>
		public EmployeeController(ILoggerManager logger,
			IRepositoryWrapper repository)
		{
			_logger = logger;
			_repository = repository;
		}
		/// <summary>
		/// GetEmployees
		/// </summary>
		/// <param name="employeeParameters"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult GetEmployees([FromQuery] EmployeeParameters employeeParameters)
		{
			if (!employeeParameters.ValidYearRange)
			{
				return BadRequest("Max year of birth cannot be less than min year of birth");
			}

			var employees = _repository.Employee.GetEmployees(employeeParameters);

			var metadata = new
			{
				employees.TotalCount,
				employees.PageSize,
				employees.CurrentPage,
				employees.TotalPages,
				employees.HasNext,
				employees.HasPrevious
			};

			Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

			_logger.LogInfo($"Returned {employees.TotalCount} employees from database.");

			return Ok(employees);
		}
		/// <summary>
		/// GetEmployeeById
		/// </summary>
		/// <param name="id"></param>
		/// <param name="fields"></param>
		/// <returns></returns>
		[HttpGet("{id}", Name = "EmployeeById")]
		public IActionResult GetEmployeeById(Guid id, [FromQuery] string fields)
		{
			var employee = _repository.Employee.GetEmployeeById(id, fields);

			if (employee == default(Entity))
			{
				_logger.LogError($"Employee with id: {id}, hasn't been found in db.");
				return NotFound();
			}

			return Ok(employee);
		}
		/// <summary>
		/// CreateEmployee
		/// </summary>
		/// <param name="employee"></param>
		/// <returns></returns>
		[HttpPost]
		public IActionResult CreateEmployee([FromBody]Employee employee)
		{
			if (employee.IsObjectNull())
			{
				_logger.LogError("Employee object sent from client is null.");
				return BadRequest("Employee object is null");
			}

			if (!ModelState.IsValid)
			{
				_logger.LogError("Invalid employee object sent from client.");
				return BadRequest("Invalid model object");
			}

			_repository.Employee.CreateEmployee(employee);
			_repository.Save();

			return CreatedAtRoute("EmployeeById", new { id = employee.Id }, employee);
		}
		/// <summary>
		/// UpdateEmployee
		/// </summary>
		/// <param name="id"></param>
		/// <param name="employee"></param>
		/// <returns></returns>
		[HttpPut("{id}")]
		public IActionResult UpdateEmployee(Guid id, [FromBody]Employee employee)
		{
			if (employee.IsObjectNull())
			{
				_logger.LogError("Employee object sent from client is null.");
				return BadRequest("Employee object is null");
			}

			if (!ModelState.IsValid)
			{
				_logger.LogError("Invalid employee object sent from client.");
				return BadRequest("Invalid model object");
			}

			var dbEmployee = _repository.Employee.GetEmployeeById(id);
			if (dbEmployee.IsEmptyObject())
			{
				_logger.LogError($"Employee with id: {id}, hasn't been found in db.");
				return NotFound();
			}

			_repository.Employee.UpdateEmployee(dbEmployee, employee);
			_repository.Save();

			return NoContent();
		}
		/// <summary>
		/// DeleteEmployee
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpDelete("{id}")]
		public IActionResult DeleteEmployee(Guid id)
		{
			var employee = _repository.Employee.GetEmployeeById(id);
			if (employee.IsEmptyObject())
			{
				_logger.LogError($"Employee with id: {id}, hasn't been found in db.");
				return NotFound();
			}

			_repository.Employee.DeleteEmployee(employee);
			_repository.Save();

			return NoContent();
		}
	}
}