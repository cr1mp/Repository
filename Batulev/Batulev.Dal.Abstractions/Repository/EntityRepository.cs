namespace Batulev.Dal.Abstractions.Repository
{
	public abstract class EntityRepository<TEntity, TIdentifier> : EntityReadOnlyRepository<TEntity, TIdentifier>, IRepository<TEntity>
		where TEntity : IEntity<TIdentifier>
	{
		public virtual void Remove(TIdentifier identifier)
		{
			Remove(GetById(identifier));
		}

		public abstract void Add(TEntity entity);

		public abstract void Remove(TEntity entity);
	}
}