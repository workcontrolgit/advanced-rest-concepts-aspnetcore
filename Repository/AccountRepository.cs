using Contracts;
using Entities;
using Entities.Helpers;
using Entities.Models;
using System;
using System.Linq;

namespace Repository
{
	public class AccountRepository : RepositoryBase<Account>, IAccountRepository
	{
		private ISortHelper<Account> _sortHelper;
		private IDataShaper<Account> _dataShaper;

		public AccountRepository(RepositoryContext repositoryContext, ISortHelper<Account> sortHelper, IDataShaper<Account> dataShaper)
			: base(repositoryContext)
		{
			_sortHelper = sortHelper;
			_dataShaper = dataShaper;
		}

		public PagedList<Entity> GetAccountsByEmployee(Guid employeeId, AccountParameters parameters)
		{
			var accounts = FindByCondition(a => a.EmployeeId.Equals(employeeId));

			var sortedAccounts = _sortHelper.ApplySort(accounts, parameters.OrderBy);

			var shapedAccounts = _dataShaper.ShapeData(sortedAccounts, parameters.Fields);

			return PagedList<Entity>.ToPagedList(shapedAccounts,
				parameters.PageNumber,
				parameters.PageSize);
		}

		public Entity GetAccountByEmployee(Guid employeeId, Guid id, string fields)
		{
			var account = FindByCondition(a => a.EmployeeId.Equals(employeeId) && a.Id.Equals(id)).SingleOrDefault();
			return _dataShaper.ShapeData(account, fields);
		}

		public Account GetAccountByEmployee(Guid employeeId, Guid id)
		{
			return FindByCondition(a => a.EmployeeId.Equals(employeeId) && a.Id.Equals(id)).SingleOrDefault();
		}
	}
}