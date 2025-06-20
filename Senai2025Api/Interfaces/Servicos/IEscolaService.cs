using Senai2025Api.DTos;
using Senai2025Api.Entidades;

namespace Senai2025Api.Interfaces.Servicos
{
    public interface IEscolaService
    {

        void Salvar(EscolaDTo escola);

        void Editar(EscolaEdicaoDTo model);

		bool Remover(long id);

		Escola ObterPorId(long id);
        List<Escola> ObterTodos();
        

    }
}
