using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Interfaces;


namespace Revisao.Application.Services
{
    public class ObterTodosOsJogosService : IObterTodosOsJogosService
    {
        
        private readonly IObterTodosOsJogosRepository _registroJogoRepository;
        private IMapper _mapper;

        public ObterTodosOsJogosService(IObterTodosOsJogosRepository obterTodosOsJogosRepository, IMapper mapper)
        {
            _registroJogoRepository = obterTodosOsJogosRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ObterTodosOsJogosViewModel>> ObterTodos()
        {
            var jogos = await _registroJogoRepository.ObterTodos();
            return _mapper.Map<IEnumerable<ObterTodosOsJogosViewModel>>(jogos);
        }
    }
}
