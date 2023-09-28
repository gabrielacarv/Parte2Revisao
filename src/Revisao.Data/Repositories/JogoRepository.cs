using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Data.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly string _registroJogoCaminhoArquivo;

        #region Construtores

        public JogoRepository()
        {
            _registroJogoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "registroJogo.json"); ;
        }
        #endregion


        #region Funções
        public void Adicionar(Jogo jogo)
        {
            List<Jogo> jogos = LerJogosDoArquivo();
            jogos.Add(jogo);
            EscreverJogoNoArquivo(jogos);
        }

        public Task<IEnumerable<Jogo>> ObterTodos()
        {
            List<Jogo> jogos = LerJogosDoArquivo();
            return Task.FromResult<IEnumerable<Jogo>>(jogos);
        }

        #endregion

        #region Métodos arquivo
        private List<Jogo> LerJogosDoArquivo()
        {
            if (!System.IO.File.Exists(_registroJogoCaminhoArquivo))
            {
                return new List<Jogo>();
            }

            string json = System.IO.File.ReadAllText(_registroJogoCaminhoArquivo);
            if (string.IsNullOrEmpty(json))
            {
                return new List<Jogo>();
            }
            return JsonConvert.DeserializeObject<List<Jogo>>(json);
        }

        private void EscreverJogoNoArquivo(List<Jogo> registroJogos)
        {
            string json = JsonConvert.SerializeObject(registroJogos);
            System.IO.File.WriteAllText(_registroJogoCaminhoArquivo, json);
        }
        #endregion
    }
}
