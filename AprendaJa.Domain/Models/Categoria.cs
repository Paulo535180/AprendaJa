using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_CATEGORIA")]
    public class Categoria : Entity
    {
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }        
    }
}
