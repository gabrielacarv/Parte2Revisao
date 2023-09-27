using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Application.Services
{
    public class RegistroJogoService : IRegistroJogoService
    {
        #region Construtores
        private readonly IRegistroJogoRepository _registroJogoRepository;
        private IMapper _mapper;

        public RegistroJogoService(IRegistroJogoRepository registroJogoRepository, IMapper mapper)
        {
            _registroJogoRepository = registroJogoRepository;
            _mapper = mapper;
        }
        #endregion


        public bool Adicionar(RegistroJogoViewModel registroJogoViewModel)
        {
            List<int> Numeros = new List<int>() {registroJogoViewModel.PrimeiroNro, registroJogoViewModel.SegundoNro, registroJogoViewModel.TerceiroNro, registroJogoViewModel.QuartoNro, registroJogoViewModel.QuintoNro, registroJogoViewModel.SextoNro};

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
            var novoJogo = _mapper.Map<Jogo>(registroJogoViewModel);         
            _registroJogoRepository.Adicionar(novoJogo);
            return true;
        }
    }
}