using System;
using System.Linq;
using System.Linq.Expressions;

namespace PragProgPres.Data
{
	public interface IRepository<Type>
	{
		void Add(Type newEntity);
		void Remove(Type entity);
		IQueryable<Type> Find(Expression<Func<Type, bool>> redicate);

	}
}

