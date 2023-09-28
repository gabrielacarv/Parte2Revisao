using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;

namespace Revisao.Application.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication() 
        {
            CreateMap<Jogo, MegaSenaViewModel>();
        }
    }
}
