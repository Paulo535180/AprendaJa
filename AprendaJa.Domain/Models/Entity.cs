using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    public abstract class Entity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public bool STATUS { get; set; }

        [Required]
        public string USUARIO_CRIACAO { get; set; }


        [Required]
        public DateTime DATA_CRIACAO { get; set; }

        public string USUARIO_ALTERACAO { get; set; }

        public DateTime? DATA_ALTERACAO { get; set; }
    }
}
