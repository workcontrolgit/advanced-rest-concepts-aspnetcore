using Contracts;
using DataServices.Domain;
using DataServices.Domain.Helpers;
using DataServices.Domain.Models;

namespace DataServices.Persistence
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private RepositoryContext _repoContext;
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

		public RepositoryWrapper(RepositoryContext repositoryContext,
			ISortHelper<Employee> employeeSortHelper,
			ISortHelper<Assignment> assignmentSortHelper,
			IDataShaper<Employee> employeeDataShaper,
			IDataShaper<Assignment> assignmentDataShaper)
		{
			_repoContext = repositoryContext;
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
