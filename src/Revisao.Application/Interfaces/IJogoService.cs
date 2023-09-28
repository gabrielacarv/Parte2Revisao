using Revisao.Application.ViewModels;


namespace Revisao.Application.Interfaces
{
    public interface IJogoService
    {
        bool Adicionar(NovoMegaSenaViewModel novoMegaSenaViewModel);
        Task<IEnumerable<MegaSenaViewModel>> ObterTodos();
    }
}
