using Contracts;
using DataServices.Domain.Context;
using DataServices.Domain.Helpers;
using DataServices.Domain.Models;
using System;
using System.Linq;

namespace DataServices.Persistence.Repositories
{
	public class AssignmentRepository : RepositoryBase<Assignment>, IAssignmentRepository
	{
		private ISortHelper<Assignment> _sortHelper;
		private IDataShaper<Assignment> _dataShaper;

		public AssignmentRepository(ApplicationDbContext ApplicationDbContext, ISortHelper<Assignment> sortHelper, IDataShaper<Assignment> dataShaper)
			: base(ApplicationDbContext)
		{
			_sortHelper = sortHelper;
			_dataShaper = dataShaper;
		}

		public PagedList<Entity> GetAssignmentsByEmployee(Guid employeeId, AssignmentParameters parameters)
		{
			var assignments = FindByCondition(a => a.EmployeeId.Equals(employeeId));

			var sortedAssignments = _sortHelper.ApplySort(assignments, parameters.OrderBy);

			var shapedAssignments = _dataShaper.ShapeData(sortedAssignments, parameters.Fields);

			return PagedList<Entity>.ToPagedList(shapedAssignments,
				parameters.PageNumber,
				parameters.PageSize);
		}

		public Entity GetAssignmentByEmployee(Guid employeeId, Guid id, string fields)
		{
			var assignment = FindByCondition(a => a.EmployeeId.Equals(employeeId) && a.Id.Equals(id)).SingleOrDefault();
			return _dataShaper.ShapeData(assignment, fields);
		}

		public Assignment GetAssignmentByEmployee(Guid employeeId, Guid id)
		{
			return FindByCondition(a => a.EmployeeId.Equals(employeeId) && a.Id.Equals(id)).SingleOrDefault();
		}
	}
}