using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;

namespace Revisao.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain() 
        {
            CreateMap<RegistroJogoViewModel, Jogo>()
                .ConstructUsing(q => new Jogo(q.Nome, q.Cpf, q.PrimeiroNro, q.SegundoNro, q.TerceiroNro, q.QuartoNro, q.QuintoNro, q.SextoNro, DateTime.Now));

            CreateMap<ObterTodosOsJogosViewModel, Jogo>();
        }
    }
}
