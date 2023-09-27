using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RegistroJogosController : ControllerBase
	{
		private readonly IRegistroJogoService _registroJogoService;

		public RegistroJogosController(IRegistroJogoService registroJogoService)
		{
            _registroJogoService = registroJogoService;
		}

		[HttpPost]
		public IActionResult Post(RegistroJogoViewModel model)
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