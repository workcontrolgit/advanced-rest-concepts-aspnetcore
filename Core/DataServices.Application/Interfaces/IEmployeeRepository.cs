using DataServices.Core.Domain.Interfaces;
using DataServices.Core.Domain.Entities;
using System;
using DataServices.Core.Domain.Common;

namespace DataServices.Core.Application.Interfaces
{
	public interface IEmployeeRepository : IRepositoryBase<Employee>
	{
		PagedList<Entity> GetEmployees(EmployeeParameters employeeParameters);
		Entity GetEmployeeById(Guid employeeId, string fields);
		Employee GetEmployeeById(Guid employeeId);
		void CreateEmployee(Employee employee);
		void UpdateEmployee(Employee dbEmployee, Employee employee);
		void DeleteEmployee(Employee employee);
	}
}