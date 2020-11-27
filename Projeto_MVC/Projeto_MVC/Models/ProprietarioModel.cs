using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.Models
{
    [Table("Proprietario")]
    public class ProprietarioModel
    {
        [Key]
        public int ProprietarioId { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(13, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string Rg { get; set; }

        [MaxLength(14, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string Cpf { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string Rua { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string Cidade { get; set; }
    }
}
