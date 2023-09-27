using Revisao.Domain.Entities;

namespace Revisao.Domain.Interfaces
{
    public interface IRegistroJogoRepository
    {
        void Adicionar(Jogo jogo);
    }
}
