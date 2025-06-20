using Senai2025Api.Entidades;

namespace Senai2025Api.Interfaces.Repositorios
{
    public interface IEscolaRepository : IBaseRepository<Escola>
    {
        void Salvar(Escola escola);


        bool Remover(long id);



		Escola ObterPorId(long id);


        List<Escola> ObterTodos();

    }
}
