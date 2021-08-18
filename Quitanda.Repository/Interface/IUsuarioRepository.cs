using Quitanda.CrossCutting.Filter.Usuarios;
using Quitanda.Domain.Entidades;

namespace Quitanda.Repository.Interface
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario, UsuariosFilter>
    {
    }
}