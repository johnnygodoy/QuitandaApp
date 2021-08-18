using Quitanda.CrossCutting.Filter;
using Quitanda.Domain.Entidades;
using Quitanda.Repository.Base;
using Quitanda.Repository.Context;
using Quitanda.Repository.Interface;
using Quitanda.Repository.Mock;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quitanda.Repository
{
    public class FrutaRepository : BaseRepository<Fruta, FrutaFilter>, IFrutaRepository
    {
        public FrutaRepository(DataContext context) : base(context)
        {
        }

        public override List<Fruta> GetAll(FrutaFilter filter)
        {
            //var listFrutas = _context.Set<Fruta>().Where(w => w.Active);

            var listFrutas = MockHelper.GetFrutas().Where(w => w.Active).ToList();

            if (!string.IsNullOrWhiteSpace(filter.Term))
                listFrutas = listFrutas.Where(w => w.Nome.ToUpper().Contains(filter.Term)).ToList();

            return listFrutas.OrderBy(a => a.Nome).ToList();
        }

        public override Fruta Find(Guid id)
        {
            return MockHelper.GetFrutas().Where(w => w.Id == id).FirstOrDefault();
        }

        public override void Remove(Guid id)
        {
            var fruta = MockHelper.GetFrutas().Where(w => w.Id == id && w.Active).FirstOrDefault();
            if (fruta != null)
            {
                fruta.Active = false;
            }
        }

        public override Fruta Update(Fruta dto)
        {
            return base.Update(dto);
        }

        public override Guid Create(Fruta dto)
        {
            dto.Id = Guid.NewGuid();

            var frutas = MockHelper.GetFrutas().Where(w => w.Active).ToList();

            frutas.Add(dto);

            return frutas.LastOrDefault().Id;
        }

        public Fruta Comprar(Guid id)
        {
            return MockHelper.GetFrutas().Where(w => w.Active && w.Id == id).ToList().FirstOrDefault();
        }
    }
}