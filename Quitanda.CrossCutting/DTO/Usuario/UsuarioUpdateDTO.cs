using Quitanda.CrossCutting.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.CrossCutting.DTO.Usuario
{
    public class UsuarioUpdateDTO: BaseDTO
    {
        public string Nome { get; set; }
        public string Login { get; set; }       
    }
}
