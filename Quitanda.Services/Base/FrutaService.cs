using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using Quitanda.Repository.Interface;
using Quitanda.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Services.Base
{
    public class FrutaService:BaseService<Fruta, FrutaFilter>,IFrutaService
    {       
        public FrutaService(IFrutaRepository repository):base(repository)
        {
            
        }
        public string Comprar(Guid id, int quantidade)
        {
            var fruta = ((IFrutaRepository)Repository).Comprar(id);

            if (fruta != null && fruta.QuantidadeEstoque >= quantidade)
            {
                fruta.QuantidadeEstoque -= quantidade;
                return $"Compra efetuada, quantidade {quantidade} de {fruta.Nome}(s). Estoque atualizado para: {fruta.QuantidadeEstoque}";
            }

            return "Fruta não encontrada, ou estoque insuficiente";
            
        }
    }
}
