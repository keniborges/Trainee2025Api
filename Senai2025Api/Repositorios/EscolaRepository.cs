using Microsoft.EntityFrameworkCore;
using Senai2025Api.Contexts;
using Senai2025Api.Entidades;
using Senai2025Api.Interfaces.Repositorios;

namespace Senai2025Api.Repositorios
{
	public class EscolaRepository : BaseRepository<Escola>, IEscolaRepository
	{
		private readonly SenaiContext _context;

		public EscolaRepository(SenaiContext context) : base(context)
		{
			_context = context;
		}

		public void Salvar(Escola escola)
		{
			if (escola.Id > 0)
			{
				_context.Escola.Update(escola);
			}
			else
			{
				_context.Escola.Add(escola);
			}
			_context.SaveChanges();
		}

		public bool Remover(long id)
		{
			try
			{
				var escola = ObterPorId(id);
				if (escola == null)
					return false;
				_context.Escola.Remove(escola);
				_context.SaveChanges(true);
				return true;

				//_context.Escola.Where(u => u.Id == id).ExecuteDeleteAsy();
			}
			catch
			{
				return false;
			}


		}

		public Escola ObterPorId(long id)
		{
			//return base.Get(id);
			return _context
				.Escola
				.Include(c => c.Endereco)
				.Include(c => c.Professores)
				.FirstOrDefault(e => e.Id == id);
		}

		public List<Escola> ObterTodos()
		{

			return base.ObterTodos().Include(c => c.Endereco).ToList();
			//return _context.Escola.ToList();
		}

	}
}
