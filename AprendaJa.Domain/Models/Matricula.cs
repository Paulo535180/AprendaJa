using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_MATRICULA")]
    public class Matricula
    {
        public int ID_ALUNO { get; set; }
        public int ID_CURSO_MODULO { get; set; }
        public IEnumerable<CursoModulo> ModuloCurso { get; set; }
    }
}
