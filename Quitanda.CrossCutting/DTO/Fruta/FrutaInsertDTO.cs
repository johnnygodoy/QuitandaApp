using System.ComponentModel.DataAnnotations;

namespace Quitanda.CrossCutting.DTO.Fruta
{
    public class FrutaInsertDTO
    {
        [Required]
        public string Nome { get; set; }

        public string ImagemFruta { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoqque { get; set; }
        public decimal Valor { get; set; }
    }
}