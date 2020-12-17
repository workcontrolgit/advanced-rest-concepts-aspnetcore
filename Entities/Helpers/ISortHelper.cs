using System.Linq;

namespace DataServices.Domain.Helpers
{
	public interface ISortHelper<T>
	{
		IQueryable<T> ApplySort(IQueryable<T> entities, string orderByQueryString);
	}
}