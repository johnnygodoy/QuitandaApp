using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Services.Interface.Base
{
    public interface IFrutaService:IBaseService<Fruta,FrutaFilter>
    {
        string Comprar(Guid id, int quantidade);
    }
}
