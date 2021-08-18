using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;

namespace Quitanda.Services.Interface.Base
{
    public interface IUsuarioService : IBaseService<Usuario, UsuariosFilter>
    {
    }
}