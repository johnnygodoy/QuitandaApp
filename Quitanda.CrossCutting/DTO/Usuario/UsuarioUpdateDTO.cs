using Quitanda.CrossCutting.DTO.Base;

namespace Quitanda.CrossCutting.DTO.Usuario
{
    public class UsuarioUpdateDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Login { get; set; }
    }
}