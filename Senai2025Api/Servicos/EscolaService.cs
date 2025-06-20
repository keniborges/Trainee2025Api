using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Senai2025Api.DTos;
using Senai2025Api.Entidades;
using Senai2025Api.Interfaces.Repositorios;
using Senai2025Api.Interfaces.Servicos;

namespace Senai2025Api.Servicos
{
    public class EscolaService : IEscolaService
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepository _escolaRepository;
        public EscolaService(IMapper mapper, IEscolaRepository escolaRepository)
        {
            _mapper = mapper;   
            _escolaRepository = escolaRepository;
        }


        public void Salvar(EscolaDTo model)
        {
            var escola = _mapper.Map<Escola>(model);
            _escolaRepository.Salvar(escola);
        }

        public void Editar(EscolaEdicaoDTo model)
        {
            var escola = _escolaRepository.ObterPorId(model.Id);
			//escola.Nome = model.Nome;
			_mapper.Map(model, escola);

			_escolaRepository.Salvar(escola);

        }

        public bool Remover(long id)
        {
            return _escolaRepository.Remover(id);
        }

        public EscolaDTo ObterPorId(long id)
        {
            return _mapper.Map<EscolaDTo>(_escolaRepository.ObterPorId(id));
        }

        public List<EscolaDTo> ObterTodos()
        {
            return _mapper.Map<List<EscolaDTo>>(_escolaRepository.ObterTodos());
        }




    }
}
