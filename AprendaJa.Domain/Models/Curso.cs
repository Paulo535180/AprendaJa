using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_CURSO")]
    public class Curso : Entity
    {
        [Required]
        public int ID_CATEGORIA { get; set; }
        public Categoria CATEGORIA { get; set; }
        [Required]
        public string NOME { get; set; }
        [Required]
        public string DESCRICAO { get; set; }
        public byte[] IMAGEM { get; set; }
    }
}
