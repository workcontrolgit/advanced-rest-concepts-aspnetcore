using DataServices.Core.Domain.Entities;
using System.Collections.Generic;

namespace DataServices.Core.Domain.Interfaces
{
	public interface IDataShaper<T>
	{
		IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString);
		Entity ShapeData(T entity, string fieldsString);
	}
}