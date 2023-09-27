namespace Revisao.Domain.Entities
{
    public class Jogo
    {
        #region Propriedades
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int PrimeiroNro { get; private set; }
        public int SegundoNro { get; private set; }
        public int TerceiroNro { get; private set; }
        public int QuartoNro { get; private set; }
        public int QuintoNro { get; private set; }
        public int SextoNro { get; private set; }
        public DateTime DataJogo { get; private set; }
        #endregion

        #region Costrutores


        public Jogo(string nome, string cpf, int primeiroNro, int segundoNro, int terceiroNro, int quartoNro, int quintoNro, int sextoNro, DateTime dataJogo)
        {
            Nome = nome;
            Cpf = cpf;
            PrimeiroNro = primeiroNro;
            SegundoNro = segundoNro;
            TerceiroNro = terceiroNro;
            QuartoNro = quartoNro;
            QuintoNro = quintoNro;
            SextoNro = sextoNro;
            DataJogo = dataJogo;
        }
        #endregion

        #region Funções

        #endregion
    }
}