using Quitanda.CrossCutting.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.CrossCutting.Filter.Usuarios
{
   public class UsuariosFilter:BaseFilter
    {
        public UsuariosFilter(string term)
        {
            if (!string.IsNullOrWhiteSpace(term))
                Term = term.ToUpper();
        }
    }
}
