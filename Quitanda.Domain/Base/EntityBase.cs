using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Domain.Base
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Date = DateTime.Now;
            Version = 1;
            Active = true;
        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Version { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}
