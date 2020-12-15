using Contracts;
using Entities;
using Entities.Helpers;
using Entities.Models;

namespace Repository
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private RepositoryContext _repoContext;
		private IEmployeeRepository _employee;
		private IAccountRepository _account;
		private ISortHelper<Employee> _employeeSortHelper;
		private ISortHelper<Account> _accountSortHelper;
		private IDataShaper<Employee> _employeeDataShaper;
		private IDataShaper<Account> _accountDataShaper;

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

		public IAccountRepository Account
		{
			get
			{
				if (_account == null)
				{
					_account = new AccountRepository(_repoContext, _accountSortHelper, _accountDataShaper);
				}

				return _account;
			}
		}

		public RepositoryWrapper(RepositoryContext repositoryContext,
			ISortHelper<Employee> employeeSortHelper,
			ISortHelper<Account> accountSortHelper,
			IDataShaper<Employee> employeeDataShaper,
			IDataShaper<Account> accountDataShaper)
		{
			_repoContext = repositoryContext;
			_employeeSortHelper = employeeSortHelper;
			_accountSortHelper = accountSortHelper;
			_employeeDataShaper = employeeDataShaper;
			_accountDataShaper = accountDataShaper;
		}

		public void Save()
		{
			_repoContext.SaveChanges();
		}
	}
}
