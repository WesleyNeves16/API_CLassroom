using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomRegistration.Context
{
    [Table("Aluno")]
    public class Aluno
    {
        [Required]
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
