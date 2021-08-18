using Quitanda.CrossCutting.DTO.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
