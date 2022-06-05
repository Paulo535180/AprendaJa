using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_TIPO_AULA")]
    public class TipoAula : Entity
    {
        public string NOME { get; set; }
    }
}
