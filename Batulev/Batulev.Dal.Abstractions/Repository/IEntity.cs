using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batulev.Dal.Abstractions.Repository
{
	/// <summary>
	/// Сущность которая обладает уникальной идентификацией.
	/// </summary>
	/// <typeparam name="TIdentifier"></typeparam>
	public interface IEntity<TIdentifier>
	{
		/// <summary>
		/// Уникальный идентификатор.
		/// </summary>
		TIdentifier Id { get; set; }
	}
}
