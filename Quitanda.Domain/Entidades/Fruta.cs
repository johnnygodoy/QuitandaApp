using Quitanda.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Quitanda.Domain.Entidades
{
    public class Fruta : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        public string ImagemFruta { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal Valor { get; set; }
    }
}