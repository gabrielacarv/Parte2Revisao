using Revisao.Application.Validação;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class NovoMegaSenaViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório!")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres e máximo de 255 caracteres!")]
        public string Nome { get; set; }

        [CpfValidationAttribute]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Primeiro número é obrigatório!")]
        [Range(1, 60, ErrorMessage = "O primeiro número deve estar entre 1 e 60!")]
        public int PrimeiroNro { get; set; }

        [Required(ErrorMessage = "Segundo número é obrigatório!")]
        [Range(1, 60, ErrorMessage = "O segundo número deve estar entre 1 e 60!")]
        public int SegundoNro { get; set; }

        [Required(ErrorMessage = "Terceiro número é obrigatório!")]
        [Range(1, 60, ErrorMessage = "O terceiro número deve estar entre 1 e 60!")]
        public int TerceiroNro { get; set; }

        [Required(ErrorMessage = "Quarto número é obrigatório!")]
        [Range(1, 60, ErrorMessage = "O quarto número deve estar entre 1 e 60!")]
        public int QuartoNro { get; set; }

        [Required(ErrorMessage = "Quinto número é obrigatório!")]
        [Range(1, 60, ErrorMessage = "O quinto número deve estar entre 1 e 60!")]
        public int QuintoNro { get; set; }

        [Required(ErrorMessage = "Sexto número é obrigatório!")]
        [Range(1, 60, ErrorMessage = "O sexto número deve estar entre 1 e 60!")]
        public int SextoNro { get; set; }

        //public DateTime DataJogo { get;  private set; }
    }
}