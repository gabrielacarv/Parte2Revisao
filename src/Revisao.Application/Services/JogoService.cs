using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Application.Services
{
    public class JogoService : IJogoService
    {
        #region Construtores
        private readonly IJogoRepository _registroJogoRepository;
        private IMapper _mapper;

        public JogoService(IJogoRepository registroJogoRepository, IMapper mapper)
        {
            _registroJogoRepository = registroJogoRepository;
            _mapper = mapper;
        }
        #endregion


        public bool Adicionar(NovoMegaSenaViewModel novoMegaSenaViewModel)
        {
            List<int> Numeros = new List<int>() { novoMegaSenaViewModel.PrimeiroNro, novoMegaSenaViewModel.SegundoNro, novoMegaSenaViewModel.TerceiroNro, novoMegaSenaViewModel.QuartoNro, novoMegaSenaViewModel.QuintoNro, novoMegaSenaViewModel.SextoNro};

            if (!ValidarNumerosDiferentes(Numeros))
            {
                return false;
            }

            bool ValidarNumerosDiferentes(List<int> numeros)
            {
                HashSet<int> numerosUnicos = new HashSet<int>();

                foreach (int numero in numeros)
                {
                    if (!numerosUnicos.Add(numero))
                    {
                        return false;
                    }
                }
                return true;
            }
            var novoJogo = _mapper.Map<Jogo>(novoMegaSenaViewModel);         
            _registroJogoRepository.Adicionar(novoJogo);
            return true;
        }

        public async Task<IEnumerable<MegaSenaViewModel>> ObterTodos()
        {
            var jogos = await _registroJogoRepository.ObterTodos();
            return _mapper.Map<IEnumerable<MegaSenaViewModel>>(jogos);
        }
    }
}