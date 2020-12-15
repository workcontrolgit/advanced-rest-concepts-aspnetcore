using Entities.Helpers;
using Entities.Models;
using System;

namespace Contracts
{
	public interface IAccountRepository : IRepositoryBase<Account>
	{
		PagedList<Entity> GetAccountsByEmployee(Guid employeeId, AccountParameters parameters);
		Entity GetAccountByEmployee(Guid employeeId, Guid id, string fields);
		Account GetAccountByEmployee(Guid employeeId, Guid id);
	}
}
