using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Domain.Models
{
    [Table("AJ_AULA")]
    public class Aula : Entity
    {
        [Required]
        public int ID_MODULO { get; set; }
        public Modulo Modulo { get; set; }
        [Required]
        public string NOME { get; set; }
        [Required]
        public string DESCRICAO { get; set; }
        [Required]
        public int TIPO_AULA { get; set; }
        public TipoAula TipoAula { get; set; }
        [Required]
        public int ORDEM_AULA { get; set; }
        public string VIDEO { get; set; }
        public string TEXTO { get; set; }
        public string NOME_ARQUIVO { get; set; }
        public string TIPO_ARQUIVO { get; set; }
        public byte[] DATA { get; set; }
    }
}
