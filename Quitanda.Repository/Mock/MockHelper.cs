using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Repository.Mock
{
    public class MockHelper
    {
        public static IList<Fruta> GetFrutas()
        {

            return new List<Fruta>
            {
                new Fruta{Id=Guid.Parse("c425219c-6e63-4151-bd81-3f9fc8ab9b74"), Nome = "Banana", QuantidadeEstoque = 10, Active =true },
                 new Fruta{Id=Guid.Parse("6dbf463c-7cce-44f6-9a79-aa1e3da7c5c9"), Nome = "Maça", QuantidadeEstoque = 10, Active =true },
                  new Fruta{Id=Guid.Parse("910cfb16-3060-4487-82d3-3d66fb2d5bac"), Nome = "Pera", QuantidadeEstoque = 10, Active =true },
                   new Fruta{Id=Guid.Parse("5b3800ac-f001-4b16-961e-c4d3911184d8"), Nome = "Uva", QuantidadeEstoque = 10, Active =true }
            };
        }
    }
}
