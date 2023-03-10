using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alunos.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public string?  Nome { get; set; }

        public string? Email { get; set; }

        [NotMapped]
        public virtual List<Materia>? Materias { get; set; }
    }
}
