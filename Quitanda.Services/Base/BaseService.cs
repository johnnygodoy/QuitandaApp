using Quitanda.CrossCutting.Base;
using Quitanda.Repository.Interface;
using Quitanda.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Services.Base
{
    public class BaseService<T, TFilter> : IBaseService<T, TFilter> where T : class where TFilter : BaseFilter
    {
        protected readonly IRepositoryBase<T, TFilter> Repository;

        public BaseService(IRepositoryBase<T, TFilter> repository)
        {
            Repository = repository;
        }

        public virtual Guid Create(T dto)
        {
            return Repository.Create(dto);
        }

        public virtual T Update(T dto)
        {
            return Repository.Update(dto);
        }

        public virtual void Remove(Guid id)
        {
            if (Find(id) == null)
                throw new Exception();

            Repository.Remove(id);
        }

        public virtual T Find(Guid id)
        {
            return Repository.Find(id) ?? throw new Exception();
        }

        public virtual List<T> GetAll(TFilter filter)
        {
            return Repository.GetAll(filter);
        }
    }
}


