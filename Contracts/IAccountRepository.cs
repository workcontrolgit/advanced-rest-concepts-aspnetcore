using Entities.Helpers;
using Entities.Models;
using System;

namespace Contracts
{
	public interface IAssignmentRepository : IRepositoryBase<Assignment>
	{
		PagedList<Entity> GetAssignmentsByEmployee(Guid employeeId, AssignmentParameters parameters);
		Entity GetAssignmentByEmployee(Guid employeeId, Guid id, string fields);
		Assignment GetAssignmentByEmployee(Guid employeeId, Guid id);
	}
}
