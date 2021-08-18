using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Repository.Interface
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario, UsuariosFilter>
    {

    }
}
