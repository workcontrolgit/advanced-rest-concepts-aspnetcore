using DataServices.Core.Domain.Interfaces;
using DataServices.Core.Domain.Entities;
using System;
using DataServices.Core.Domain.Common;

namespace DataServices.Core.Application.Interfaces
{
	public interface IAssignmentRepository : IRepositoryBase<Assignment>
	{
		PagedList<Entity> GetAssignmentsByEmployee(Guid employeeId, AssignmentParameters parameters);
		Entity GetAssignmentByEmployee(Guid employeeId, Guid id, string fields);
		Assignment GetAssignmentByEmployee(Guid employeeId, Guid id);
	}
}
