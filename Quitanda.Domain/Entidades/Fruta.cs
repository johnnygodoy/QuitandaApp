using Quitanda.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Domain.Entidades
{
   public class Fruta: EntityBase
    {
        public string Nome { get; set; }
        public string ImagemFruta { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal Valor { get; set; }
    }
}
