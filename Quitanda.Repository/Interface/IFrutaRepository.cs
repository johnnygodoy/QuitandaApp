using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using System;

namespace Quitanda.Repository.Interface
{
    public interface IFrutaRepository : IRepositoryBase<Fruta, FrutaFilter>
    {
        Fruta Comprar(Guid id);
    }
}