using Senai2025Api.Entidades;

namespace Senai2025Api.Interfaces.Repositorios
{
	public interface IBaseRepository<T> where T : BaseEntity
	{
		IQueryable<T> ObterTodos();

		T Get(long id);
	}
}
