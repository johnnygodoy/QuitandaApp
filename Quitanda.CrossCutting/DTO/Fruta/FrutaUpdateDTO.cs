using Quitanda.CrossCutting.DTO.Base;

namespace Quitanda.CrossCutting.DTO.Fruta
{
    public class FrutaUpdateDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string ImagemFruta { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}