using Quitanda.CrossCutting.DTO.Base;

namespace Quitanda.CrossCutting.DTO.Fruta
{
    public class FrutaDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string ImagemFruta { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoqque { get; set; }
        public decimal Valor { get; set; }
    }
}