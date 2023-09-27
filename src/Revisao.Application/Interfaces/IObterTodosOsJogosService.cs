using Revisao.Application.ViewModels;

namespace Revisao.Application.Interfaces
{
    public interface IObterTodosOsJogosService
    {
        Task<IEnumerable<ObterTodosOsJogosViewModel>> ObterTodos();
    }
}
