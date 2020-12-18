using System.Linq;

namespace DataServices.Core.Domain.Interfaces
{
	public interface ISortHelper<T>
	{
		IQueryable<T> ApplySort(IQueryable<T> entities, string orderByQueryString);
	}
}