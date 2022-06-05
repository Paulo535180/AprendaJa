using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_ALUNO")]
    public class Aluno
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string NOME { get; set; }

        [Required]
        public string EMAIL { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string SENHA { get; set; }

        public byte[] IMAGEM { get; set; }

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
