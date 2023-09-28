using Revisao.Domain.Entities;

namespace Revisao.Domain.Interfaces
{
    public interface IJogoRepository
    {
        void Adicionar(Jogo jogo);
        Task<IEnumerable<Jogo>> ObterTodos();
    }
}
