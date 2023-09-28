using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MegaSenaController : ControllerBase
	{
		private readonly IJogoService _registroJogoService;

		public MegaSenaController(IJogoService registroJogoService)
		{
            _registroJogoService = registroJogoService;
		}

        [HttpGet("ObterTodosOsJogos")]
        public async Task<IActionResult> Get()
        {
            var jogos = await _registroJogoService.ObterTodos();
            return Ok(jogos);
        }

        [HttpPost("RegistrarJogo")]
		public IActionResult Post(NovoMegaSenaViewModel model)
		{
			bool Valido = _registroJogoService.Adicionar(model);	
			if (Valido)
			{
                return Ok(model);
            }
			else
			{
                return BadRequest("Falha ao adicionar o registro do jogo, existem números repetidos!");
            }

        }
		
	}
}