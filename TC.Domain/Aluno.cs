using System.ComponentModel.DataAnnotations;

namespace TC.Domain
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")] 
        [MaxLength(100,ErrorMessage = "{0} pode ter no máximo {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [MaxLength(14, ErrorMessage = "{0} pode ter no máximo {1}")]
        public string CPF { get; set; }
    }
}
