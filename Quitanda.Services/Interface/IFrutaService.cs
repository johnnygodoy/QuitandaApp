using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using System;

namespace Quitanda.Services.Interface.Base
{
    public interface IFrutaService : IBaseService<Fruta, FrutaFilter>
    {
        string Comprar(Guid id, int quantidade);
    }
}