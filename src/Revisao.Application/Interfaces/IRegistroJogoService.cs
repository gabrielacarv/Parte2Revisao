using Revisao.Application.ViewModels;


namespace Revisao.Application.Interfaces
{
    public interface IRegistroJogoService
    {
        bool Adicionar(RegistroJogoViewModel registroJogoViewModel);
    }
}
