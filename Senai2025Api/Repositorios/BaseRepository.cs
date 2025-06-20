using Microsoft.EntityFrameworkCore;
using Senai2025Api.Contexts;
using Senai2025Api.Entidades;
using Senai2025Api.Interfaces.Repositorios;

namespace Senai2025Api.Repositorios
{
	public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
	{
		protected readonly SenaiContext _context;
		protected readonly DbSet<T> _dbSet;

		public BaseRepository(SenaiContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		public IQueryable<T> ObterTodos()
		{
			return _dbSet;
		}

		public T Get(long id)
		{
			return _dbSet.FirstOrDefault(c => c.Id == id);
		}
	}
}
