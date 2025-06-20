using Senai2025Api.Contexts;
using Senai2025Api.Interfaces.Repositorios;

namespace Senai2025Api.Repositorios
{
	public class EnderecoRepository : IEnderecoRepository
	{
		private readonly SenaiContext _context;

		public EnderecoRepository(SenaiContext context)
		{
			_context = context;
		}
	}
}
