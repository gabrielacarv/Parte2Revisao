using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class ObterTodosOsJogosViewModel
    {
        public string Nome { get;  set; }
        public int PrimeiroNro { get;  set; }
        public int SegundoNro { get;  set; }
        public int TerceiroNro { get;  set; }
        public int QuartoNro { get; set; }
        public int QuintoNro { get; set; }
        public int SextoNro { get; set; }
        public DateTime DataJogo { get; set; }
    }
}
