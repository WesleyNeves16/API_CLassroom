using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomRegistration.Context
{
    [Table("Prova")]
    public class Prova
    {
        [Required]
        [Key]
        public int Codigo { get; set; }
        public int CodAluno { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int Peso { get; set; }
        public float Nota { get; set; }
    }
}
