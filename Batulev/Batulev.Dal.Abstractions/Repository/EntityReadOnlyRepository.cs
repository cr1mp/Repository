using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Batulev.Dal.Abstractions.Repository
{
	public abstract class EntityReadOnlyRepository<TEntity, TIdentifier> : IQueryable<TEntity>
		where TEntity : IEntity<TIdentifier>
	{
		protected abstract IQueryable<TEntity> All { get; }

		public virtual TEntity GetByIdOrNull(TIdentifier identifier) => 
			All.FirstOrDefault(entity => entity.Id.Equals(identifier));

		public virtual TEntity GetById(TIdentifier identifier)
		{
			var entity = GetByIdOrNull(identifier);
			if (entity == null)
			{
				throw new NullReferenceException("Элемента с таким идентификатором нет в хранилище");
			}
			return entity;
		}

		#region IQueryable<TEntity>

		public Expression Expression => All.Expression;
		public Type ElementType => All.ElementType;
		public IQueryProvider Provider => All.Provider;

		public IEnumerator<TEntity> GetEnumerator() => All.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		#endregion IQueryable<TEntity>
	}
}