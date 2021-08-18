using Quitanda.CrossCutting.Base;
using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Services.Interface.Base
{

    public interface IUsuarioService : IBaseService<Usuario, UsuariosFilter>
    {
       
    }
   
}
