using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Repository.Interface
{
    public interface IFrutaRepository : IRepositoryBase<Fruta, FrutaFilter>
    {
        Fruta Comprar(Guid id);
    }
}
