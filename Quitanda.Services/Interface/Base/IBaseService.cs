using Quitanda.CrossCutting.Base;
using System;
using System.Collections.Generic;

namespace Quitanda.Services.Interface.Base
{
    public interface IBaseService<T, TFilter> where T : class where TFilter : BaseFilter
    {
        Guid Create(T dto);

        T Update(T dto);

        void Remove(Guid id);

        T Find(Guid id);

        List<T> GetAll(TFilter filter);
    }
}