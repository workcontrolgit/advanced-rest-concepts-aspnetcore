using Entities.Helpers;
using Entities.Models;
using System;

namespace Contracts
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