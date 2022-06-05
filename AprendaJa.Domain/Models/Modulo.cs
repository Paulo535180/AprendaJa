using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_MODULO")]
    public class Modulo : Entity
    { 
        [Required]
        public string NOME { get; set; }
        [Required]
        public string DESCRICAO { get; set; }
        //public IEnumerable<CursoModulo> CursosModulos { get; set; }
    }
}
