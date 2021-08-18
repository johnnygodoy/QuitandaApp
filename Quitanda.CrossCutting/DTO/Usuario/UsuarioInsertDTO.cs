using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
