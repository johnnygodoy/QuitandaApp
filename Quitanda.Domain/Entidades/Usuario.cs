using Quitanda.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace Quitanda.Domain.Entidades
{
    public class Usuario : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}