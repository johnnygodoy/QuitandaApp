using System.ComponentModel.DataAnnotations;

namespace Quitanda.CrossCutting.DTO.Usuario
{
    public class UsuarioInsertDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}