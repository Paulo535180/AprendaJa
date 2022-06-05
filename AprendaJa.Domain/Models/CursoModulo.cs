using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_CURSO_MODULO")]
    public class CursoModulo : Entity
    {
        public int ID_MODULO { get; set; }
        public Modulo Modulo { get; set; }
        public int ID_CURSO { get; set; }
        public Curso Curso { get; set; }
    }
}
