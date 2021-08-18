using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;
using Quitanda.Repository;
using Quitanda.Repository.Interface;
using Quitanda.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Services.Base
{
   public  class UsuarioService: BaseService<Usuario, UsuariosFilter>, IUsuarioService
    {       
        public UsuarioService(IUsuarioRepository repository): base(repository)
        {

        }
    }
}
