using DataServices.Domain.Models;
using System.Collections.Generic;

namespace DataServices.Domain.Helpers
{
	public interface IDataShaper<T>
	{
		IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString);
		Entity ShapeData(T entity, string fieldsString);
	}
}