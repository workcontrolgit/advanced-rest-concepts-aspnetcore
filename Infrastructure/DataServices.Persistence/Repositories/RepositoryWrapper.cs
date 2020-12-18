using DataServices.Core.Application.Interfaces;
using DataServices.Core.Domain.Context;
using DataServices.Core.Domain.Interfaces;
using DataServices.Core.Domain.Entities;

namespace DataServices.Persistence.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private ApplicationDbContext _repoContext;
		private IEmployeeRepository _employee;
		private IAssignmentRepository _assignment;
		private ISortHelper<Employee> _employeeSortHelper;
		private ISortHelper<Assignment> _assignmentSortHelper;
		private IDataShaper<Employee> _employeeDataShaper;
		private IDataShaper<Assignment> _assignmentDataShaper;

		public IEmployeeRepository Employee
		{
			get
			{
				if (_employee == null)
				{
					_employee = new EmployeeRepository(_repoContext, _employeeSortHelper, _employeeDataShaper);
				}

				return _employee;
			}
		}

		public IAssignmentRepository Assignment
		{
			get
			{
				if (_assignment == null)
				{
					_assignment = new AssignmentRepository(_repoContext, _assignmentSortHelper, _assignmentDataShaper);
				}

				return _assignment;
			}
		}

		public RepositoryWrapper(ApplicationDbContext ApplicationDbContext,
			ISortHelper<Employee> employeeSortHelper,
			ISortHelper<Assignment> assignmentSortHelper,
			IDataShaper<Employee> employeeDataShaper,
			IDataShaper<Assignment> assignmentDataShaper)
		{
			_repoContext = ApplicationDbContext;
			_employeeSortHelper = employeeSortHelper;
			_assignmentSortHelper = assignmentSortHelper;
			_employeeDataShaper = employeeDataShaper;
			_assignmentDataShaper = assignmentDataShaper;
		}

		public void Save()
		{
			_repoContext.SaveChanges();
		}
	}
}
