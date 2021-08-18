using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;
using Quitanda.Repository.Interface;
using Quitanda.Services.Interface.Base;

namespace Quitanda.Services.Base
{
    public class UsuarioService : BaseService<Usuario, UsuariosFilter>, IUsuarioService
    {
        public UsuarioService(IUsuarioRepository repository) : base(repository)
        {
        }
    }
}