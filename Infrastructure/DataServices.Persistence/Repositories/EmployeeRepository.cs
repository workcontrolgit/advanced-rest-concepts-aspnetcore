using DataServices.Core.Application.Interfaces;
using DataServices.Core.Domain.Context;
using DataServices.Core.Domain.Extensions;
using DataServices.Core.Domain.Interfaces;
using DataServices.Core.Domain.Entities;
using System;
using System.Linq;
using DataServices.Core.Domain.Common;

namespace DataServices.Persistence.Repositories
{
	public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
	{
		private ISortHelper<Employee> _sortHelper;
		private IDataShaper<Employee> _dataShaper;

		public EmployeeRepository(ApplicationDbContext ApplicationDbContext, 
			ISortHelper<Employee> sortHelper,
			IDataShaper<Employee> dataShaper)
			: base(ApplicationDbContext)
		{
			_sortHelper = sortHelper;
			_dataShaper = dataShaper;
		}

		public PagedList<Entity> GetEmployees(EmployeeParameters employeeParameters)
		{
			var employees = FindByCondition(o => o.DateOfBirth.Year >= employeeParameters.MinYearOfBirth &&
										o.DateOfBirth.Year <= employeeParameters.MaxYearOfBirth);

			SearchByName(ref employees, employeeParameters.Name);

			var sortedEmployees = _sortHelper.ApplySort(employees, employeeParameters.OrderBy);
			var shapedEmployees = _dataShaper.ShapeData(sortedEmployees, employeeParameters.Fields);

			return PagedList<Entity>.ToPagedList(shapedEmployees,
				employeeParameters.PageNumber,
				employeeParameters.PageSize);
		}

		private void SearchByName(ref IQueryable<Employee> employees, string employeeName)
		{
			if (!employees.Any() || string.IsNullOrWhiteSpace(employeeName))
				return;

			if (string.IsNullOrEmpty(employeeName))
				return;

			//employees = employees.Where(o => o.Name.ToUpperInvariant().Contains(employeeName.Trim().ToUpperInvariant()));
			employees = employees.Where(o => o.Name.Contains(employeeName.Trim()));
			//employees = employees.Where(c => c.Name.IndexOf(employeeName.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
		}

		public Entity GetEmployeeById(Guid employeeId, string fields)
		{
			var employee = FindByCondition(employee => employee.Id.Equals(employeeId))
				.DefaultIfEmpty(new Employee())
				.FirstOrDefault();

			return _dataShaper.ShapeData(employee, fields);
		}

		public Employee GetEmployeeById(Guid employeeId)
		{
			return FindByCondition(employee => employee.Id.Equals(employeeId))
				.DefaultIfEmpty(new Employee())
				.FirstOrDefault();
		}

		public void CreateEmployee(Employee employee)
		{
			Create(employee);
		}

		public void UpdateEmployee(Employee dbEmployee, Employee employee)
		{
			dbEmployee.Map(employee);
			Update(dbEmployee);
		}

		public void DeleteEmployee(Employee employee)
		{
			Delete(employee);
		}
	}
}