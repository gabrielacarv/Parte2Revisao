using Revisao.Domain.Entities;

namespace Revisao.Domain.Interfaces
{
    public interface IObterTodosOsJogosRepository
    {
        Task<IEnumerable<Jogo>> ObterTodos();
    }
}
