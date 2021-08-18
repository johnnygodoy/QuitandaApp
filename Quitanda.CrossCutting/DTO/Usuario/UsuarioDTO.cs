using Quitanda.CrossCutting.DTO.Base;

namespace Quitanda.CrossCutting.DTO.Usuario
{
    public class UsuarioDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Login { get; set; }
    }
}