using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Senai2025Api.DTos;
using Senai2025Api.Entidades;
using Senai2025Api.Interfaces.Servicos;

namespace Senai2025Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {

        private readonly IEscolaService _escolaService;

        public EscolaController(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }

        [HttpPost]
        public IActionResult Salvar([FromBody] EscolaDTo escola)
        {
            if (escola == null)
                return BadRequest("Escola não pode ser nula");
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpPost]
		[Route("Editar")]

		public IActionResult Editar([FromBody] EscolaEdicaoDTo escola)
        {
			if (escola == null)
				return BadRequest("Escola não pode ser nula");
			_escolaService.Editar(escola);
			return Ok();
		}

        [HttpDelete]
        public IActionResult Remover(long id)
        {
            _escolaService.Remover(id);
            return Ok();

		}

		[HttpGet("PegarPorId")]
		public IActionResult PegarPorId(long id)
		{
			var escolas = _escolaService.ObterPorId(id);
			return Ok(escolas);

		}

		[HttpGet("ObterTodos")]
		public IActionResult ObterTodos()
		{
			var escolas = _escolaService.ObterTodos();
			return Ok(escolas);

		}





	}
}
