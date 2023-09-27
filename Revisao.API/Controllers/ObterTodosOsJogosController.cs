using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ObterTodosOsJogosController : ControllerBase
	{
		private readonly IObterTodosOsJogosService _obterTodosOsJogosService;

		public ObterTodosOsJogosController(IObterTodosOsJogosService ObterTodosOsJogosService)
		{
			_obterTodosOsJogosService = ObterTodosOsJogosService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var jogos = await _obterTodosOsJogosService.ObterTodos();
			return Ok(jogos);
		}
	}
}