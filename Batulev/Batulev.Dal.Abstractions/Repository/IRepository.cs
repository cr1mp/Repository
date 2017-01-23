using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batulev.Dal.Abstractions.Repository
{
	/// <summary>
	/// Интерфейс репозитория позволяет добавлять, удалять и получать елементы из хранилища.
	/// </summary>
	/// <typeparam name="TElement">Тип элементов с которыми работает хринилище.</typeparam>
	public interface IRepository<TElement>:IQueryable<TElement>
	{
		/// <summary>
		/// Добавить элемент в хранилище.
		/// </summary>
		/// <param name="entity"></param>
		void Add(TElement entity);

		/// <summary>
		/// Удалить элемент из хранилища.
		/// </summary>
		/// <param name="entity"></param>
		void Remove(TElement entity);
	}
}
